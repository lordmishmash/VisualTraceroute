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
            this.dgvcSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTraceroute = new System.Windows.Forms.Panel();
            this.lbMs = new System.Windows.Forms.Label();
            this.btnTraceroute = new System.Windows.Forms.Button();
            this.tbMaxHops = new System.Windows.Forms.TextBox();
            this.lbMaxHop = new System.Windows.Forms.Label();
            this.tbTTL = new System.Windows.Forms.TextBox();
            this.lbTTL = new System.Windows.Forms.Label();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.lbTarget = new System.Windows.Forms.Label();
            this.tbMaps = new System.Windows.Forms.TabPage();
            this.tracerouteWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpVisualTraceroute.SuspendLayout();
            this.tpTraceroute.SuspendLayout();
            this.tlpTraceroute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracert)).BeginInit();
            this.panelTraceroute.SuspendLayout();
            this.tbMaps.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpVisualTraceroute
            // 
            this.tlpVisualTraceroute.Controls.Add(this.tpTraceroute);
            this.tlpVisualTraceroute.Controls.Add(this.tbMaps);
            this.tlpVisualTraceroute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVisualTraceroute.Location = new System.Drawing.Point(4, 4);
            this.tlpVisualTraceroute.Name = "tlpVisualTraceroute";
            this.tlpVisualTraceroute.Padding = new System.Drawing.Point(16, 6);
            this.tlpVisualTraceroute.SelectedIndex = 0;
            this.tlpVisualTraceroute.Size = new System.Drawing.Size(789, 409);
            this.tlpVisualTraceroute.TabIndex = 0;
            // 
            // tpTraceroute
            // 
            this.tpTraceroute.Controls.Add(this.tlpTraceroute);
            this.tpTraceroute.Location = new System.Drawing.Point(4, 35);
            this.tpTraceroute.Name = "tpTraceroute";
            this.tpTraceroute.Padding = new System.Windows.Forms.Padding(3);
            this.tpTraceroute.Size = new System.Drawing.Size(781, 370);
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
            this.tlpTraceroute.Size = new System.Drawing.Size(775, 364);
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
            this.dgvTracert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcSeq,
            this.dgvcTime,
            this.dgvcHost,
            this.dgvcAddress});
            this.dgvTracert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTracert.Location = new System.Drawing.Point(3, 166);
            this.dgvTracert.Name = "dgvTracert";
            this.dgvTracert.RowHeadersVisible = false;
            this.dgvTracert.Size = new System.Drawing.Size(769, 195);
            this.dgvTracert.TabIndex = 2;
            // 
            // dgvcSeq
            // 
            this.dgvcSeq.HeaderText = "Seq";
            this.dgvcSeq.Name = "dgvcSeq";
            this.dgvcSeq.ReadOnly = true;
            // 
            // dgvcTime
            // 
            this.dgvcTime.HeaderText = "Time (ms)";
            this.dgvcTime.Name = "dgvcTime";
            this.dgvcTime.ReadOnly = true;
            // 
            // dgvcHost
            // 
            this.dgvcHost.HeaderText = "Host";
            this.dgvcHost.Name = "dgvcHost";
            this.dgvcHost.ReadOnly = true;
            // 
            // dgvcAddress
            // 
            this.dgvcAddress.HeaderText = "IP Address";
            this.dgvcAddress.Name = "dgvcAddress";
            this.dgvcAddress.ReadOnly = true;
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
            this.tbMaxHops.Text = "25";
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
            this.tbTTL.Text = "200";
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
            // tbMaps
            // 
            this.tbMaps.Controls.Add(this.label1);
            this.tbMaps.Location = new System.Drawing.Point(4, 35);
            this.tbMaps.Name = "tbMaps";
            this.tbMaps.Padding = new System.Windows.Forms.Padding(3);
            this.tbMaps.Size = new System.Drawing.Size(781, 370);
            this.tbMaps.TabIndex = 1;
            this.tbMaps.Text = "Maps";
            this.tbMaps.UseVisualStyleBackColor = true;
            // 
            // tracerouteWorker
            // 
            this.tracerouteWorker.WorkerReportsProgress = true;
            this.tracerouteWorker.WorkerSupportsCancellation = true;
            this.tracerouteWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.tracerouteWorker_DoWork);
            this.tracerouteWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.tracerouteWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 364);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not yet implemented";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 417);
            this.Controls.Add(this.tlpVisualTraceroute);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "VisualTraceroute";
            this.tlpVisualTraceroute.ResumeLayout(false);
            this.tpTraceroute.ResumeLayout(false);
            this.tlpTraceroute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracert)).EndInit();
            this.panelTraceroute.ResumeLayout(false);
            this.panelTraceroute.PerformLayout();
            this.tbMaps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tlpVisualTraceroute;
        private System.Windows.Forms.TabPage tpTraceroute;
        private System.Windows.Forms.TableLayoutPanel tlpTraceroute;
        private System.Windows.Forms.TabPage tbMaps;
        private System.Windows.Forms.Panel panelTraceroute;
        private System.Windows.Forms.Label lbTarget;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.TextBox tbTTL;
        private System.Windows.Forms.Label lbTTL;
        private System.Windows.Forms.TextBox tbMaxHops;
        private System.Windows.Forms.Label lbMaxHop;
        private System.Windows.Forms.DataGridView dgvTracert;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcAddress;
        private System.Windows.Forms.Button btnTraceroute;
        private System.ComponentModel.BackgroundWorker tracerouteWorker;
        private System.Windows.Forms.Label lbMs;
        private System.Windows.Forms.Label label1;


    }
}

