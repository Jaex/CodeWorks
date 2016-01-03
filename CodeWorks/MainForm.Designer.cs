namespace CodeWorks
{
    partial class MainForm
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
            this.lvResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddLicense = new System.Windows.Forms.Button();
            this.btnAddLicenseAll = new System.Windows.Forms.Button();
            this.scTextBoxes = new System.Windows.Forms.SplitContainer();
            this.gbCurrentText = new System.Windows.Forms.GroupBox();
            this.tbDefaultText = new System.Windows.Forms.TextBox();
            this.gbNewText = new System.Windows.Forms.GroupBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.tbNewText = new System.Windows.Forms.TextBox();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.btnFindRegionAreas = new System.Windows.Forms.Button();
            this.btnOrderLines = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scTextBoxes)).BeginInit();
            this.scTextBoxes.Panel1.SuspendLayout();
            this.scTextBoxes.Panel2.SuspendLayout();
            this.scTextBoxes.SuspendLayout();
            this.gbCurrentText.SuspendLayout();
            this.gbNewText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResults.FullRowSelect = true;
            this.lvResults.GridLines = true;
            this.lvResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvResults.Location = new System.Drawing.Point(0, 0);
            this.lvResults.MultiSelect = false;
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(1040, 367);
            this.lvResults.TabIndex = 0;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            this.lvResults.SelectedIndexChanged += new System.EventHandler(this.lvResults_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 1036;
            // 
            // btnAddLicense
            // 
            this.btnAddLicense.Enabled = false;
            this.btnAddLicense.Location = new System.Drawing.Point(144, 8);
            this.btnAddLicense.Name = "btnAddLicense";
            this.btnAddLicense.Size = new System.Drawing.Size(144, 24);
            this.btnAddLicense.TabIndex = 1;
            this.btnAddLicense.Text = "Add license to selected";
            this.btnAddLicense.UseVisualStyleBackColor = true;
            this.btnAddLicense.Click += new System.EventHandler(this.btnAddLicense_Click);
            // 
            // btnAddLicenseAll
            // 
            this.btnAddLicenseAll.Enabled = false;
            this.btnAddLicenseAll.Location = new System.Drawing.Point(288, 8);
            this.btnAddLicenseAll.Name = "btnAddLicenseAll";
            this.btnAddLicenseAll.Size = new System.Drawing.Size(112, 24);
            this.btnAddLicenseAll.TabIndex = 2;
            this.btnAddLicenseAll.Text = "Add license to all";
            this.btnAddLicenseAll.UseVisualStyleBackColor = true;
            this.btnAddLicenseAll.Click += new System.EventHandler(this.btnAddLicenseAll_Click);
            // 
            // scTextBoxes
            // 
            this.scTextBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scTextBoxes.Location = new System.Drawing.Point(0, 0);
            this.scTextBoxes.Name = "scTextBoxes";
            // 
            // scTextBoxes.Panel1
            // 
            this.scTextBoxes.Panel1.Controls.Add(this.gbCurrentText);
            // 
            // scTextBoxes.Panel2
            // 
            this.scTextBoxes.Panel2.Controls.Add(this.gbNewText);
            this.scTextBoxes.Size = new System.Drawing.Size(1040, 362);
            this.scTextBoxes.SplitterDistance = 501;
            this.scTextBoxes.TabIndex = 6;
            // 
            // gbCurrentText
            // 
            this.gbCurrentText.Controls.Add(this.tbDefaultText);
            this.gbCurrentText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCurrentText.Location = new System.Drawing.Point(0, 0);
            this.gbCurrentText.Name = "gbCurrentText";
            this.gbCurrentText.Size = new System.Drawing.Size(501, 362);
            this.gbCurrentText.TabIndex = 0;
            this.gbCurrentText.TabStop = false;
            this.gbCurrentText.Text = "Current text";
            // 
            // tbDefaultText
            // 
            this.tbDefaultText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDefaultText.Location = new System.Drawing.Point(3, 16);
            this.tbDefaultText.Multiline = true;
            this.tbDefaultText.Name = "tbDefaultText";
            this.tbDefaultText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDefaultText.Size = new System.Drawing.Size(495, 343);
            this.tbDefaultText.TabIndex = 0;
            // 
            // gbNewText
            // 
            this.gbNewText.Controls.Add(this.btnCopyToClipboard);
            this.gbNewText.Controls.Add(this.tbNewText);
            this.gbNewText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNewText.Location = new System.Drawing.Point(0, 0);
            this.gbNewText.Name = "gbNewText";
            this.gbNewText.Size = new System.Drawing.Size(535, 362);
            this.gbNewText.TabIndex = 0;
            this.gbNewText.TabStop = false;
            this.gbNewText.Text = "New text";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyToClipboard.Location = new System.Drawing.Point(392, 328);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(115, 23);
            this.btnCopyToClipboard.TabIndex = 1;
            this.btnCopyToClipboard.Text = "Copy to clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // tbNewText
            // 
            this.tbNewText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNewText.Location = new System.Drawing.Point(3, 16);
            this.tbNewText.Multiline = true;
            this.tbNewText.Name = "tbNewText";
            this.tbNewText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbNewText.Size = new System.Drawing.Size(529, 343);
            this.tbNewText.TabIndex = 0;
            // 
            // scMain
            // 
            this.scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scMain.Location = new System.Drawing.Point(8, 40);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.lvResults);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scTextBoxes);
            this.scMain.Size = new System.Drawing.Size(1040, 736);
            this.scMain.SplitterDistance = 367;
            this.scMain.SplitterWidth = 7;
            this.scMain.TabIndex = 7;
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFileCount.Location = new System.Drawing.Point(480, 12);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(99, 16);
            this.lblFileCount.TabIndex = 4;
            this.lblFileCount.Text = "Status: Waiting.";
            // 
            // btnFindRegionAreas
            // 
            this.btnFindRegionAreas.Location = new System.Drawing.Point(8, 8);
            this.btnFindRegionAreas.Name = "btnFindRegionAreas";
            this.btnFindRegionAreas.Size = new System.Drawing.Size(136, 24);
            this.btnFindRegionAreas.TabIndex = 0;
            this.btnFindRegionAreas.Text = "Search missing license";
            this.btnFindRegionAreas.UseVisualStyleBackColor = true;
            this.btnFindRegionAreas.Click += new System.EventHandler(this.btnFindRegionAreas_Click);
            // 
            // btnOrderLines
            // 
            this.btnOrderLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderLines.Location = new System.Drawing.Point(912, 8);
            this.btnOrderLines.Name = "btnOrderLines";
            this.btnOrderLines.Size = new System.Drawing.Size(136, 24);
            this.btnOrderLines.TabIndex = 5;
            this.btnOrderLines.Text = "Sort lines in clipboard";
            this.btnOrderLines.UseVisualStyleBackColor = true;
            this.btnOrderLines.Click += new System.EventHandler(this.btnOrderLines_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(400, 8);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(72, 24);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 785);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnOrderLines);
            this.Controls.Add(this.btnFindRegionAreas);
            this.Controls.Add(this.lblFileCount);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.btnAddLicenseAll);
            this.Controls.Add(this.btnAddLicense);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeWorks";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.scTextBoxes.Panel1.ResumeLayout(false);
            this.scTextBoxes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scTextBoxes)).EndInit();
            this.scTextBoxes.ResumeLayout(false);
            this.gbCurrentText.ResumeLayout(false);
            this.gbCurrentText.PerformLayout();
            this.gbNewText.ResumeLayout(false);
            this.gbNewText.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnAddLicense;
        private System.Windows.Forms.Button btnAddLicenseAll;
        private System.Windows.Forms.SplitContainer scTextBoxes;
        private System.Windows.Forms.GroupBox gbCurrentText;
        private System.Windows.Forms.TextBox tbDefaultText;
        private System.Windows.Forms.GroupBox gbNewText;
        private System.Windows.Forms.TextBox tbNewText;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.Button btnFindRegionAreas;
        private System.Windows.Forms.Button btnOrderLines;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnSettings;
    }
}

