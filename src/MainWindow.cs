using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Diagnostics;
using System.Net.Sockets;
using System.IO;
using System.Reflection;

namespace VisualTraceroute {
    public partial class MainWindow : Form {
        bool workerRunning = false;
        bool geoipDbLoaded = false;

        SyncList<HopEntry> hopEntries;
        LookupService lookupService;

        public MainWindow() {
            InitializeComponent();
            hopEntries = new SyncList<HopEntry>(this);

            dgvTracert.DataSource = hopEntries;
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            string GeoipPath = "./res/GeoLiteCity.dat";
            if (Properties.Settings.Default.geoipUseInternal) {
                this.rbGeoipInternal.Checked = true;
            } else {
                this.rbGeoipFile.Checked = true;
                this.tbGeoipDb.Text = GeoipPath = Properties.Settings.Default.geoipDbPath;
            }

            GeoipLoadDatabase(GeoipPath);
        }

        private bool GeoipLoadDatabase(string GeoipPath) {
            try {
                lookupService = new LookupService(GeoipPath, LookupService.GEOIP_STANDARD);
                lookupService.getCountry("255.255.255.255");    // GeoIP reads the db only when asked to do something

                geoipDbLoaded = true;
            } catch (Exception) {
                MessageBox.Show("Could not load Geoip database. Traceroute mapping will not be possible.", "Failed loading database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnTraceroute_Click(object sender, EventArgs e) {
            // Validate the form
            UriHostNameType hostType = Uri.CheckHostName(tbTarget.Text);
            if (hostType == UriHostNameType.Unknown) {
                MessageBox.Show("Please enter a valid target hostname.");
                return;
            }

            int ttl;
            if (!int.TryParse(tbTTL.Text, out ttl)) {
                MessageBox.Show("Please enter a valid TTL (Time to Live) value.");
                return;
            }

            int hops;
            if (!int.TryParse(tbMaxHops.Text, out hops)) {
                MessageBox.Show("Please enter a valid max hop count.");
                return;
            }

            // Start the worker
            if (workerRunning) {
                this.tracerouteWorker.CancelAsync();
                this.btnTraceroute.Text = "Cancelling...";
                this.btnTraceroute.Enabled = false;
            } else {
                hopEntries.Clear();
                this.tbTarget.Enabled = this.tbTTL.Enabled = this.tbMaxHops.Enabled = false;
                var args = Tuple.Create<string, int, int>(tbTarget.Text, ttl, hops);
                this.tracerouteWorker.RunWorkerAsync(args);

                this.btnTraceroute.Text = "Cancel";
                workerRunning = true;
            }
        }

        private void tracerouteWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            this.btnTraceroute.Enabled = this.tbTarget.Enabled = this.tbTTL.Enabled = this.tbMaxHops.Enabled = true;
            this.btnTraceroute.Text = "Traceroute";
            workerRunning = false;

            tpMaps_Load(sender, e);

            if (!e.Cancelled && e.Result != null && !((bool)e.Result)) {
                MessageBox.Show("Couldnt resolve target hostname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tracerouteWorker_DoWork(object sender, DoWorkEventArgs e) {
            Stopwatch watch = new Stopwatch();

            List<IPAddress> results = new List<IPAddress>();
            var args = e.Argument as Tuple<string, int, int>;

            Ping ping = new Ping();
            PingOptions pingOptions = new PingOptions(1, true);
             
            PingReply reply   = default(PingReply);
            IPAddress host;
            try {
                IPAddress[] hosts = Dns.GetHostAddresses(args.Item1);
                host = hosts[0];
            } catch (Exception) {
                e.Result = false;
                return;
            }

            for (int i = 1; i < args.Item3 + 1; i++) {
                watch.Reset();
                watch.Start();
                reply = ping.Send(host, args.Item2, new byte[32], pingOptions);
                watch.Stop();

                if (this.tracerouteWorker.CancellationPending == true) {
                    e.Cancel = true;
                    break;
                }

                if (reply.Status == IPStatus.Success) {
                    hopEntries.Add(new HopEntry (i, watch.ElapsedMilliseconds, GetHostname(reply.Address), reply.Address.ToString()));
                    break;
                } else if (reply.Status == IPStatus.TtlExpired) {
                    hopEntries.Add(new HopEntry(i, watch.ElapsedMilliseconds, GetHostname(reply.Address), reply.Address.ToString()));
                    pingOptions.Ttl += 1;
                } else if (reply.Status == IPStatus.TimedOut) {
                    hopEntries.Add(new HopEntry(i, 0, "time out: try increasing the TTL", ""));
                } else {
                    hopEntries.Add(new HopEntry(i, 0, string.Format("unknown error: {0}", reply.Status), ""));
                }
                dgvTracert.Invoke((Action)(() => dgvTracert.DataSource = hopEntries));
            }
        }

        private string GetHostname(IPAddress address) {
            string result;
            try {
                IPHostEntry entry = Dns.GetHostEntry(address);
                result = entry.HostName;
            } catch (Exception) {
                result = "unknown";
            }
            return result;
        }

        private void tlpVisualTraceroute_SelectedIndexChanged(object sender, EventArgs e) {
            if (tlpVisualTraceroute.SelectedTab == tlpVisualTraceroute.TabPages["tpMaps"])
                tpMaps_Load(sender, e);
        }

        private void tpMaps_Load(object sender, EventArgs e) {
            if (workerRunning) {
                lbMapStatus.Text = "Traceroute in progress, please wait for it to finish.";
                return;
            }

            if (hopEntries.Count == 0) {
                lbMapStatus.Text = "No entries to map. Please do a traceroute.";
            } else {
                lbMapStatus.Text = string.Format("{0} nodes can be mapped.", hopEntries.Where(s => s.IP != string.Empty && !IsLanIP(IPAddress.Parse(s.IP))).ToList().Count);
                btnMap.Enabled = true;
            }
        }


        /**
         * Taken from StackOverflow: http://stackoverflow.com/a/7232612
         * Original author: Jonathan Dickinson (http://stackoverflow.com/users/430560/jonathan-dickinson)
         */
        private static bool IsLanIP(IPAddress address) {
            var interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var iface in interfaces) {
                var properties = iface.GetIPProperties();
                foreach (var ifAddr in properties.UnicastAddresses) {
                    if (ifAddr.IPv4Mask != null &&
                        ifAddr.Address.AddressFamily == AddressFamily.InterNetwork &&
                        CheckMask(ifAddr.Address, ifAddr.IPv4Mask, address))
                        return true;
                }
            }
            return false;
        }

        /**
         * Taken from StackOverflow: http://stackoverflow.com/a/7232612
         * Original author: Jonathan Dickinson (http://stackoverflow.com/users/430560/jonathan-dickinson)
         */
        private static bool CheckMask(IPAddress address, IPAddress mask, IPAddress target) {
            if (mask == null)
                return false;

            var ba = address.GetAddressBytes();
            var bm = mask.GetAddressBytes();
            var bb = target.GetAddressBytes();

            if (ba.Length != bm.Length || bm.Length != bb.Length)
                return false;

            for (var i = 0; i < ba.Length; i++) {
                int m = bm[i];

                int a = ba[i] & m;
                int b = bb[i] & m;

                if (a != b)
                    return false;
            }

            return true;
        }

        private void btnMap_Click(object sender, EventArgs e) {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("VisualTraceroute.res.maps.html"))
            using (StreamReader reader = new StreamReader(stream)) {
                webMap.DocumentText = reader.ReadToEnd();
            }

            webMap.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webMap_DocumentCompleted);
        }

