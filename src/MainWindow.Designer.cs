namespace VisualTraceroute {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tlpVisualTraceroute = new System.Windows.Forms.TabControl();
            this.tpTraceroute = new System.Windows.Forms.TabPage();
            this.tlpTraceroute = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTracert = new System.Windows.Forms.DataGridView();
            this.panelTraceroute = new System.Windows.Forms.Panel();
            this.lbMs = new System.Windows.Forms.Label();
            this.btnTraceroute = new System.Windows.Forms.Button();
            this.tbMaxHops = new System.Windows.Forms.TextBox();
            this.lbMaxHop = new System.Windows.Forms.Label();
            this.tbTTL = new System.Windows.Forms.TextBox();
            this.lbTTL = new System.Windows.Forms.Label();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.lbTarget = new System.Windows.Forms.Label();
            this.tpMaps = new System.Windows.Forms.TabPage();
            this.scMap = new System.Windows.Forms.SplitContainer();
            this.btnMap = new System.Windows.Forms.Button();
            this.lbMapStatus = new System.Windows.Forms.Label();
            this.lbMapStatusDesc = new System.Windows.Forms.Label();
            this.webMap = new System.Windows.Forms.WebBrowser();
            this.tpGeoip = new System.Windows.Forms.TabPage();
            this.tracerouteWorker = new System.ComponentModel.BackgroundWorker();
            this.tlpGeoip = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbMaxMind = new System.Windows.Forms.Label();
            this.llbMaxmind = new System.Windows.Forms.LinkLabel();
            this.panelGeoip = new System.Windows.Forms.Panel();
            this.rbGeoipInternal = new System.Windows.Forms.RadioButton();
            this.rbGeoipFile = new System.Windows.Forms.RadioButton();
            this.tbGeoipDb = new System.Windows.Forms.TextBox();
            this.btnGeoipBrowse = new System.Windows.Forms.Button();
            this.tlpVisualTraceroute.SuspendLayout();
            this.tpTraceroute.SuspendLayout();
            this.tlpTraceroute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracert)).BeginInit();
            this.panelTraceroute.SuspendLayout();
            this.tpMaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMap)).BeginInit();
            this.scMap.Panel1.SuspendLayout();
            this.scMap.Panel2.SuspendLayout();
            this.scMap.SuspendLayout();
            this.tpGeoip.SuspendLayout();
            this.tlpGeoip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelGeoip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpVisualTraceroute
            // 
            this.tlpVisualTraceroute.Controls.Add(this.tpTraceroute);
            this.tlpVisualTraceroute.Controls.Add(this.tpMaps);
            this.tlpVisualTraceroute.Controls.Add(this.tpGeoip);
            this.tlpVisualTraceroute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVisualTraceroute.Location = new System.Drawing.Point(4, 4);
            this.tlpVisualTraceroute.Name = "tlpVisualTraceroute";
            this.tlpVisualTraceroute.Padding = new System.Drawing.Point(16, 6);
            this.tlpVisualTraceroute.SelectedIndex = 0;
            this.tlpVisualTraceroute.Size = new System.Drawing.Size(651, 409);
            this.tlpVisualTraceroute.TabIndex = 0;
            this.tlpVisualTraceroute.SelectedIndexChanged += new System.EventHandler(this.tlpVisualTraceroute_SelectedIndexChanged);
            // 
            // tpTraceroute
            // 
            this.tpTraceroute.Controls.Add(this.tlpTraceroute);
            this.tpTraceroute.Location = new System.Drawing.Point(4, 35);
            this.tpTraceroute.Name = "tpTraceroute";
            this.tpTraceroute.Padding = new System.Windows.Forms.Padding(3);
            this.tpTraceroute.Size = new System.Drawing.Size(643, 370);
            this.tpTraceroute.TabIndex = 0;
            this.tpTraceroute.Text = "Traceroute";
            this.tpTraceroute.UseVisualStyleBackColor = true;
            // 
            // tlpTraceroute
            // 
            this.tlpTraceroute.ColumnCount = 1;
            this.tlpTraceroute.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTraceroute.Controls.Add(this.dgvTracert, 0, 1);
            this.tlpTraceroute.Controls.Add(this.panelTraceroute, 0, 0);
            this.tlpTraceroute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTraceroute.Location = new System.Drawing.Point(3, 3);
            this.tlpTraceroute.Name = "tlpTraceroute";
            this.tlpTraceroute.RowCount = 2;
            this.tlpTraceroute.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTraceroute.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTraceroute.Size = new System.Drawing.Size(637, 364);
            this.tlpTraceroute.TabIndex = 2;
            // 
            // dgvTracert
            // 
            this.dgvTracert.AllowUserToAddRows = false;
            this.dgvTracert.AllowUserToDeleteRows = false;
            this.dgvTracert.AllowUserToResizeColumns = false;
            this.dgvTracert.AllowUserToResizeRows = false;
            this.dgvTracert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTracert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTracert.Location = new System.Drawing.Point(3, 166);
            this.dgvTracert.Name = "dgvTracert";
            this.dgvTracert.ReadOnly = true;
            this.dgvTracert.RowHeadersVisible = false;
            this.dgvTracert.Size = new System.Drawing.Size(631, 195);
            this.dgvTracert.TabIndex = 2;
            // 
            // panelTraceroute
            // 
            this.panelTraceroute.Controls.Add(this.lbMs);
            this.panelTraceroute.Controls.Add(this.btnTraceroute);
            this.panelTraceroute.Controls.Add(this.tbMaxHops);
            this.panelTraceroute.Controls.Add(this.lbMaxHop);
            this.panelTraceroute.Controls.Add(this.tbTTL);
            this.panelTraceroute.Controls.Add(this.lbTTL);
            this.panelTraceroute.Controls.Add(this.tbTarget);
            this.panelTraceroute.Controls.Add(this.lbTarget);
            this.panelTraceroute.Location = new System.Drawing.Point(3, 3);
            this.panelTraceroute.Name = "panelTraceroute";
            this.panelTraceroute.Size = new System.Drawing.Size(419, 157);
            this.panelTraceroute.TabIndex = 1;
            // 
            // lbMs
            // 
            this.lbMs.AutoSize = true;
            this.lbMs.Location = new System.Drawing.Point(184, 49);
            this.lbMs.Name = "lbMs";
            this.lbMs.Size = new System.Drawing.Size(28, 20);
            this.lbMs.TabIndex = 8;
            this.lbMs.Text = "ms";
            // 
            // btnTraceroute
            // 
            this.btnTraceroute.Location = new System.Drawing.Point(318, 125);
            this.btnTraceroute.Name = "btnTraceroute";
            this.btnTraceroute.Size = new System.Drawing.Size(98, 29);
            this.btnTraceroute.TabIndex = 7;
            this.btnTraceroute.Text = "Traceroute";
            this.btnTraceroute.UseVisualStyleBackColor = true;
            this.btnTraceroute.Click += new System.EventHandler(this.btnTraceroute_Click);
            // 
            // tbMaxHops
            // 
            this.tbMaxHops.Location = new System.Drawing.Point(106, 80);
            this.tbMaxHops.Name = "tbMaxHops";
            this.tbMaxHops.Size = new System.Drawing.Size(72, 25);
            this.tbMaxHops.TabIndex = 6;
            this.tbMaxHops.Text = "30";
            // 
            // lbMaxHop
            // 
            this.lbMaxHop.AutoSize = true;
            this.lbMaxHop.Location = new System.Drawing.Point(15, 83);
            this.lbMaxHop.Name = "lbMaxHop";
            this.lbMaxHop.Size = new System.Drawing.Size(77, 20);
            this.lbMaxHop.TabIndex = 5;
            this.lbMaxHop.Text = "Max hops:";
            // 
            // tbTTL
            // 
            this.tbTTL.Location = new System.Drawing.Point(106, 46);
            this.tbTTL.Name = "tbTTL";
            this.tbTTL.Size = new System.Drawing.Size(72, 25);
            this.tbTTL.TabIndex = 4;
            this.tbTTL.Text = "1000";
            // 
            // lbTTL
            // 
            this.lbTTL.AutoSize = true;
            this.lbTTL.Location = new System.Drawing.Point(15, 49);
            this.lbTTL.Name = "lbTTL";
            this.lbTTL.Size = new System.Drawing.Size(41, 20);
            this.lbTTL.TabIndex = 3;
            this.lbTTL.Text = "TTL:";
            // 
            // tbTarget
            // 
            this.tbTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTarget.Location = new System.Drawing.Point(106, 11);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(310, 25);
            this.tbTarget.TabIndex = 2;
            this.tbTarget.Text = "www.google.com";
            // 
            // lbTarget
            // 
            this.lbTarget.AutoSize = true;
            this.lbTarget.Location = new System.Drawing.Point(15, 14);
            this.lbTarget.Name = "lbTarget";
            this.lbTarget.Size = new System.Drawing.Size(60, 20);
            this.lbTarget.TabIndex = 0;
            this.lbTarget.Text = "Target:";
            // 
            // tpMaps
            // 
            this.tpMaps.Controls.Add(this.scMap);
            this.tpMaps.Location = new System.Drawing.Point(4, 35);
            this.tpMaps.Name = "tpMaps";
            this.tpMaps.Padding = new System.Windows.Forms.Padding(3);
            this.tpMaps.Size = new System.Drawing.Size(695, 366);
            this.tpMaps.TabIndex = 1;
            this.tpMaps.Text = "Maps";
            this.tpMaps.UseVisualStyleBackColor = true;
            // 
            // scMap
            // 
            this.scMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMap.Location = new System.Drawing.Point(3, 3);
            this.scMap.Name = "scMap";
            this.scMap.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMap.Panel1
            // 
            this.scMap.Panel1.Controls.Add(this.btnMap);
            this.scMap.Panel1.Controls.Add(this.lbMapStatus);
            this.scMap.Panel1.Controls.Add(this.lbMapStatusDesc);
            // 
            // scMap.Panel2
            // 
            this.scMap.Panel2.Controls.Add(this.webMap);
            this.scMap.Size = new System.Drawing.Size(689, 360);
            this.scMap.SplitterDistance = 106;
            this.scMap.TabIndex = 0;
            // 
            // btnMap
            // 
            this.btnMap.Enabled = false;
            this.btnMap.Location = new System.Drawing.Point(19, 65);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(135, 31);
            this.btnMap.TabIndex = 2;
            this.btnMap.Text = "Start mapping";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // lbMapStatus
            // 
            this.lbMapStatus.AutoSize = true;
            this.lbMapStatus.Location = new System.Drawing.Point(86, 13);
            this.lbMapStatus.Name = "lbMapStatus";
            this.lbMapStatus.Size = new System.Drawing.Size(0, 20);
            this.lbMapStatus.TabIndex = 1;
            // 
            // lbMapStatusDesc
            // 
            this.lbMapStatusDesc.AutoSize = true;
            this.lbMapStatusDesc.Location = new System.Drawing.Point(15, 13);
            this.lbMapStatusDesc.Name = "lbMapStatusDesc";
            this.lbMapStatusDesc.Size = new System.Drawing.Size(56, 20);
            this.lbMapStatusDesc.TabIndex = 0;
            this.lbMapStatusDesc.Text = "Status:";
            // 
            // webMap
            // 
            this.webMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webMap.Location = new System.Drawing.Point(0, 0);
            this.webMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMap.Name = "webMap";
            this.webMap.Size = new System.Drawing.Size(689, 250);
            this.webMap.TabIndex = 1;
            // 
            // tpGeoip
            // 
            this.tpGeoip.Controls.Add(this.tlpGeoip);
            this.tpGeoip.Location = new System.Drawing.Point(4, 35);
            this.tpGeoip.Name = "tpGeoip";
            this.tpGeoip.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeoip.Size = new System.Drawing.Size(643, 370);
            this.tpGeoip.TabIndex = 2;
            this.tpGeoip.Text = "GeoIP Database";
            this.tpGeoip.UseVisualStyleBackColor = true;
            // 
            // tracerouteWorker
            // 
            this.tracerouteWorker.WorkerReportsProgress = true;
            this.tracerouteWorker.WorkerSupportsCancellation = true;
            this.tracerouteWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.tracerouteWorker_DoWork);
            this.tracerouteWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.tracerouteWorker_RunWorkerCompleted);
            // 
            // tlpGeoip
            // 
            this.tlpGeoip.ColumnCount = 1;
            this.tlpGeoip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeoip.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tlpGeoip.Controls.Add(this.panelGeoip, 0, 0);
            this.tlpGeoip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeoip.Location = new System.Drawing.Point(3, 3);
            this.tlpGeoip.Name = "tlpGeoip";
            this.tlpGeoip.RowCount = 2;
            this.tlpGeoip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeoip.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGeoip.Size = new System.Drawing.Size(637, 364);
            this.tlpGeoip.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.lbMaxMind);
            this.flowLayoutPanel1.Controls.Add(this.llbMaxmind);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 341);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(631, 20);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbMaxMind
            // 
            this.lbMaxMind.AutoSize = true;
            this.lbMaxMind.Location = new System.Drawing.Point(3, 0);
            this.lbMaxMind.Name = "lbMaxMind";
            this.lbMaxMind.Size = new System.Drawing.Size(349, 20);
            this.lbMaxMind.TabIndex = 0;
            this.lbMaxMind.Text = "Geolocation data and API provided by Maxmind at:";
            // 
            // llbMaxmind
            // 
            this.llbMaxmind.AutoSize = true;
            this.llbMaxmind.Location = new System.Drawing.Point(358, 0);
            this.llbMaxmind.Name = "llbMaxmind";
            this.llbMaxmind.Size = new System.Drawing.Size(194, 20);
            this.llbMaxmind.TabIndex = 1;
            this.llbMaxmind.TabStop = true;
            this.llbMaxmind.Text = "http://www.maxmind.com";
            // 
            // panelGeoip
            // 
            this.panelGeoip.Controls.Add(this.btnGeoipBrowse);
            this.panelGeoip.Controls.Add(this.tbGeoipDb);
            this.panelGeoip.Controls.Add(this.rbGeoipFile);
            this.panelGeoip.Controls.Add(this.rbGeoipInternal);
            this.panelGeoip.Location = new System.Drawing.Point(3, 3);
            this.panelGeoip.Name = "panelGeoip";
            this.panelGeoip.Padding = new System.Windows.Forms.Padding(3);
            this.panelGeoip.Size = new System.Drawing.Size(591, 227);
            this.panelGeoip.TabIndex = 1;
            // 
            // rbGeoipInternal
            // 
            this.rbGeoipInternal.AutoSize = true;
            this.rbGeoipInternal.Checked = true;
            this.rbGeoipInternal.Location = new System.Drawing.Point(19, 18);
            this.rbGeoipInternal.Name = "rbGeoipInternal";
            this.rbGeoipInternal.Size = new System.Drawing.Size(272, 24);
            this.rbGeoipInternal.TabIndex = 0;
            this.rbGeoipInternal.TabStop = true;
            this.rbGeoipInternal.Text = "Use internal database (GeoLite City)";
            this.rbGeoipInternal.UseVisualStyleBackColor = true;
            this.rbGeoipInternal.CheckedChanged += new System.EventHandler(this.rbGeoipInternal_CheckedChanged_1);
            // 
            // rbGeoipFile
            // 
            this.rbGeoipFile.AutoSize = true;
            this.rbGeoipFile.Location = new System.Drawing.Point(19, 48);
            this.rbGeoipFile.Name = "rbGeoipFile";
            this.rbGeoipFile.Size = new System.Drawing.Size(83, 24);
            this.rbGeoipFile.TabIndex = 1;
            this.rbGeoipFile.Text = "Use file:";
            this.rbGeoipFile.UseVisualStyleBackColor = true;
            this.rbGeoipFile.CheckedChanged += new System.EventHandler(this.rbGeoipFile_CheckedChanged_1);
            // 
            // tbGeoipDb
            // 
            this.tbGeoipDb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGeoipDb.Enabled = false;
            this.tbGeoipDb.Location = new System.Drawing.Point(108, 47);
            this.tbGeoipDb.Name = "tbGeoipDb";
            this.tbGeoipDb.Size = new System.Drawing.Size(477, 25);
            this.tbGeoipDb.TabIndex = 2;
            // 
            // btnGeoipBrowse
            // 
            this.btnGeoipBrowse.Enabled = false;
            this.btnGeoipBrowse.Location = new System.Drawing.Point(105, 75);
            this.btnGeoipBrowse.Name = "btnGeoipBrowse";
            this.btnGeoipBrowse.Size = new System.Drawing.Size(99, 30);
            this.btnGeoipBrowse.TabIndex = 3;
            this.btnGeoipBrowse.Text = "Browse...";
            this.btnGeoipBrowse.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 417);
            this.Controls.Add(this.tlpVisualTraceroute);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(675, 455);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualTraceroute";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tlpVisualTraceroute.ResumeLayout(false);
            this.tpTraceroute.ResumeLayout(false);
            this.tlpTraceroute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracert)).EndInit();
            this.panelTraceroute.ResumeLayout(false);
            this.panelTraceroute.PerformLayout();
            this.tpMaps.ResumeLayout(false);
            this.scMap.Panel1.ResumeLayout(false);
            this.scMap.Panel1.PerformLayout();
            this.scMap.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMap)).EndInit();
            this.scMap.ResumeLayout(false);
            this.tpGeoip.ResumeLayout(false);
            this.tlpGeoip.ResumeLayout(false);
            this.tlpGeoip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelGeoip.ResumeLayout(false);
            this.panelGeoip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tlpVisualTraceroute;
        private System.Windows.Forms.TabPage tpTraceroute;
        private System.Windows.Forms.TableLayoutPanel tlpTraceroute;
        private System.Windows.Forms.TabPage tpMaps;
        private System.Windows.Forms.Panel panelTraceroute;
        private System.Windows.Forms.Label lbTarget;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.TextBox tbTTL;
        private System.Windows.Forms.Label lbTTL;
        private System.Windows.Forms.TextBox tbMaxHops;
        private System.Windows.Forms.Label lbMaxHop;
        private System.Windows.Forms.DataGridView dgvTracert;
        private System.Windows.Forms.Button btnTraceroute;
        private System.ComponentModel.BackgroundWorker tracerouteWorker;
        private System.Windows.Forms.Label lbMs;
        private System.Windows.Forms.SplitContainer scMap;
        private System.Windows.Forms.Label lbMapStatus;
        private System.Windows.Forms.Label lbMapStatusDesc;
        private System.Windows.Forms.WebBrowser webMap;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.TabPage tpGeoip;
        private System.Windows.Forms.TableLayoutPanel tlpGeoip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbMaxMind;
        private System.Windows.Forms.LinkLabel llbMaxmind;
        private System.Windows.Forms.Panel panelGeoip;
        private System.Windows.Forms.RadioButton rbGeoipFile;
        private System.Windows.Forms.RadioButton rbGeoipInternal;
        private System.Windows.Forms.Button btnGeoipBrowse;
        private System.Windows.Forms.TextBox tbGeoipDb;


    }
}

