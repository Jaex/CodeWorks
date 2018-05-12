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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpLicense = new System.Windows.Forms.TabPage();
            this.tpResX = new System.Windows.Forms.TabPage();
            this.txtResXOriginal = new System.Windows.Forms.TextBox();
            this.txtResXModified = new System.Windows.Forms.TextBox();
            this.txtResXResult = new System.Windows.Forms.TextBox();
            this.btnResXCompare = new System.Windows.Forms.Button();
            this.lblResXResult = new System.Windows.Forms.Label();
            this.lblResXOriginal = new System.Windows.Forms.Label();
            this.lblResXModified = new System.Windows.Forms.Label();
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
            this.tcMain.SuspendLayout();
            this.tpLicense.SuspendLayout();
            this.tpResX.SuspendLayout();
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
            this.lvResults.Size = new System.Drawing.Size(1032, 355);
            this.lvResults.TabIndex = 0;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            this.lvResults.SelectedIndexChanged += new System.EventHandler(this.lvResults_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 1028;
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
            this.scTextBoxes.Size = new System.Drawing.Size(1032, 350);
            this.scTextBoxes.SplitterDistance = 497;
            this.scTextBoxes.TabIndex = 6;
            // 
            // gbCurrentText
            // 
            this.gbCurrentText.Controls.Add(this.tbDefaultText);
            this.gbCurrentText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCurrentText.Location = new System.Drawing.Point(0, 0);
            this.gbCurrentText.Name = "gbCurrentText";
            this.gbCurrentText.Size = new System.Drawing.Size(497, 350);
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
            this.tbDefaultText.Size = new System.Drawing.Size(491, 331);
            this.tbDefaultText.TabIndex = 0;
            // 
            // gbNewText
            // 
            this.gbNewText.Controls.Add(this.btnCopyToClipboard);
            this.gbNewText.Controls.Add(this.tbNewText);
            this.gbNewText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNewText.Location = new System.Drawing.Point(0, 0);
            this.gbNewText.Name = "gbNewText";
            this.gbNewText.Size = new System.Drawing.Size(531, 350);
            this.gbNewText.TabIndex = 0;
            this.gbNewText.TabStop = false;
            this.gbNewText.Text = "New text";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyToClipboard.Location = new System.Drawing.Point(384, 312);
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
            this.tbNewText.Size = new System.Drawing.Size(525, 331);
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
            this.scMain.Size = new System.Drawing.Size(1032, 712);
            this.scMain.SplitterDistance = 355;
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
            this.btnOrderLines.Location = new System.Drawing.Point(904, 8);
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
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpLicense);
            this.tcMain.Controls.Add(this.tpResX);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1057, 785);
            this.tcMain.TabIndex = 8;
            // 
            // tpLicense
            // 
            this.tpLicense.Controls.Add(this.btnFindRegionAreas);
            this.tpLicense.Controls.Add(this.btnSettings);
            this.tpLicense.Controls.Add(this.btnAddLicense);
            this.tpLicense.Controls.Add(this.btnOrderLines);
            this.tpLicense.Controls.Add(this.btnAddLicenseAll);
            this.tpLicense.Controls.Add(this.scMain);
            this.tpLicense.Controls.Add(this.lblFileCount);
            this.tpLicense.Location = new System.Drawing.Point(4, 22);
            this.tpLicense.Name = "tpLicense";
            this.tpLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tpLicense.Size = new System.Drawing.Size(1049, 759);
            this.tpLicense.TabIndex = 0;
            this.tpLicense.Text = "License";
            this.tpLicense.UseVisualStyleBackColor = true;
            // 
            // tpResX
            // 
            this.tpResX.Controls.Add(this.lblResXModified);
            this.tpResX.Controls.Add(this.lblResXOriginal);
            this.tpResX.Controls.Add(this.lblResXResult);
            this.tpResX.Controls.Add(this.btnResXCompare);
            this.tpResX.Controls.Add(this.txtResXResult);
            this.tpResX.Controls.Add(this.txtResXModified);
            this.tpResX.Controls.Add(this.txtResXOriginal);
            this.tpResX.Location = new System.Drawing.Point(4, 22);
            this.tpResX.Name = "tpResX";
            this.tpResX.Padding = new System.Windows.Forms.Padding(3);
            this.tpResX.Size = new System.Drawing.Size(1049, 759);
            this.tpResX.TabIndex = 1;
            this.tpResX.Text = "ResX";
            this.tpResX.UseVisualStyleBackColor = true;
            // 
            // txtResXOriginal
            // 
            this.txtResXOriginal.Location = new System.Drawing.Point(8, 24);
            this.txtResXOriginal.MaxLength = 0;
            this.txtResXOriginal.Multiline = true;
            this.txtResXOriginal.Name = "txtResXOriginal";
            this.txtResXOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResXOriginal.Size = new System.Drawing.Size(488, 328);
            this.txtResXOriginal.TabIndex = 0;
            // 
            // txtResXModified
            // 
            this.txtResXModified.Location = new System.Drawing.Point(8, 384);
            this.txtResXModified.MaxLength = 0;
            this.txtResXModified.Multiline = true;
            this.txtResXModified.Name = "txtResXModified";
            this.txtResXModified.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResXModified.Size = new System.Drawing.Size(488, 328);
            this.txtResXModified.TabIndex = 1;
            // 
            // txtResXResult
            // 
            this.txtResXResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResXResult.Location = new System.Drawing.Point(504, 24);
            this.txtResXResult.MaxLength = 0;
            this.txtResXResult.Multiline = true;
            this.txtResXResult.Name = "txtResXResult";
            this.txtResXResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResXResult.Size = new System.Drawing.Size(536, 688);
            this.txtResXResult.TabIndex = 2;
            // 
            // btnResXCompare
            // 
            this.btnResXCompare.Location = new System.Drawing.Point(304, 720);
            this.btnResXCompare.Name = "btnResXCompare";
            this.btnResXCompare.Size = new System.Drawing.Size(192, 32);
            this.btnResXCompare.TabIndex = 3;
            this.btnResXCompare.Text = "Compare";
            this.btnResXCompare.UseVisualStyleBackColor = true;
            this.btnResXCompare.Click += new System.EventHandler(this.btnResXCompare_Click);
            // 
            // lblResXResult
            // 
            this.lblResXResult.AutoSize = true;
            this.lblResXResult.Location = new System.Drawing.Point(501, 8);
            this.lblResXResult.Name = "lblResXResult";
            this.lblResXResult.Size = new System.Drawing.Size(40, 13);
            this.lblResXResult.TabIndex = 4;
            this.lblResXResult.Text = "Result:";
            // 
            // lblResXOriginal
            // 
            this.lblResXOriginal.AutoSize = true;
            this.lblResXOriginal.Location = new System.Drawing.Point(5, 8);
            this.lblResXOriginal.Name = "lblResXOriginal";
            this.lblResXOriginal.Size = new System.Drawing.Size(42, 13);
            this.lblResXOriginal.TabIndex = 5;
            this.lblResXOriginal.Text = "Original";
            // 
            // lblResXModified
            // 
            this.lblResXModified.AutoSize = true;
            this.lblResXModified.Location = new System.Drawing.Point(5, 368);
            this.lblResXModified.Name = "lblResXModified";
            this.lblResXModified.Size = new System.Drawing.Size(50, 13);
            this.lblResXModified.TabIndex = 6;
            this.lblResXModified.Text = "Modified:";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 785);
            this.Controls.Add(this.tcMain);
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
            this.tcMain.ResumeLayout(false);
            this.tpLicense.ResumeLayout(false);
            this.tpLicense.PerformLayout();
            this.tpResX.ResumeLayout(false);
            this.tpResX.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpLicense;
        private System.Windows.Forms.TabPage tpResX;
        private System.Windows.Forms.TextBox txtResXModified;
        private System.Windows.Forms.TextBox txtResXOriginal;
        private System.Windows.Forms.Button btnResXCompare;
        private System.Windows.Forms.TextBox txtResXResult;
        private System.Windows.Forms.Label lblResXResult;
        private System.Windows.Forms.Label lblResXOriginal;
        private System.Windows.Forms.Label lblResXModified;
    }
}