        private void webMap_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            HtmlElement points = webMap.Document.GetElementById("points");
            foreach (HopEntry entry in hopEntries.Where(s => s.IP != string.Empty && !IsLanIP(IPAddress.Parse(s.IP)))) {
                Location location = lookupService.getLocation(entry.IP);
                if (location != null) {
                    HtmlElement point = webMap.Document.CreateElement("div");
                    point.SetAttribute("class", "point");
                    point.SetAttribute("data-lat", location.latitude.ToString());
                    point.SetAttribute("data-lng", location.longitude.ToString());
                    point.SetAttribute("data-seq", entry.Seq.ToString());
                    point.SetAttribute("data-ip", entry.IP);

                    points.AppendChild(point);
                }
            }
            webMap.Document.InvokeScript("mapNodes");
        }

        private void rbGeoipInternal_CheckedChanged_1(object sender, EventArgs e) {
            btnGeoipBrowse.Enabled = false;
            Properties.Settings.Default.geoipUseInternal = true;
        }

        private void rbGeoipFile_CheckedChanged_1(object sender, EventArgs e) {
            btnGeoipBrowse.Enabled = true;
            Properties.Settings.Default.geoipUseInternal = false;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
        }

        private void btnGeoipBrowse_Click(object sender, EventArgs e) {
            string input = string.Empty;

            string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            if (Environment.OSVersion.Version.Major >= 6) {
                path = Directory.GetParent(path).FullName;
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Geoip Database (*.dat)|*.dat|All files(*.*)|*.*";
            dialog.InitialDirectory = path;

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK) {
                tbGeoipDb.Text = dialog.FileName;

                if (GeoipLoadDatabase(dialog.FileName)) {
                    Properties.Settings.Default.geoipUseInternal = false;
                    Properties.Settings.Default.geoipDbPath = dialog.FileName;
                } else {
                    tbGeoipDb.Text = "";
                }
            }
        }
    }


    internal class HopEntry {
        public HopEntry(int Seq, long Time, string Host, string IP) {
            this.Seq  = Seq;
            this.Time = Time;
            this.Host = Host;
            this.IP   = IP;
        }

        public int Seq {
            get;
            set;
        }

        public long Time {
            get;
            set;
        }

        public string Host {
            get;
            set;
        }

        public string IP {
            get;
            set;
        }
    }
}
