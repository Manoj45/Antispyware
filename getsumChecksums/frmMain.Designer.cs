namespace getsumChecksums
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.lblRootPath = new System.Windows.Forms.Label();
            this.cmbHashType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdRescan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(12, 12);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(121, 23);
            this.cmdBrowse.TabIndex = 1;
            this.cmdBrowse.Text = "Select Root";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.lstFiles.FullRowSelect = true;
            this.lstFiles.GridLines = true;
            this.lstFiles.Location = new System.Drawing.Point(12, 41);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(647, 269);
            this.lstFiles.TabIndex = 3;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            this.lstFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFiles_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 177;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Path";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hash Value";
            this.columnHeader4.Width = 270;
            // 
            // lblRootPath
            // 
            this.lblRootPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRootPath.Location = new System.Drawing.Point(139, 12);
            this.lblRootPath.Name = "lblRootPath";
            this.lblRootPath.Size = new System.Drawing.Size(452, 23);
            this.lblRootPath.TabIndex = 5;
            this.lblRootPath.Text = "...";
            // 
            // cmbHashType
            // 
            this.cmbHashType.FormattingEnabled = true;
            this.cmbHashType.Items.AddRange(new object[] {
            "MD5",
            "SHA1"});
            this.cmbHashType.Location = new System.Drawing.Point(532, 318);
            this.cmbHashType.Name = "cmbHashType";
            this.cmbHashType.Size = new System.Drawing.Size(127, 21);
            this.cmbHashType.TabIndex = 6;
            this.cmbHashType.TextChanged += new System.EventHandler(this.cmbHashType_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Checksum Type:";
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(12, 316);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 8;
            this.cmdClear.Text = "Clear List";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdRescan
            // 
            this.cmdRescan.Location = new System.Drawing.Point(597, 12);
            this.cmdRescan.Name = "cmdRescan";
            this.cmdRescan.Size = new System.Drawing.Size(62, 23);
            this.cmdRescan.TabIndex = 9;
            this.cmdRescan.Text = "Rescan";
            this.cmdRescan.UseVisualStyleBackColor = true;
            this.cmdRescan.Click += new System.EventHandler(this.cmdRescan_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 351);
            this.Controls.Add(this.cmdRescan);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHashType);
            this.Controls.Add(this.lblRootPath);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.cmdBrowse);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "getsumChecksums";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label lblRootPath;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cmbHashType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdRescan;
    }
}

