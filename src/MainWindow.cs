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

namespace VisualTraceroute {
    public partial class MainWindow : Form {
        bool workerRunning = false;

        public MainWindow() {
            InitializeComponent();
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
            } else {
                this.dgvTracert.Rows.Clear();
                var args = Tuple.Create<string, int, int>(tbTarget.Text, ttl, hops);
                this.tracerouteWorker.RunWorkerAsync(args);

                this.btnTraceroute.Text = "Cancel";
                workerRunning = true;
            }
        }

        private void tracerouteWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            this.btnTraceroute.Text = "Traceroute";

            workerRunning = false;
        }

        private void tracerouteWorker_DoWork(object sender, DoWorkEventArgs e) {
            Stopwatch watch = new Stopwatch();

            List<IPAddress> results = new List<IPAddress>();
            var args = e.Argument as Tuple<string, int, int>;

            Ping ping = new Ping();
            PingOptions pingOptions = new PingOptions(1, true);
             
            PingReply reply   = default(PingReply);
            IPAddress[] hosts = Dns.GetHostAddresses(args.Item1);
            IPAddress host    = hosts[0];

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
                    AddRow(reply.Address, GetHostname(reply.Address), watch.ElapsedMilliseconds, i);
                    break;
                } else if (reply.Status == IPStatus.TtlExpired) {
                    AddRow(reply.Address, GetHostname(reply.Address), watch.ElapsedMilliseconds, i);
                    pingOptions.Ttl += 1;
                } else {
                    Console.WriteLine("error: " + reply.Status);
                }
            }
        }

        delegate void AddRowCallback(IPAddress address, string hostname, long delay, int seq);
        private void AddRow(IPAddress address, string hostname, long delay, int seq) {
            if (this.dgvTracert.InvokeRequired) {
                AddRowCallback callback = new AddRowCallback(AddRow);
                this.Invoke(callback, new object[] { address, hostname, delay, seq });
            } else {
                object[] buffer = new object[4];
                List<DataGridViewRow> rows = new List<DataGridViewRow>();

                buffer[0] = seq;
                buffer[1] = delay.ToString();
                buffer[2] = hostname;
                buffer[3] = address.ToString();
                rows.Add(new DataGridViewRow());

                rows[rows.Count - 1].CreateCells(this.dgvTracert, buffer);
                this.dgvTracert.Rows.AddRange(rows.ToArray());
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
    }
}
