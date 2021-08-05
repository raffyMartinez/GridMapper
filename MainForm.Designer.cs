
namespace GridMapper
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.lblGridStatus = new System.Windows.Forms.Label();
            this.buttonSubGrid = new System.Windows.Forms.Button();
            this.imList = new System.Windows.Forms.ImageList(this.components);
            this.groupLabels = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkIncludeCredits = new System.Windows.Forms.CheckBox();
            this.txtTitleDistance = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFootnoteSize = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSubGridThickness = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLabelsFromKML = new System.Windows.Forms.Button();
            this.buttonLabel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkWrapLabels = new System.Windows.Forms.CheckBox();
            this.chkBottom = new System.Windows.Forms.CheckBox();
            this.chkRight = new System.Windows.Forms.CheckBox();
            this.chkTop = new System.Windows.Forms.CheckBox();
            this.chkLeft = new System.Windows.Forms.CheckBox();
            this.txtMinorGridThickness = new System.Windows.Forms.TextBox();
            this.txtMajorGridThickness = new System.Windows.Forms.TextBox();
            this.txtBorderThickness = new System.Windows.Forms.TextBox();
            this.txtMajorGridLabelSize = new System.Windows.Forms.TextBox();
            this.txtMinorGridLabelSize = new System.Windows.Forms.TextBox();
            this.txtMinorGridLabelDistance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.shapeSubGridLineColor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeMinorGridLineColor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeMajorGridLineColor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeBorderColor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeMajorGridLabelColor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeMinorGridLabelColor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.buttonOpenLayoutGrid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLocateGrid = new System.Windows.Forms.Button();
            this.txtMapTitle = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonGrid = new System.Windows.Forms.Button();
            this.mapControl = new AxMapWinGIS.AxMap();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.toolStripGridUI = new ToolStripExtensions.ToolStripEx();
            this.tsButtonFitMap = new System.Windows.Forms.ToolStripButton();
            this.tsButtonSaveShapefile = new System.Windows.Forms.ToolStripButton();
            this.tsButtonSaveImage = new System.Windows.Forms.ToolStripButton();
            this.tsButtonMBRs = new System.Windows.Forms.ToolStripButton();
            this.tsButtonRetrieve = new System.Windows.Forms.ToolStripButton();
            this.tsButtonXY = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain = new ToolStripExtensions.ToolStripEx();
            this.tsButtonSaveState = new System.Windows.Forms.ToolStripDropDownButton();
            this.resetMapStateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapStateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsButtonLayers = new System.Windows.Forms.ToolStripButton();
            this.tsButtonLayerAdd = new System.Windows.Forms.ToolStripButton();
            this.tsButtonAttributes = new System.Windows.Forms.ToolStripButton();
            this.tsButtonSelectTile = new System.Windows.Forms.ToolStripDropDownButton();
            this.noTileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsButtonZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tsButtonZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tsButtonZoomAll = new System.Windows.Forms.ToolStripButton();
            this.tsButtonFitMap1 = new System.Windows.Forms.ToolStripButton();
            this.tsButtonZoomPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsButtonPan = new System.Windows.Forms.ToolStripButton();
            this.tsButtonBlackArrow = new System.Windows.Forms.ToolStripButton();
            this.tsButtonMeasure = new System.Windows.Forms.ToolStripButton();
            this.tsButtonClearSelection = new System.Windows.Forms.ToolStripButton();
            this.tsButtonClearAllSelection = new System.Windows.Forms.ToolStripButton();
            this.tsButtonGraticule = new System.Windows.Forms.ToolStripButton();
            this.tsButtonSaveImage1 = new System.Windows.Forms.ToolStripButton();
            this.tsCBO = new System.Windows.Forms.ToolStripComboBox();
            this.tsButtonCloseMap = new System.Windows.Forms.ToolStripButton();
            this.tsButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            this.groupLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.toolStripGridUI.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 778);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1272, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Margin = new System.Windows.Forms.Padding(4);
            this.splitter.Name = "splitter";
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.toolStripGridUI);
            this.splitter.Panel1.Controls.Add(this.lblGridStatus);
            this.splitter.Panel1.Controls.Add(this.buttonSubGrid);
            this.splitter.Panel1.Controls.Add(this.groupLabels);
            this.splitter.Panel1.Controls.Add(this.buttonOpenLayoutGrid);
            this.splitter.Panel1.Controls.Add(this.label1);
            this.splitter.Panel1.Controls.Add(this.buttonLocateGrid);
            this.splitter.Panel1.Controls.Add(this.txtMapTitle);
            this.splitter.Panel1.Controls.Add(this.buttonClear);
            this.splitter.Panel1.Controls.Add(this.buttonGrid);
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.mapControl);
            this.splitter.Panel2.Controls.Add(this.toolStripMain);
            this.splitter.Size = new System.Drawing.Size(1272, 778);
            this.splitter.SplitterDistance = 476;
            this.splitter.SplitterWidth = 5;
            this.splitter.TabIndex = 2;
            // 
            // lblGridStatus
            // 
            this.lblGridStatus.Location = new System.Drawing.Point(6, 700);
            this.lblGridStatus.Name = "lblGridStatus";
            this.lblGridStatus.Size = new System.Drawing.Size(326, 68);
            this.lblGridStatus.TabIndex = 17;
            this.lblGridStatus.Text = "Grid status:";
            // 
            // buttonSubGrid
            // 
            this.buttonSubGrid.ImageIndex = 5;
            this.buttonSubGrid.ImageList = this.imList;
            this.buttonSubGrid.Location = new System.Drawing.Point(352, 298);
            this.buttonSubGrid.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubGrid.Name = "buttonSubGrid";
            this.buttonSubGrid.Size = new System.Drawing.Size(37, 34);
            this.buttonSubGrid.TabIndex = 16;
            this.buttonSubGrid.UseVisualStyleBackColor = true;
            this.buttonSubGrid.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // imList
            // 
            this.imList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imList.ImageStream")));
            this.imList.TransparentColor = System.Drawing.Color.White;
            this.imList.Images.SetKeyName(0, "gridCursor");
            this.imList.Images.SetKeyName(1, "im_clear.bmp");
            this.imList.Images.SetKeyName(2, "gridLayout");
            this.imList.Images.SetKeyName(3, "import layout.png");
            this.imList.Images.SetKeyName(4, "apply format.bmp");
            this.imList.Images.SetKeyName(5, "subgrid.bmp");
            // 
            // groupLabels
            // 
            this.groupLabels.Controls.Add(this.label17);
            this.groupLabels.Controls.Add(this.chkIncludeCredits);
            this.groupLabels.Controls.Add(this.txtTitleDistance);
            this.groupLabels.Controls.Add(this.label16);
            this.groupLabels.Controls.Add(this.txtFootnoteSize);
            this.groupLabels.Controls.Add(this.label15);
            this.groupLabels.Controls.Add(this.label13);
            this.groupLabels.Controls.Add(this.txtSubGridThickness);
            this.groupLabels.Controls.Add(this.label14);
            this.groupLabels.Controls.Add(this.btnLabelsFromKML);
            this.groupLabels.Controls.Add(this.buttonLabel);
            this.groupLabels.Controls.Add(this.label12);
            this.groupLabels.Controls.Add(this.label11);
            this.groupLabels.Controls.Add(this.label10);
            this.groupLabels.Controls.Add(this.label9);
            this.groupLabels.Controls.Add(this.label8);
            this.groupLabels.Controls.Add(this.chkBold);
            this.groupLabels.Controls.Add(this.chkWrapLabels);
            this.groupLabels.Controls.Add(this.chkBottom);
            this.groupLabels.Controls.Add(this.chkRight);
            this.groupLabels.Controls.Add(this.chkTop);
            this.groupLabels.Controls.Add(this.chkLeft);
            this.groupLabels.Controls.Add(this.txtMinorGridThickness);
            this.groupLabels.Controls.Add(this.txtMajorGridThickness);
            this.groupLabels.Controls.Add(this.txtBorderThickness);
            this.groupLabels.Controls.Add(this.txtMajorGridLabelSize);
            this.groupLabels.Controls.Add(this.txtMinorGridLabelSize);
            this.groupLabels.Controls.Add(this.txtMinorGridLabelDistance);
            this.groupLabels.Controls.Add(this.label7);
            this.groupLabels.Controls.Add(this.label6);
            this.groupLabels.Controls.Add(this.label5);
            this.groupLabels.Controls.Add(this.label4);
            this.groupLabels.Controls.Add(this.label3);
            this.groupLabels.Controls.Add(this.label2);
            this.groupLabels.Controls.Add(this.shapeContainer1);
            this.groupLabels.Location = new System.Drawing.Point(9, 94);
            this.groupLabels.Margin = new System.Windows.Forms.Padding(4);
            this.groupLabels.Name = "groupLabels";
            this.groupLabels.Padding = new System.Windows.Forms.Padding(4);
            this.groupLabels.Size = new System.Drawing.Size(327, 602);
            this.groupLabels.TabIndex = 5;
            this.groupLabels.TabStop = false;
            this.groupLabels.Text = "Labels";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(4, 532);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 43);
            this.label17.TabIndex = 36;
            this.label17.Text = "Include credit and citation";
            // 
            // chkIncludeCredits
            // 
            this.chkIncludeCredits.AutoSize = true;
            this.chkIncludeCredits.Location = new System.Drawing.Point(109, 535);
            this.chkIncludeCredits.Name = "chkIncludeCredits";
            this.chkIncludeCredits.Size = new System.Drawing.Size(18, 17);
            this.chkIncludeCredits.TabIndex = 35;
            this.chkIncludeCredits.UseVisualStyleBackColor = true;
            // 
            // txtTitleDistance
            // 
            this.txtTitleDistance.Location = new System.Drawing.Point(109, 495);
            this.txtTitleDistance.Margin = new System.Windows.Forms.Padding(5);
            this.txtTitleDistance.Name = "txtTitleDistance";
            this.txtTitleDistance.Size = new System.Drawing.Size(65, 22);
            this.txtTitleDistance.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(7, 489);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 43);
            this.label16.TabIndex = 33;
            this.label16.Text = "Title distance factor";
            // 
            // txtFootnoteSize
            // 
            this.txtFootnoteSize.Location = new System.Drawing.Point(109, 452);
            this.txtFootnoteSize.Margin = new System.Windows.Forms.Padding(5);
            this.txtFootnoteSize.Name = "txtFootnoteSize";
            this.txtFootnoteSize.Size = new System.Drawing.Size(65, 22);
            this.txtFootnoteSize.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(7, 453);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 37);
            this.label15.TabIndex = 31;
            this.label15.Text = "Footnote size";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(192, 399);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 46);
            this.label13.TabIndex = 30;
            this.label13.Text = "Line color";
            // 
            // txtSubGridThickness
            // 
            this.txtSubGridThickness.Location = new System.Drawing.Point(109, 404);
            this.txtSubGridThickness.Margin = new System.Windows.Forms.Padding(5);
            this.txtSubGridThickness.Name = "txtSubGridThickness";
            this.txtSubGridThickness.Size = new System.Drawing.Size(65, 22);
            this.txtSubGridThickness.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(7, 398);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 37);
            this.label14.TabIndex = 28;
            this.label14.Text = "Subgrid thickness";
            // 
            // btnLabelsFromKML
            // 
            this.btnLabelsFromKML.ImageKey = "label_add";
            this.btnLabelsFromKML.Location = new System.Drawing.Point(225, 558);
            this.btnLabelsFromKML.Margin = new System.Windows.Forms.Padding(4);
            this.btnLabelsFromKML.Name = "btnLabelsFromKML";
            this.btnLabelsFromKML.Size = new System.Drawing.Size(37, 34);
            this.btnLabelsFromKML.TabIndex = 27;
            this.btnLabelsFromKML.UseVisualStyleBackColor = true;
            this.btnLabelsFromKML.Visible = false;
            // 
            // buttonLabel
            // 
            this.buttonLabel.ImageIndex = 4;
            this.buttonLabel.ImageList = this.imList;
            this.buttonLabel.Location = new System.Drawing.Point(268, 558);
            this.buttonLabel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLabel.Name = "buttonLabel";
            this.buttonLabel.Size = new System.Drawing.Size(37, 34);
            this.buttonLabel.TabIndex = 26;
            this.buttonLabel.UseVisualStyleBackColor = true;
            this.buttonLabel.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(195, 351);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 46);
            this.label12.TabIndex = 24;
            this.label12.Text = "Line color";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(193, 300);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 46);
            this.label11.TabIndex = 23;
            this.label11.Text = "Line color";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(193, 249);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 46);
            this.label10.TabIndex = 22;
            this.label10.Text = "Border color";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(193, 198);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 46);
            this.label9.TabIndex = 21;
            this.label9.Text = "Label color";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(193, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 46);
            this.label8.TabIndex = 20;
            this.label8.Text = "Label color";
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(229, 25);
            this.chkBold.Margin = new System.Windows.Forms.Padding(4);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(58, 21);
            this.chkBold.TabIndex = 19;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // chkWrapLabels
            // 
            this.chkWrapLabels.AutoSize = true;
            this.chkWrapLabels.Location = new System.Drawing.Point(13, 25);
            this.chkWrapLabels.Margin = new System.Windows.Forms.Padding(4);
            this.chkWrapLabels.Name = "chkWrapLabels";
            this.chkWrapLabels.Size = new System.Drawing.Size(105, 21);
            this.chkWrapLabels.TabIndex = 18;
            this.chkWrapLabels.Text = "Wrap labels";
            this.chkWrapLabels.UseVisualStyleBackColor = true;
            // 
            // chkBottom
            // 
            this.chkBottom.AutoSize = true;
            this.chkBottom.Location = new System.Drawing.Point(229, 55);
            this.chkBottom.Margin = new System.Windows.Forms.Padding(4);
            this.chkBottom.Name = "chkBottom";
            this.chkBottom.Size = new System.Drawing.Size(74, 21);
            this.chkBottom.TabIndex = 17;
            this.chkBottom.Text = "Bottom";
            this.chkBottom.UseVisualStyleBackColor = true;
            // 
            // chkRight
            // 
            this.chkRight.AutoSize = true;
            this.chkRight.Location = new System.Drawing.Point(151, 55);
            this.chkRight.Margin = new System.Windows.Forms.Padding(4);
            this.chkRight.Name = "chkRight";
            this.chkRight.Size = new System.Drawing.Size(63, 21);
            this.chkRight.TabIndex = 16;
            this.chkRight.Text = "Right";
            this.chkRight.UseVisualStyleBackColor = true;
            // 
            // chkTop
            // 
            this.chkTop.AutoSize = true;
            this.chkTop.Location = new System.Drawing.Point(80, 55);
            this.chkTop.Margin = new System.Windows.Forms.Padding(4);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(55, 21);
            this.chkTop.TabIndex = 15;
            this.chkTop.Text = "Top";
            this.chkTop.UseVisualStyleBackColor = true;
            // 
            // chkLeft
            // 
            this.chkLeft.AutoSize = true;
            this.chkLeft.Location = new System.Drawing.Point(13, 55);
            this.chkLeft.Margin = new System.Windows.Forms.Padding(4);
            this.chkLeft.Name = "chkLeft";
            this.chkLeft.Size = new System.Drawing.Size(54, 21);
            this.chkLeft.TabIndex = 14;
            this.chkLeft.Text = "Left";
            this.chkLeft.UseVisualStyleBackColor = true;
            // 
            // txtMinorGridThickness
            // 
            this.txtMinorGridThickness.Location = new System.Drawing.Point(112, 356);
            this.txtMinorGridThickness.Margin = new System.Windows.Forms.Padding(5);
            this.txtMinorGridThickness.Name = "txtMinorGridThickness";
            this.txtMinorGridThickness.Size = new System.Drawing.Size(65, 22);
            this.txtMinorGridThickness.TabIndex = 13;
            // 
            // txtMajorGridThickness
            // 
            this.txtMajorGridThickness.Location = new System.Drawing.Point(111, 305);
            this.txtMajorGridThickness.Margin = new System.Windows.Forms.Padding(5);
            this.txtMajorGridThickness.Name = "txtMajorGridThickness";
            this.txtMajorGridThickness.Size = new System.Drawing.Size(65, 22);
            this.txtMajorGridThickness.TabIndex = 12;
            // 
            // txtBorderThickness
            // 
            this.txtBorderThickness.Location = new System.Drawing.Point(112, 254);
            this.txtBorderThickness.Margin = new System.Windows.Forms.Padding(5);
            this.txtBorderThickness.Name = "txtBorderThickness";
            this.txtBorderThickness.Size = new System.Drawing.Size(65, 22);
            this.txtBorderThickness.TabIndex = 11;
            // 
            // txtMajorGridLabelSize
            // 
            this.txtMajorGridLabelSize.Location = new System.Drawing.Point(111, 203);
            this.txtMajorGridLabelSize.Margin = new System.Windows.Forms.Padding(5);
            this.txtMajorGridLabelSize.Name = "txtMajorGridLabelSize";
            this.txtMajorGridLabelSize.Size = new System.Drawing.Size(65, 22);
            this.txtMajorGridLabelSize.TabIndex = 10;
            // 
            // txtMinorGridLabelSize
            // 
            this.txtMinorGridLabelSize.Location = new System.Drawing.Point(111, 153);
            this.txtMinorGridLabelSize.Margin = new System.Windows.Forms.Padding(5);
            this.txtMinorGridLabelSize.Name = "txtMinorGridLabelSize";
            this.txtMinorGridLabelSize.Size = new System.Drawing.Size(65, 22);
            this.txtMinorGridLabelSize.TabIndex = 9;
            // 
            // txtMinorGridLabelDistance
            // 
            this.txtMinorGridLabelDistance.Location = new System.Drawing.Point(112, 101);
            this.txtMinorGridLabelDistance.Margin = new System.Windows.Forms.Padding(5);
            this.txtMinorGridLabelDistance.Name = "txtMinorGridLabelDistance";
            this.txtMinorGridLabelDistance.Size = new System.Drawing.Size(65, 22);
            this.txtMinorGridLabelDistance.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 350);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Minor grid thickness";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "Major grid thickness";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Border thickness";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Major grid label size";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Minor grid label size";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Label distance";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(4, 19);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.shapeSubGridLineColor,
            this.shapeMinorGridLineColor,
            this.shapeMajorGridLineColor,
            this.shapeBorderColor,
            this.shapeMajorGridLabelColor,
            this.shapeMinorGridLabelColor});
            this.shapeContainer1.Size = new System.Drawing.Size(319, 579);
            this.shapeContainer1.TabIndex = 25;
            this.shapeContainer1.TabStop = false;
            // 
            // shapeSubGridLineColor
            // 
            this.shapeSubGridLineColor.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.shapeSubGridLineColor.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shapeSubGridLineColor.Location = new System.Drawing.Point(197, 314);
            this.shapeSubGridLineColor.Name = "shapeSubGridLineColor";
            this.shapeSubGridLineColor.Size = new System.Drawing.Size(23, 18);
            this.shapeSubGridLineColor.DoubleClick += new System.EventHandler(this.OnShapeColor_DoubleClick);
            // 
            // shapeMinorGridLineColor
            // 
            this.shapeMinorGridLineColor.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shapeMinorGridLineColor.Location = new System.Drawing.Point(197, 277);
            this.shapeMinorGridLineColor.Name = "shapeMinorGridLineColor";
            this.shapeMinorGridLineColor.Size = new System.Drawing.Size(23, 18);
            this.shapeMinorGridLineColor.DoubleClick += new System.EventHandler(this.OnShapeColor_DoubleClick);
            // 
            // shapeMajorGridLineColor
            // 
            this.shapeMajorGridLineColor.FillColor = System.Drawing.Color.Red;
            this.shapeMajorGridLineColor.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shapeMajorGridLineColor.Location = new System.Drawing.Point(197, 236);
            this.shapeMajorGridLineColor.Name = "shapeMajorGridLineColor";
            this.shapeMajorGridLineColor.Size = new System.Drawing.Size(23, 18);
            this.shapeMajorGridLineColor.DoubleClick += new System.EventHandler(this.OnShapeColor_DoubleClick);
            // 
            // shapeBorderColor
            // 
            this.shapeBorderColor.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shapeBorderColor.Location = new System.Drawing.Point(197, 193);
            this.shapeBorderColor.Name = "shapeBorderColor";
            this.shapeBorderColor.Size = new System.Drawing.Size(23, 18);
            this.shapeBorderColor.DoubleClick += new System.EventHandler(this.OnShapeColor_DoubleClick);
            // 
            // shapeMajorGridLabelColor
            // 
            this.shapeMajorGridLabelColor.FillColor = System.Drawing.Color.Red;
            this.shapeMajorGridLabelColor.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shapeMajorGridLabelColor.Location = new System.Drawing.Point(197, 149);
            this.shapeMajorGridLabelColor.Name = "shapeMajorGridLabelColor";
            this.shapeMajorGridLabelColor.Size = new System.Drawing.Size(23, 18);
            this.shapeMajorGridLabelColor.DoubleClick += new System.EventHandler(this.OnShapeColor_DoubleClick);
            // 
            // shapeMinorGridLabelColor
            // 
            this.shapeMinorGridLabelColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shapeMinorGridLabelColor.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.shapeMinorGridLabelColor.Location = new System.Drawing.Point(197, 108);
            this.shapeMinorGridLabelColor.Name = "shapeMinorGridLabelColor";
            this.shapeMinorGridLabelColor.Size = new System.Drawing.Size(23, 18);
            this.shapeMinorGridLabelColor.DoubleClick += new System.EventHandler(this.OnShapeColor_DoubleClick);
            // 
            // buttonOpenLayoutGrid
            // 
            this.buttonOpenLayoutGrid.ImageIndex = 3;
            this.buttonOpenLayoutGrid.ImageList = this.imList;
            this.buttonOpenLayoutGrid.Location = new System.Drawing.Point(349, 231);
            this.buttonOpenLayoutGrid.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenLayoutGrid.Name = "buttonOpenLayoutGrid";
            this.buttonOpenLayoutGrid.Size = new System.Drawing.Size(37, 34);
            this.buttonOpenLayoutGrid.TabIndex = 15;
            this.buttonOpenLayoutGrid.UseVisualStyleBackColor = true;
            this.buttonOpenLayoutGrid.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Map title";
            // 
            // buttonLocateGrid
            // 
            this.buttonLocateGrid.ImageIndex = 2;
            this.buttonLocateGrid.ImageList = this.imList;
            this.buttonLocateGrid.Location = new System.Drawing.Point(349, 193);
            this.buttonLocateGrid.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLocateGrid.Name = "buttonLocateGrid";
            this.buttonLocateGrid.Size = new System.Drawing.Size(37, 34);
            this.buttonLocateGrid.TabIndex = 14;
            this.buttonLocateGrid.UseVisualStyleBackColor = true;
            this.buttonLocateGrid.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // txtMapTitle
            // 
            this.txtMapTitle.Location = new System.Drawing.Point(5, 60);
            this.txtMapTitle.Margin = new System.Windows.Forms.Padding(5);
            this.txtMapTitle.Name = "txtMapTitle";
            this.txtMapTitle.Size = new System.Drawing.Size(243, 22);
            this.txtMapTitle.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.ImageIndex = 1;
            this.buttonClear.ImageList = this.imList;
            this.buttonClear.Location = new System.Drawing.Point(349, 142);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(37, 34);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // buttonGrid
            // 
            this.buttonGrid.ImageIndex = 0;
            this.buttonGrid.ImageList = this.imList;
            this.buttonGrid.Location = new System.Drawing.Point(349, 105);
            this.buttonGrid.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGrid.Name = "buttonGrid";
            this.buttonGrid.Size = new System.Drawing.Size(37, 34);
            this.buttonGrid.TabIndex = 12;
            this.buttonGrid.UseVisualStyleBackColor = true;
            this.buttonGrid.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // mapControl
            // 
            this.mapControl.Enabled = true;
            this.mapControl.Location = new System.Drawing.Point(0, 28);
            this.mapControl.Name = "mapControl";
            this.mapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mapControl.OcxState")));
            this.mapControl.Size = new System.Drawing.Size(526, 412);
            this.mapControl.TabIndex = 2;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // toolStripGridUI
            // 
            this.toolStripGridUI.ClickThrough = false;
            this.toolStripGridUI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripGridUI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonFitMap,
            this.tsButtonSaveShapefile,
            this.tsButtonSaveImage,
            this.tsButtonMBRs,
            this.tsButtonRetrieve,
            this.tsButtonXY});
            this.toolStripGridUI.Location = new System.Drawing.Point(0, 0);
            this.toolStripGridUI.Name = "toolStripGridUI";
            this.toolStripGridUI.Size = new System.Drawing.Size(476, 31);
            this.toolStripGridUI.SuppressHighlighting = true;
            this.toolStripGridUI.TabIndex = 18;
            this.toolStripGridUI.Text = "toolStripEx2";
            this.toolStripGridUI.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnTSButtonClicked);
            // 
            // tsButtonFitMap
            // 
            this.tsButtonFitMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonFitMap.Image = global::GridMapper.Properties.Resources.fit;
            this.tsButtonFitMap.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonFitMap.Name = "tsButtonFitMap";
            this.tsButtonFitMap.Size = new System.Drawing.Size(29, 28);
            this.tsButtonFitMap.Text = "Fit grid to map";
            // 
            // tsButtonSaveShapefile
            // 
            this.tsButtonSaveShapefile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonSaveShapefile.Image = global::GridMapper.Properties.Resources.document_save;
            this.tsButtonSaveShapefile.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonSaveShapefile.Name = "tsButtonSaveShapefile";
            this.tsButtonSaveShapefile.Size = new System.Drawing.Size(29, 28);
            this.tsButtonSaveShapefile.Text = "Save grid to shapefile";
            // 
            // tsButtonSaveImage
            // 
            this.tsButtonSaveImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonSaveImage.Image = global::GridMapper.Properties.Resources.image;
            this.tsButtonSaveImage.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonSaveImage.Name = "tsButtonSaveImage";
            this.tsButtonSaveImage.Size = new System.Drawing.Size(29, 28);
            this.tsButtonSaveImage.Text = "Save grid to image";
            // 
            // tsButtonMBRs
            // 
            this.tsButtonMBRs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonMBRs.Image = global::GridMapper.Properties.Resources.mbr;
            this.tsButtonMBRs.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonMBRs.Name = "tsButtonMBRs";
            this.tsButtonMBRs.Size = new System.Drawing.Size(29, 28);
            this.tsButtonMBRs.Text = "Show MBRs";
            // 
            // tsButtonRetrieve
            // 
            this.tsButtonRetrieve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonRetrieve.Image = global::GridMapper.Properties.Resources.im_boundary;
            this.tsButtonRetrieve.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonRetrieve.Name = "tsButtonRetrieve";
            this.tsButtonRetrieve.Size = new System.Drawing.Size(29, 28);
            this.tsButtonRetrieve.Text = "Get grid boundaries";
            // 
            // tsButtonXY
            // 
            this.tsButtonXY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonXY.Image = global::GridMapper.Properties.Resources.xy_point;
            this.tsButtonXY.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonXY.Name = "tsButtonXY";
            this.tsButtonXY.Size = new System.Drawing.Size(29, 28);
            this.tsButtonXY.Text = "Capture pointer x,y";
            // 
            // toolStripMain
            // 
            this.toolStripMain.ClickThrough = false;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonSaveState,
            this.tsButtonLayers,
            this.tsButtonLayerAdd,
            this.tsButtonAttributes,
            this.tsButtonSelectTile,
            this.tsButtonZoomIn,
            this.tsButtonZoomOut,
            this.tsButtonZoomAll,
            this.tsButtonFitMap1,
            this.tsButtonZoomPrevious,
            this.tsButtonPan,
            this.tsButtonBlackArrow,
            this.tsButtonMeasure,
            this.tsButtonClearSelection,
            this.tsButtonClearAllSelection,
            this.tsButtonGraticule,
            this.tsButtonSaveImage1,
            this.tsCBO,
            this.toolStripSeparator1,
            this.tsButtonAbout,
            this.tsButtonCloseMap});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(791, 31);
            this.toolStripMain.SuppressHighlighting = true;
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStripEx1";
            this.toolStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnTSButtonClicked);
            // 
            // tsButtonSaveState
            // 
            this.tsButtonSaveState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonSaveState.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetMapStateMenuItem,
            this.saveMapStateMenuItem});
            this.tsButtonSaveState.Image = global::GridMapper.Properties.Resources.document_save;
            this.tsButtonSaveState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonSaveState.Name = "tsButtonSaveState";
            this.tsButtonSaveState.Size = new System.Drawing.Size(34, 25);
            this.tsButtonSaveState.Text = "toolStripDropDownButton1";
            this.tsButtonSaveState.ToolTipText = "Save map state";
            // 
            // resetMapStateMenuItem
            // 
            this.resetMapStateMenuItem.Name = "resetMapStateMenuItem";
            this.resetMapStateMenuItem.Size = new System.Drawing.Size(128, 26);
            this.resetMapStateMenuItem.Text = "Reset";
            this.resetMapStateMenuItem.Click += new System.EventHandler(this.OnMenuItemSelected);
            // 
            // saveMapStateMenuItem
            // 
            this.saveMapStateMenuItem.Name = "saveMapStateMenuItem";
            this.saveMapStateMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveMapStateMenuItem.Text = "Save";
            this.saveMapStateMenuItem.Click += new System.EventHandler(this.OnMenuItemSelected);
            // 
            // tsButtonLayers
            // 
            this.tsButtonLayers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonLayers.Image = global::GridMapper.Properties.Resources.layer;
            this.tsButtonLayers.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonLayers.Name = "tsButtonLayers";
            this.tsButtonLayers.Size = new System.Drawing.Size(29, 25);
            this.tsButtonLayers.Text = "toolStripButton1";
            this.tsButtonLayers.ToolTipText = "Open layers form";
            // 
            // tsButtonLayerAdd
            // 
            this.tsButtonLayerAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonLayerAdd.Image = global::GridMapper.Properties.Resources.layerAdd;
            this.tsButtonLayerAdd.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonLayerAdd.Name = "tsButtonLayerAdd";
            this.tsButtonLayerAdd.Size = new System.Drawing.Size(29, 25);
            this.tsButtonLayerAdd.Text = "toolStripButton1";
            this.tsButtonLayerAdd.ToolTipText = "Add layer";
            // 
            // tsButtonAttributes
            // 
            this.tsButtonAttributes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonAttributes.Image = global::GridMapper.Properties.Resources.attrib;
            this.tsButtonAttributes.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonAttributes.Name = "tsButtonAttributes";
            this.tsButtonAttributes.Size = new System.Drawing.Size(29, 25);
            this.tsButtonAttributes.Text = "Open layer attributes";
            // 
            // tsButtonSelectTile
            // 
            this.tsButtonSelectTile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonSelectTile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noTileMenuItem,
            this.selectTileMenuItem});
            this.tsButtonSelectTile.Image = global::GridMapper.Properties.Resources._2Rows2Columns_16x;
            this.tsButtonSelectTile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonSelectTile.Name = "tsButtonSelectTile";
            this.tsButtonSelectTile.Size = new System.Drawing.Size(34, 25);
            this.tsButtonSelectTile.Text = "Select map tiles";
            // 
            // noTileMenuItem
            // 
            this.noTileMenuItem.Name = "noTileMenuItem";
            this.noTileMenuItem.Size = new System.Drawing.Size(143, 26);
            this.noTileMenuItem.Text = "No tiles";
            this.noTileMenuItem.Click += new System.EventHandler(this.OnMenuItemSelected);
            // 
            // selectTileMenuItem
            // 
            this.selectTileMenuItem.Name = "selectTileMenuItem";
            this.selectTileMenuItem.Size = new System.Drawing.Size(143, 26);
            this.selectTileMenuItem.Text = "Select...";
            this.selectTileMenuItem.Click += new System.EventHandler(this.OnMenuItemSelected);
            // 
            // tsButtonZoomIn
            // 
            this.tsButtonZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonZoomIn.Image = global::GridMapper.Properties.Resources.zoom_plus;
            this.tsButtonZoomIn.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonZoomIn.Name = "tsButtonZoomIn";
            this.tsButtonZoomIn.Size = new System.Drawing.Size(29, 25);
            this.tsButtonZoomIn.Text = "Zoom in";
            // 
            // tsButtonZoomOut
            // 
            this.tsButtonZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonZoomOut.Image = global::GridMapper.Properties.Resources.zoom_minus;
            this.tsButtonZoomOut.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonZoomOut.Name = "tsButtonZoomOut";
            this.tsButtonZoomOut.Size = new System.Drawing.Size(29, 25);
            this.tsButtonZoomOut.Text = "Zoom out";
            // 
            // tsButtonZoomAll
            // 
            this.tsButtonZoomAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonZoomAll.Image = global::GridMapper.Properties.Resources.zoomEntire;
            this.tsButtonZoomAll.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonZoomAll.Name = "tsButtonZoomAll";
            this.tsButtonZoomAll.Size = new System.Drawing.Size(29, 25);
            this.tsButtonZoomAll.Text = "Zoom all";
            // 
            // tsButtonFitMap1
            // 
            this.tsButtonFitMap1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonFitMap1.Image = global::GridMapper.Properties.Resources.fitScreen;
            this.tsButtonFitMap1.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonFitMap1.Name = "tsButtonFitMap1";
            this.tsButtonFitMap1.Size = new System.Drawing.Size(29, 25);
            this.tsButtonFitMap1.Text = "Fit to map";
            // 
            // tsButtonZoomPrevious
            // 
            this.tsButtonZoomPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonZoomPrevious.Image = global::GridMapper.Properties.Resources.imZoomPrev;
            this.tsButtonZoomPrevious.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonZoomPrevious.Name = "tsButtonZoomPrevious";
            this.tsButtonZoomPrevious.Size = new System.Drawing.Size(29, 25);
            this.tsButtonZoomPrevious.Text = "Zoom previous";
            // 
            // tsButtonPan
            // 
            this.tsButtonPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonPan.Image = global::GridMapper.Properties.Resources.pan;
            this.tsButtonPan.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonPan.Name = "tsButtonPan";
            this.tsButtonPan.Size = new System.Drawing.Size(29, 25);
            this.tsButtonPan.Text = "Pan";
            // 
            // tsButtonBlackArrow
            // 
            this.tsButtonBlackArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonBlackArrow.Image = global::GridMapper.Properties.Resources.arrow;
            this.tsButtonBlackArrow.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonBlackArrow.Name = "tsButtonBlackArrow";
            this.tsButtonBlackArrow.Size = new System.Drawing.Size(29, 25);
            this.tsButtonBlackArrow.Text = "Select";
            // 
            // tsButtonMeasure
            // 
            this.tsButtonMeasure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonMeasure.Image = global::GridMapper.Properties.Resources.ruler;
            this.tsButtonMeasure.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonMeasure.Name = "tsButtonMeasure";
            this.tsButtonMeasure.Size = new System.Drawing.Size(29, 25);
            this.tsButtonMeasure.Text = "Measure";
            // 
            // tsButtonClearSelection
            // 
            this.tsButtonClearSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonClearSelection.Image = global::GridMapper.Properties.Resources.clear_selection;
            this.tsButtonClearSelection.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonClearSelection.Name = "tsButtonClearSelection";
            this.tsButtonClearSelection.Size = new System.Drawing.Size(29, 25);
            this.tsButtonClearSelection.Text = "Deselect from current layer";
            // 
            // tsButtonClearAllSelection
            // 
            this.tsButtonClearAllSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonClearAllSelection.Image = global::GridMapper.Properties.Resources.clear_all_selection;
            this.tsButtonClearAllSelection.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonClearAllSelection.Name = "tsButtonClearAllSelection";
            this.tsButtonClearAllSelection.Size = new System.Drawing.Size(29, 25);
            this.tsButtonClearAllSelection.Text = "Deselect from all layers";
            // 
            // tsButtonGraticule
            // 
            this.tsButtonGraticule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonGraticule.Image = global::GridMapper.Properties.Resources.graticule;
            this.tsButtonGraticule.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonGraticule.Name = "tsButtonGraticule";
            this.tsButtonGraticule.Size = new System.Drawing.Size(29, 25);
            this.tsButtonGraticule.Text = "Graticule";
            // 
            // tsButtonSaveImage1
            // 
            this.tsButtonSaveImage1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonSaveImage1.Image = global::GridMapper.Properties.Resources.image;
            this.tsButtonSaveImage1.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonSaveImage1.Name = "tsButtonSaveImage1";
            this.tsButtonSaveImage1.Size = new System.Drawing.Size(29, 25);
            this.tsButtonSaveImage1.Text = "Save map to image";
            // 
            // tsCBO
            // 
            this.tsCBO.DropDownWidth = 140;
            this.tsCBO.Items.AddRange(new object[] {
            "WGS84",
            "Grid UTM Zone 50",
            "Grid UTM Zone 51"});
            this.tsCBO.Name = "tsCBO";
            this.tsCBO.Size = new System.Drawing.Size(140, 28);
            this.tsCBO.Text = "Mapping mode";
            this.tsCBO.SelectedIndexChanged += new System.EventHandler(this.OnCBOChange);
            // 
            // tsButtonCloseMap
            // 
            this.tsButtonCloseMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonCloseMap.Image = global::GridMapper.Properties.Resources.im_exit;
            this.tsButtonCloseMap.ImageTransparentColor = System.Drawing.Color.White;
            this.tsButtonCloseMap.Name = "tsButtonCloseMap";
            this.tsButtonCloseMap.Size = new System.Drawing.Size(29, 25);
            this.tsButtonCloseMap.Text = "Exit";
            // 
            // tsButtonAbout
            // 
            this.tsButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButtonAbout.Image = global::GridMapper.Properties.Resources.help_browser;
            this.tsButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonAbout.Name = "tsButtonAbout";
            this.tsButtonAbout.Size = new System.Drawing.Size(29, 28);
            this.tsButtonAbout.Text = "About this application";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 800);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "GridMapper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel1.PerformLayout();
            this.splitter.Panel2.ResumeLayout(false);
            this.splitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            this.groupLabels.ResumeLayout(false);
            this.groupLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.toolStripGridUI.ResumeLayout(false);
            this.toolStripGridUI.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMapTitle;
        private System.Windows.Forms.GroupBox groupLabels;
        private System.Windows.Forms.TextBox txtTitleDistance;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFootnoteSize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSubGridThickness;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLabelsFromKML;
        private System.Windows.Forms.Button buttonLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkWrapLabels;
        private System.Windows.Forms.CheckBox chkBottom;
        private System.Windows.Forms.CheckBox chkRight;
        private System.Windows.Forms.CheckBox chkTop;
        private System.Windows.Forms.CheckBox chkLeft;
        private System.Windows.Forms.TextBox txtMinorGridThickness;
        private System.Windows.Forms.TextBox txtMajorGridThickness;
        private System.Windows.Forms.TextBox txtBorderThickness;
        private System.Windows.Forms.TextBox txtMajorGridLabelSize;
        private System.Windows.Forms.TextBox txtMinorGridLabelSize;
        private System.Windows.Forms.TextBox txtMinorGridLabelDistance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shapeSubGridLineColor;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shapeMinorGridLineColor;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shapeMajorGridLineColor;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shapeBorderColor;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shapeMajorGridLabelColor;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape shapeMinorGridLabelColor;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button buttonSubGrid;
        private System.Windows.Forms.Button buttonOpenLayoutGrid;
        private System.Windows.Forms.Button buttonLocateGrid;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonGrid;
        private System.Windows.Forms.ImageList imList;
        private System.Windows.Forms.Label lblGridStatus;
        private ToolStripExtensions.ToolStripEx toolStripGridUI;
        private System.Windows.Forms.ToolStripButton tsButtonFitMap;
        private System.Windows.Forms.ToolStripButton tsButtonSaveShapefile;
        private System.Windows.Forms.ToolStripButton tsButtonSaveImage;
        private System.Windows.Forms.ToolStripButton tsButtonMBRs;
        private System.Windows.Forms.ToolStripButton tsButtonRetrieve;
        private System.Windows.Forms.ToolStripButton tsButtonXY;
        private ToolStripExtensions.ToolStripEx toolStripMain;
        private System.Windows.Forms.ToolStripButton tsButtonLayers;
        private System.Windows.Forms.ToolStripButton tsButtonLayerAdd;
        private System.Windows.Forms.ToolStripButton tsButtonAttributes;
        private System.Windows.Forms.ToolStripButton tsButtonZoomIn;
        private System.Windows.Forms.ToolStripButton tsButtonZoomOut;
        private System.Windows.Forms.ToolStripButton tsButtonZoomAll;
        private System.Windows.Forms.ToolStripButton tsButtonFitMap1;
        private System.Windows.Forms.ToolStripButton tsButtonZoomPrevious;
        private System.Windows.Forms.ToolStripButton tsButtonPan;
        private System.Windows.Forms.ToolStripButton tsButtonBlackArrow;
        private System.Windows.Forms.ToolStripButton tsButtonMeasure;
        private System.Windows.Forms.ToolStripButton tsButtonClearSelection;
        private System.Windows.Forms.ToolStripButton tsButtonClearAllSelection;
        private System.Windows.Forms.ToolStripButton tsButtonGraticule;
        private System.Windows.Forms.ToolStripButton tsButtonSaveImage1;
        private System.Windows.Forms.ToolStripButton tsButtonCloseMap;
        private AxMapWinGIS.AxMap mapControl;
        private System.Windows.Forms.ToolStripComboBox tsCBO;
        private System.Windows.Forms.ToolStripDropDownButton tsButtonSelectTile;
        private System.Windows.Forms.ToolStripMenuItem noTileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectTileMenuItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkIncludeCredits;
        private System.Windows.Forms.ToolStripDropDownButton tsButtonSaveState;
        private System.Windows.Forms.ToolStripMenuItem resetMapStateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMapStateMenuItem;
        private System.Windows.Forms.ToolStripButton tsButtonAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

