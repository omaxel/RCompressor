namespace RCompressor
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCompress = new System.Windows.Forms.Button();
            this.bkProcessFiles = new System.ComponentModel.BackgroundWorker();
            this.ckScanSubfolders = new System.Windows.Forms.CheckBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblFooter = new System.Windows.Forms.LinkLabel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlInput.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(1, 1);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(774, 268);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInput.BackColor = System.Drawing.Color.Silver;
            this.pnlInput.Controls.Add(this.txtInput);
            this.pnlInput.Location = new System.Drawing.Point(12, 53);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Padding = new System.Windows.Forms.Padding(1);
            this.pnlInput.Size = new System.Drawing.Size(776, 270);
            this.pnlInput.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(407, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Paste path of folders and/or files (one for each line)";
            // 
            // btnCompress
            // 
            this.btnCompress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(61)))), ((int)(((byte)(124)))));
            this.btnCompress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompress.Enabled = false;
            this.btnCompress.FlatAppearance.BorderSize = 0;
            this.btnCompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompress.ForeColor = System.Drawing.Color.White;
            this.btnCompress.Location = new System.Drawing.Point(639, 489);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(150, 50);
            this.btnCompress.TabIndex = 3;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = false;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // bkProcessFiles
            // 
            this.bkProcessFiles.WorkerReportsProgress = true;
            this.bkProcessFiles.WorkerSupportsCancellation = true;
            this.bkProcessFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkProcessFiles_DoWork);
            this.bkProcessFiles.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkProcessFiles_ProgressChanged);
            this.bkProcessFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkProcessFiles_RunWorkerCompleted);
            // 
            // ckScanSubfolders
            // 
            this.ckScanSubfolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckScanSubfolders.AutoSize = true;
            this.ckScanSubfolders.Checked = true;
            this.ckScanSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckScanSubfolders.Location = new System.Drawing.Point(641, 17);
            this.ckScanSubfolders.Name = "ckScanSubfolders";
            this.ckScanSubfolders.Size = new System.Drawing.Size(151, 27);
            this.ckScanSubfolders.TabIndex = 4;
            this.ckScanSubfolders.Text = "Scan subfolders";
            this.ckScanSubfolders.UseVisualStyleBackColor = true;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblProgress.Location = new System.Drawing.Point(12, 345);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(184, 23);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "Status will appear here";
            // 
            // pnlStatus
            // 
            this.pnlStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatus.BackColor = System.Drawing.Color.Silver;
            this.pnlStatus.Controls.Add(this.txtStatus);
            this.pnlStatus.Location = new System.Drawing.Point(13, 379);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnlStatus.Size = new System.Drawing.Size(776, 99);
            this.pnlStatus.TabIndex = 6;
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatus.Location = new System.Drawing.Point(1, 1);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(774, 97);
            this.txtStatus.TabIndex = 0;
            // 
            // lblFooter
            // 
            this.lblFooter.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(112)))), ((int)(((byte)(143)))));
            this.lblFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblFooter.LinkArea = new System.Windows.Forms.LinkArea(23, 96);
            this.lblFooter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblFooter.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(112)))), ((int)(((byte)(143)))));
            this.lblFooter.Location = new System.Drawing.Point(0, 1);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(800, 44);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.TabStop = true;
            this.lblFooter.Text = "Developed with love by Omar Muscatello";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFooter.UseCompatibleTextRendering = true;
            this.lblFooter.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(112)))), ((int)(((byte)(143)))));
            this.lblFooter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFooter_LinkClicked);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Silver;
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 550);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.pnlFooter.Size = new System.Drawing.Size(800, 45);
            this.pnlFooter.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.ckScanSubfolders);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlInput);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RCompressor";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCompress;
        private System.ComponentModel.BackgroundWorker bkProcessFiles;
        private System.Windows.Forms.CheckBox ckScanSubfolders;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.LinkLabel lblFooter;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.TextBox txtStatus;

    }
}

