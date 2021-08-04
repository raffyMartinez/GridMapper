namespace GridMapper.views
{
    partial class Grid25LayoutHelperForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grid25LayoutHelperForm));
            this.txtRows = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.txtOverlap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApplyDimension = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPageHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPageWidth = new System.Windows.Forms.TextBox();
            this.tabsLayout = new System.Windows.Forms.TabControl();
            this.tabLayout = new System.Windows.Forms.TabPage();
            this.btnInputTitles = new System.Windows.Forms.Button();
            this.tabFishingGround = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textFishingGround = new System.Windows.Forms.TextBox();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.colVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGridSettings = new System.Windows.Forms.Button();
            this.btnLocateSourceFolder = new System.Windows.Forms.Button();
            this.lblProvideTitles = new System.Windows.Forms.Label();
            this.buttonSubGrid = new System.Windows.Forms.Button();
            this.tabSave = new System.Windows.Forms.TabPage();
            this.groupSaveTemplate = new System.Windows.Forms.GroupBox();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.textLayoutTemplateFileName = new System.Windows.Forms.TextBox();
            this.groupSaveGrids = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.textFolderToSave = new System.Windows.Forms.TextBox();
            this.btnSelectFolderSave = new System.Windows.Forms.Button();
            this.tabExport = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkLayout = new System.Windows.Forms.CheckBox();
            this.btnExportSettings = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.chkExportFrontAndReverse = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.txtFolderExportPath = new System.Windows.Forms.TextBox();
            this.btnFolderExportImage = new System.Windows.Forms.Button();
            this.menuDropDown = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chkAutoExpand = new System.Windows.Forms.CheckBox();
            this.lblLogoScaleFactor = new System.Windows.Forms.Label();
            this.txtLogoScaleFactor = new System.Windows.Forms.TextBox();
            this.tabsLayout.SuspendLayout();
            this.tabLayout.SuspendLayout();
            this.tabFishingGround.SuspendLayout();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.tabSave.SuspendLayout();
            this.groupSaveTemplate.SuspendLayout();
            this.groupSaveGrids.SuspendLayout();
            this.tabExport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(124, 85);
            this.txtRows.Margin = new System.Windows.Forms.Padding(4);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(95, 22);
            this.txtRows.TabIndex = 0;
            this.txtRows.Text = "1";
            this.txtRows.Validating += new System.ComponentModel.CancelEventHandler(this.OnTextValidating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rows";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columns";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(124, 117);
            this.txtColumns.Margin = new System.Windows.Forms.Padding(4);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(95, 22);
            this.txtColumns.TabIndex = 3;
            this.txtColumns.Text = "1";
            this.txtColumns.Validating += new System.ComponentModel.CancelEventHandler(this.OnTextValidating);
            // 
            // txtOverlap
            // 
            this.txtOverlap.Location = new System.Drawing.Point(124, 149);
            this.txtOverlap.Margin = new System.Windows.Forms.Padding(4);
            this.txtOverlap.Name = "txtOverlap";
            this.txtOverlap.Size = new System.Drawing.Size(95, 22);
            this.txtOverlap.TabIndex = 4;
            this.txtOverlap.Text = "0";
            this.txtOverlap.Validating += new System.ComponentModel.CancelEventHandler(this.OnTextValidating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Overlap";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnApplyDimension
            // 
            this.btnApplyDimension.ImageKey = "applyGrid";
            this.btnApplyDimension.ImageList = this.imageList1;
            this.btnApplyDimension.Location = new System.Drawing.Point(437, 315);
            this.btnApplyDimension.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyDimension.Name = "btnApplyDimension";
            this.btnApplyDimension.Size = new System.Drawing.Size(37, 34);
            this.btnApplyDimension.TabIndex = 6;
            this.btnApplyDimension.UseVisualStyleBackColor = true;
            this.btnApplyDimension.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "applyGrid");
            this.imageList1.Images.SetKeyName(1, "cancel");
            this.imageList1.Images.SetKeyName(2, "save");
            this.imageList1.Images.SetKeyName(3, "addToFolder");
            this.imageList1.Images.SetKeyName(4, "addLayout");
            this.imageList1.Images.SetKeyName(5, "openLayoutGrid");
            this.imageList1.Images.SetKeyName(6, "saveLayout");
            this.imageList1.Images.SetKeyName(7, "layoutTitles.bmp");
            this.imageList1.Images.SetKeyName(8, "subgrid");
            this.imageList1.Images.SetKeyName(9, "grid_layout");
            this.imageList1.Images.SetKeyName(10, "Folder_16x");
            this.imageList1.Images.SetKeyName(11, "settings");
            this.imageList1.Images.SetKeyName(12, "image");
            this.imageList1.Images.SetKeyName(13, "toolbox");
            this.imageList1.Images.SetKeyName(14, "list_16xMD.png");
            // 
            // btnCancel
            // 
            this.btnCancel.ImageKey = "cancel";
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(455, 436);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(37, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // txtPageHeight
            // 
            this.txtPageHeight.Location = new System.Drawing.Point(124, 53);
            this.txtPageHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtPageHeight.Name = "txtPageHeight";
            this.txtPageHeight.Size = new System.Drawing.Size(95, 22);
            this.txtPageHeight.TabIndex = 12;
            this.txtPageHeight.Text = "1";
            this.txtPageHeight.Validating += new System.ComponentModel.CancelEventHandler(this.OnTextValidating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Page height";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Page width";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPageWidth
            // 
            this.txtPageWidth.Location = new System.Drawing.Point(124, 21);
            this.txtPageWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtPageWidth.Name = "txtPageWidth";
            this.txtPageWidth.Size = new System.Drawing.Size(95, 22);
            this.txtPageWidth.TabIndex = 9;
            this.txtPageWidth.Text = "1";
            this.txtPageWidth.Validating += new System.ComponentModel.CancelEventHandler(this.OnTextValidating);
            // 
            // tabsLayout
            // 
            this.tabsLayout.Controls.Add(this.tabLayout);
            this.tabsLayout.Controls.Add(this.tabFishingGround);
            this.tabsLayout.Controls.Add(this.tabResults);
            this.tabsLayout.Controls.Add(this.tabSave);
            this.tabsLayout.Controls.Add(this.tabExport);
            this.tabsLayout.Location = new System.Drawing.Point(-3, 28);
            this.tabsLayout.Margin = new System.Windows.Forms.Padding(4);
            this.tabsLayout.Name = "tabsLayout";
            this.tabsLayout.SelectedIndex = 0;
            this.tabsLayout.Size = new System.Drawing.Size(507, 400);
            this.tabsLayout.TabIndex = 13;
            this.tabsLayout.SelectedIndexChanged += new System.EventHandler(this.OnTabsSelectionChanged);
            // 
            // tabLayout
            // 
            this.tabLayout.Controls.Add(this.btnInputTitles);
            this.tabLayout.Controls.Add(this.txtPageWidth);
            this.tabLayout.Controls.Add(this.label2);
            this.tabLayout.Controls.Add(this.btnApplyDimension);
            this.tabLayout.Controls.Add(this.txtPageHeight);
            this.tabLayout.Controls.Add(this.txtColumns);
            this.tabLayout.Controls.Add(this.label5);
            this.tabLayout.Controls.Add(this.txtRows);
            this.tabLayout.Controls.Add(this.txtOverlap);
            this.tabLayout.Controls.Add(this.label1);
            this.tabLayout.Controls.Add(this.label3);
            this.tabLayout.Controls.Add(this.label4);
            this.tabLayout.Location = new System.Drawing.Point(4, 25);
            this.tabLayout.Margin = new System.Windows.Forms.Padding(4);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.Padding = new System.Windows.Forms.Padding(4);
            this.tabLayout.Size = new System.Drawing.Size(499, 371);
            this.tabLayout.TabIndex = 0;
            this.tabLayout.Text = "Layout";
            this.tabLayout.UseVisualStyleBackColor = true;
            // 
            // btnInputTitles
            // 
            this.btnInputTitles.ImageKey = "layoutTitles.bmp";
            this.btnInputTitles.ImageList = this.imageList1;
            this.btnInputTitles.Location = new System.Drawing.Point(392, 315);
            this.btnInputTitles.Margin = new System.Windows.Forms.Padding(4);
            this.btnInputTitles.Name = "btnInputTitles";
            this.btnInputTitles.Size = new System.Drawing.Size(37, 34);
            this.btnInputTitles.TabIndex = 13;
            this.btnInputTitles.UseVisualStyleBackColor = true;
            this.btnInputTitles.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // tabFishingGround
            // 
            this.tabFishingGround.Controls.Add(this.label7);
            this.tabFishingGround.Controls.Add(this.textFishingGround);
            this.tabFishingGround.Location = new System.Drawing.Point(4, 25);
            this.tabFishingGround.Margin = new System.Windows.Forms.Padding(4);
            this.tabFishingGround.Name = "tabFishingGround";
            this.tabFishingGround.Padding = new System.Windows.Forms.Padding(4);
            this.tabFishingGround.Size = new System.Drawing.Size(499, 371);
            this.tabFishingGround.TabIndex = 1;
            this.tabFishingGround.Text = "Fishing ground";
            this.tabFishingGround.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fishing ground";
            // 
            // textFishingGround
            // 
            this.textFishingGround.Location = new System.Drawing.Point(32, 103);
            this.textFishingGround.Margin = new System.Windows.Forms.Padding(4);
            this.textFishingGround.Name = "textFishingGround";
            this.textFishingGround.Size = new System.Drawing.Size(439, 22);
            this.textFishingGround.TabIndex = 10;
            this.textFishingGround.Validating += new System.ComponentModel.CancelEventHandler(this.OnTextValidating);
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.dgResults);
            this.tabResults.Controls.Add(this.btnGridSettings);
            this.tabResults.Controls.Add(this.btnLocateSourceFolder);
            this.tabResults.Controls.Add(this.lblProvideTitles);
            this.tabResults.Controls.Add(this.buttonSubGrid);
            this.tabResults.Location = new System.Drawing.Point(4, 25);
            this.tabResults.Margin = new System.Windows.Forms.Padding(4);
            this.tabResults.Name = "tabResults";
            this.tabResults.Size = new System.Drawing.Size(499, 371);
            this.tabResults.TabIndex = 2;
            this.tabResults.Text = "Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // dgResults
            // 
            this.dgResults.AllowUserToAddRows = false;
            this.dgResults.AllowUserToDeleteRows = false;
            this.dgResults.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVisible,
            this.colTitle,
            this.colExport,
            this.colWidth,
            this.colHeight});
            this.dgResults.Location = new System.Drawing.Point(0, 4);
            this.dgResults.Margin = new System.Windows.Forms.Padding(4);
            this.dgResults.MultiSelect = false;
            this.dgResults.Name = "dgResults";
            this.dgResults.RowHeadersVisible = false;
            this.dgResults.RowHeadersWidth = 51;
            this.dgResults.Size = new System.Drawing.Size(412, 361);
            this.dgResults.TabIndex = 16;
            this.dgResults.Visible = false;
            this.dgResults.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OndgResultsCellMouseUp);
            // 
            // colVisible
            // 
            this.colVisible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colVisible.HeaderText = "Select";
            this.colVisible.MinimumWidth = 50;
            this.colVisible.Name = "colVisible";
            this.colVisible.Width = 53;
            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colTitle.HeaderText = "Map title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.Width = 90;
            // 
            // colExport
            // 
            this.colExport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colExport.HeaderText = "Export";
            this.colExport.MinimumWidth = 6;
            this.colExport.Name = "colExport";
            this.colExport.Width = 54;
            // 
            // colWidth
            // 
            this.colWidth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colWidth.HeaderText = "Width";
            this.colWidth.MinimumWidth = 6;
            this.colWidth.Name = "colWidth";
            this.colWidth.Width = 73;
            // 
            // colHeight
            // 
            this.colHeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colHeight.HeaderText = "Height";
            this.colHeight.MinimumWidth = 6;
            this.colHeight.Name = "colHeight";
            this.colHeight.Width = 78;
            // 
            // btnGridSettings
            // 
            this.btnGridSettings.Enabled = false;
            this.btnGridSettings.ImageKey = "settings";
            this.btnGridSettings.ImageList = this.imageList1;
            this.btnGridSettings.Location = new System.Drawing.Point(440, 103);
            this.btnGridSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnGridSettings.Name = "btnGridSettings";
            this.btnGridSettings.Size = new System.Drawing.Size(37, 34);
            this.btnGridSettings.TabIndex = 15;
            this.btnGridSettings.UseVisualStyleBackColor = true;
            this.btnGridSettings.Visible = false;
            this.btnGridSettings.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // btnLocateSourceFolder
            // 
            this.btnLocateSourceFolder.ImageKey = "Folder_16x";
            this.btnLocateSourceFolder.ImageList = this.imageList1;
            this.btnLocateSourceFolder.Location = new System.Drawing.Point(440, 62);
            this.btnLocateSourceFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocateSourceFolder.Name = "btnLocateSourceFolder";
            this.btnLocateSourceFolder.Size = new System.Drawing.Size(37, 34);
            this.btnLocateSourceFolder.TabIndex = 14;
            this.btnLocateSourceFolder.UseVisualStyleBackColor = true;
            this.btnLocateSourceFolder.Visible = false;
            this.btnLocateSourceFolder.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // lblProvideTitles
            // 
            this.lblProvideTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvideTitles.Location = new System.Drawing.Point(32, 124);
            this.lblProvideTitles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvideTitles.Name = "lblProvideTitles";
            this.lblProvideTitles.Size = new System.Drawing.Size(432, 63);
            this.lblProvideTitles.TabIndex = 13;
            this.lblProvideTitles.Text = "Provide titles for all panels in the layout and name of fishing ground";
            this.lblProvideTitles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSubGrid
            // 
            this.buttonSubGrid.ImageKey = "subgrid";
            this.buttonSubGrid.ImageList = this.imageList1;
            this.buttonSubGrid.Location = new System.Drawing.Point(440, 20);
            this.buttonSubGrid.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubGrid.Name = "buttonSubGrid";
            this.buttonSubGrid.Size = new System.Drawing.Size(37, 34);
            this.buttonSubGrid.TabIndex = 12;
            this.buttonSubGrid.UseVisualStyleBackColor = true;
            this.buttonSubGrid.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // tabSave
            // 
            this.tabSave.Controls.Add(this.groupSaveTemplate);
            this.tabSave.Controls.Add(this.groupSaveGrids);
            this.tabSave.Location = new System.Drawing.Point(4, 25);
            this.tabSave.Margin = new System.Windows.Forms.Padding(4);
            this.tabSave.Name = "tabSave";
            this.tabSave.Padding = new System.Windows.Forms.Padding(4);
            this.tabSave.Size = new System.Drawing.Size(499, 371);
            this.tabSave.TabIndex = 3;
            this.tabSave.Text = "Save";
            this.tabSave.UseVisualStyleBackColor = true;
            // 
            // groupSaveTemplate
            // 
            this.groupSaveTemplate.Controls.Add(this.btnSaveTemplate);
            this.groupSaveTemplate.Controls.Add(this.textLayoutTemplateFileName);
            this.groupSaveTemplate.Location = new System.Drawing.Point(23, 161);
            this.groupSaveTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.groupSaveTemplate.Name = "groupSaveTemplate";
            this.groupSaveTemplate.Padding = new System.Windows.Forms.Padding(4);
            this.groupSaveTemplate.Size = new System.Drawing.Size(444, 130);
            this.groupSaveTemplate.TabIndex = 17;
            this.groupSaveTemplate.TabStop = false;
            this.groupSaveTemplate.Text = "Save fishing ground layout template";
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.ImageKey = "save";
            this.btnSaveTemplate.ImageList = this.imageList1;
            this.btnSaveTemplate.Location = new System.Drawing.Point(393, 75);
            this.btnSaveTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(37, 34);
            this.btnSaveTemplate.TabIndex = 18;
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // textLayoutTemplateFileName
            // 
            this.textLayoutTemplateFileName.Enabled = false;
            this.textLayoutTemplateFileName.Location = new System.Drawing.Point(8, 32);
            this.textLayoutTemplateFileName.Margin = new System.Windows.Forms.Padding(4);
            this.textLayoutTemplateFileName.Name = "textLayoutTemplateFileName";
            this.textLayoutTemplateFileName.Size = new System.Drawing.Size(427, 22);
            this.textLayoutTemplateFileName.TabIndex = 13;
            // 
            // groupSaveGrids
            // 
            this.groupSaveGrids.Controls.Add(this.btnSave);
            this.groupSaveGrids.Controls.Add(this.textFolderToSave);
            this.groupSaveGrids.Controls.Add(this.btnSelectFolderSave);
            this.groupSaveGrids.Location = new System.Drawing.Point(23, 18);
            this.groupSaveGrids.Margin = new System.Windows.Forms.Padding(4);
            this.groupSaveGrids.Name = "groupSaveGrids";
            this.groupSaveGrids.Padding = new System.Windows.Forms.Padding(4);
            this.groupSaveGrids.Size = new System.Drawing.Size(444, 130);
            this.groupSaveGrids.TabIndex = 16;
            this.groupSaveGrids.TabStop = false;
            this.groupSaveGrids.Text = "Save all fishing ground grid maps";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.ImageKey = "save";
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(348, 76);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(37, 34);
            this.btnSave.TabIndex = 17;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // textFolderToSave
            // 
            this.textFolderToSave.Enabled = false;
            this.textFolderToSave.Location = new System.Drawing.Point(8, 36);
            this.textFolderToSave.Margin = new System.Windows.Forms.Padding(4);
            this.textFolderToSave.Name = "textFolderToSave";
            this.textFolderToSave.Size = new System.Drawing.Size(427, 22);
            this.textFolderToSave.TabIndex = 12;
            // 
            // btnSelectFolderSave
            // 
            this.btnSelectFolderSave.ImageKey = "addToFolder";
            this.btnSelectFolderSave.ImageList = this.imageList1;
            this.btnSelectFolderSave.Location = new System.Drawing.Point(393, 76);
            this.btnSelectFolderSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFolderSave.Name = "btnSelectFolderSave";
            this.btnSelectFolderSave.Size = new System.Drawing.Size(37, 34);
            this.btnSelectFolderSave.TabIndex = 11;
            this.btnSelectFolderSave.UseVisualStyleBackColor = true;
            this.btnSelectFolderSave.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // tabExport
            // 
            this.tabExport.Controls.Add(this.groupBox1);
            this.tabExport.Location = new System.Drawing.Point(4, 25);
            this.tabExport.Margin = new System.Windows.Forms.Padding(4);
            this.tabExport.Name = "tabExport";
            this.tabExport.Padding = new System.Windows.Forms.Padding(4);
            this.tabExport.Size = new System.Drawing.Size(499, 371);
            this.tabExport.TabIndex = 4;
            this.tabExport.Text = "Export grid maps";
            this.tabExport.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtFolderExportPath);
            this.groupBox1.Controls.Add(this.btnFolderExportImage);
            this.groupBox1.Location = new System.Drawing.Point(4, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 351);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Folder to save exported maps";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLogoScaleFactor);
            this.groupBox2.Controls.Add(this.txtLogoScaleFactor);
            this.groupBox2.Controls.Add(this.chkLayout);
            this.groupBox2.Controls.Add(this.btnExportSettings);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.chkExportFrontAndReverse);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDPI);
            this.groupBox2.Location = new System.Drawing.Point(13, 113);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(416, 214);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export and export options";
            // 
            // chkLayout
            // 
            this.chkLayout.AutoSize = true;
            this.chkLayout.Location = new System.Drawing.Point(20, 98);
            this.chkLayout.Name = "chkLayout";
            this.chkLayout.Size = new System.Drawing.Size(73, 21);
            this.chkLayout.TabIndex = 24;
            this.chkLayout.Text = "Layout";
            this.chkLayout.UseVisualStyleBackColor = true;
            this.chkLayout.CheckedChanged += new System.EventHandler(this.OnLayoutCheckChanged);
            // 
            // btnExportSettings
            // 
            this.btnExportSettings.Enabled = false;
            this.btnExportSettings.ImageKey = "toolbox";
            this.btnExportSettings.ImageList = this.imageList1;
            this.btnExportSettings.Location = new System.Drawing.Point(304, 167);
            this.btnExportSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportSettings.Name = "btnExportSettings";
            this.btnExportSettings.Size = new System.Drawing.Size(37, 34);
            this.btnExportSettings.TabIndex = 23;
            this.btnExportSettings.UseVisualStyleBackColor = true;
            this.btnExportSettings.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.ImageKey = "image";
            this.btnExport.ImageList = this.imageList1;
            this.btnExport.Location = new System.Drawing.Point(349, 167);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(37, 34);
            this.btnExport.TabIndex = 17;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // chkExportFrontAndReverse
            // 
            this.chkExportFrontAndReverse.AutoSize = true;
            this.chkExportFrontAndReverse.Checked = true;
            this.chkExportFrontAndReverse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExportFrontAndReverse.Location = new System.Drawing.Point(20, 37);
            this.chkExportFrontAndReverse.Margin = new System.Windows.Forms.Padding(4);
            this.chkExportFrontAndReverse.Name = "chkExportFrontAndReverse";
            this.chkExportFrontAndReverse.Size = new System.Drawing.Size(245, 21);
            this.chkExportFrontAndReverse.TabIndex = 20;
            this.chkExportFrontAndReverse.Text = "Export front and back map images";
            this.chkExportFrontAndReverse.UseVisualStyleBackColor = true;
            this.chkExportFrontAndReverse.CheckedChanged += new System.EventHandler(this.OnCheckChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Resolution of exported maps";
            // 
            // txtDPI
            // 
            this.txtDPI.Location = new System.Drawing.Point(210, 65);
            this.txtDPI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(63, 22);
            this.txtDPI.TabIndex = 21;
            this.txtDPI.Text = "150";
            this.txtDPI.Validating += new System.ComponentModel.CancelEventHandler(this.OnTextValidating);
            // 
            // txtFolderExportPath
            // 
            this.txtFolderExportPath.Enabled = false;
            this.txtFolderExportPath.Location = new System.Drawing.Point(8, 46);
            this.txtFolderExportPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolderExportPath.Name = "txtFolderExportPath";
            this.txtFolderExportPath.Size = new System.Drawing.Size(417, 22);
            this.txtFolderExportPath.TabIndex = 12;
            // 
            // btnFolderExportImage
            // 
            this.btnFolderExportImage.ImageKey = "addToFolder";
            this.btnFolderExportImage.ImageList = this.imageList1;
            this.btnFolderExportImage.Location = new System.Drawing.Point(435, 39);
            this.btnFolderExportImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnFolderExportImage.Name = "btnFolderExportImage";
            this.btnFolderExportImage.Size = new System.Drawing.Size(37, 34);
            this.btnFolderExportImage.TabIndex = 11;
            this.btnFolderExportImage.UseVisualStyleBackColor = true;
            this.btnFolderExportImage.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // menuDropDown
            // 
            this.menuDropDown.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuDropDown.Name = "menuDropDown";
            this.menuDropDown.Size = new System.Drawing.Size(61, 4);
            this.menuDropDown.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnDropDownItemClicked);
            // 
            // chkAutoExpand
            // 
            this.chkAutoExpand.AutoSize = true;
            this.chkAutoExpand.Location = new System.Drawing.Point(15, 442);
            this.chkAutoExpand.Margin = new System.Windows.Forms.Padding(4);
            this.chkAutoExpand.Name = "chkAutoExpand";
            this.chkAutoExpand.Size = new System.Drawing.Size(167, 21);
            this.chkAutoExpand.TabIndex = 14;
            this.chkAutoExpand.Text = "Auto-expand selected";
            this.chkAutoExpand.UseVisualStyleBackColor = true;
            // 
            // lblLogoScaleFactor
            // 
            this.lblLogoScaleFactor.AutoSize = true;
            this.lblLogoScaleFactor.Location = new System.Drawing.Point(16, 130);
            this.lblLogoScaleFactor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogoScaleFactor.Name = "lblLogoScaleFactor";
            this.lblLogoScaleFactor.Size = new System.Drawing.Size(117, 17);
            this.lblLogoScaleFactor.TabIndex = 26;
            this.lblLogoScaleFactor.Text = "Logo scale factor";
            // 
            // txtLogoScaleFactor
            // 
            this.txtLogoScaleFactor.Location = new System.Drawing.Point(210, 126);
            this.txtLogoScaleFactor.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogoScaleFactor.Name = "txtLogoScaleFactor";
            this.txtLogoScaleFactor.Size = new System.Drawing.Size(63, 22);
            this.txtLogoScaleFactor.TabIndex = 25;
            this.txtLogoScaleFactor.Text = "150";
            // 
            // Grid25LayoutHelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 478);
            this.Controls.Add(this.chkAutoExpand);
            this.Controls.Add(this.tabsLayout);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Grid25LayoutHelperForm";
            this.Text = "Layout grids";
            this.Activated += new System.EventHandler(this.OnFormActivated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.tabsLayout.ResumeLayout(false);
            this.tabLayout.ResumeLayout(false);
            this.tabLayout.PerformLayout();
            this.tabFishingGround.ResumeLayout(false);
            this.tabFishingGround.PerformLayout();
            this.tabResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.tabSave.ResumeLayout(false);
            this.groupSaveTemplate.ResumeLayout(false);
            this.groupSaveTemplate.PerformLayout();
            this.groupSaveGrids.ResumeLayout(false);
            this.groupSaveGrids.PerformLayout();
            this.tabExport.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.TextBox txtOverlap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApplyDimension;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPageHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPageWidth;
        private System.Windows.Forms.TabControl tabsLayout;
        private System.Windows.Forms.TabPage tabLayout;
        private System.Windows.Forms.TabPage tabFishingGround;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textFishingGround;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.CheckBox chkAutoExpand;
        private System.Windows.Forms.ContextMenuStrip menuDropDown;
        private System.Windows.Forms.Button btnInputTitles;
        private System.Windows.Forms.Button buttonSubGrid;
        private System.Windows.Forms.TabPage tabSave;
        private System.Windows.Forms.GroupBox groupSaveGrids;
        private System.Windows.Forms.TextBox textFolderToSave;
        private System.Windows.Forms.Button btnSelectFolderSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupSaveTemplate;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.TextBox textLayoutTemplateFileName;
        private System.Windows.Forms.Label lblProvideTitles;
        private System.Windows.Forms.Button btnLocateSourceFolder;
        private System.Windows.Forms.Button btnGridSettings;
        private System.Windows.Forms.TabPage tabExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtFolderExportPath;
        private System.Windows.Forms.Button btnFolderExportImage;
        private System.Windows.Forms.CheckBox chkExportFrontAndReverse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExportSettings;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colVisible;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeight;
        private System.Windows.Forms.CheckBox chkLayout;
        private System.Windows.Forms.Label lblLogoScaleFactor;
        private System.Windows.Forms.TextBox txtLogoScaleFactor;
    }
}