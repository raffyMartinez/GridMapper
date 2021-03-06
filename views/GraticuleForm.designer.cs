namespace GridMapper.views
{
    partial class GraticuleForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabsGraticule = new System.Windows.Forms.TabControl();
            this.tabConfigureGrid = new System.Windows.Forms.TabPage();
            this.txtTitleSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMapTitle = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkBottom = new System.Windows.Forms.CheckBox();
            this.chkRight = new System.Windows.Forms.CheckBox();
            this.chkTop = new System.Windows.Forms.CheckBox();
            this.chkLeft = new System.Windows.Forms.CheckBox();
            this.chkShowGrid = new System.Windows.Forms.CheckBox();
            this.txtGridlineWidth = new System.Windows.Forms.TextBox();
            this.txtBordeWidth = new System.Windows.Forms.TextBox();
            this.txtNumberOfGridlines = new System.Windows.Forms.TextBox();
            this.txtLabelSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabConfigureText = new System.Windows.Forms.TabPage();
            this.lnkNote = new System.Windows.Forms.LinkLabel();
            this.lnkTitle = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTitle = new System.Windows.Forms.CheckBox();
            this.chkNote = new System.Windows.Forms.CheckBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMapScale = new System.Windows.Forms.TextBox();
            this.tabsGraticule.SuspendLayout();
            this.tabConfigureGrid.SuspendLayout();
            this.tabConfigureText.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(307, 562);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(53, 28);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(256, 562);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(47, 28);
            this.btnApply.TabIndex = 18;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(186, 562);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 28);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // tabsGraticule
            // 
            this.tabsGraticule.Controls.Add(this.tabConfigureGrid);
            this.tabsGraticule.Controls.Add(this.tabConfigureText);
            this.tabsGraticule.Location = new System.Drawing.Point(7, 22);
            this.tabsGraticule.Name = "tabsGraticule";
            this.tabsGraticule.SelectedIndex = 0;
            this.tabsGraticule.Size = new System.Drawing.Size(352, 518);
            this.tabsGraticule.TabIndex = 21;
            this.tabsGraticule.SelectedIndexChanged += new System.EventHandler(this.OnTabsIndexChanged);
            // 
            // tabConfigureGrid
            // 
            this.tabConfigureGrid.Controls.Add(this.txtMapScale);
            this.tabConfigureGrid.Controls.Add(this.label8);
            this.tabConfigureGrid.Controls.Add(this.txtTitleSize);
            this.tabConfigureGrid.Controls.Add(this.label7);
            this.tabConfigureGrid.Controls.Add(this.label6);
            this.tabConfigureGrid.Controls.Add(this.txtMapTitle);
            this.tabConfigureGrid.Controls.Add(this.btnRemove);
            this.tabConfigureGrid.Controls.Add(this.label5);
            this.tabConfigureGrid.Controls.Add(this.txtName);
            this.tabConfigureGrid.Controls.Add(this.chkBold);
            this.tabConfigureGrid.Controls.Add(this.chkBottom);
            this.tabConfigureGrid.Controls.Add(this.chkRight);
            this.tabConfigureGrid.Controls.Add(this.chkTop);
            this.tabConfigureGrid.Controls.Add(this.chkLeft);
            this.tabConfigureGrid.Controls.Add(this.chkShowGrid);
            this.tabConfigureGrid.Controls.Add(this.txtGridlineWidth);
            this.tabConfigureGrid.Controls.Add(this.txtBordeWidth);
            this.tabConfigureGrid.Controls.Add(this.txtNumberOfGridlines);
            this.tabConfigureGrid.Controls.Add(this.txtLabelSize);
            this.tabConfigureGrid.Controls.Add(this.label4);
            this.tabConfigureGrid.Controls.Add(this.label3);
            this.tabConfigureGrid.Controls.Add(this.label2);
            this.tabConfigureGrid.Controls.Add(this.label1);
            this.tabConfigureGrid.Location = new System.Drawing.Point(4, 27);
            this.tabConfigureGrid.Name = "tabConfigureGrid";
            this.tabConfigureGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfigureGrid.Size = new System.Drawing.Size(344, 487);
            this.tabConfigureGrid.TabIndex = 0;
            this.tabConfigureGrid.Text = "Graticule";
            this.tabConfigureGrid.UseVisualStyleBackColor = true;
            // 
            // txtTitleSize
            // 
            this.txtTitleSize.Location = new System.Drawing.Point(178, 190);
            this.txtTitleSize.Name = "txtTitleSize";
            this.txtTitleSize.Size = new System.Drawing.Size(59, 24);
            this.txtTitleSize.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 36;
            this.label7.Text = "Size of map title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Map title";
            // 
            // txtMapTitle
            // 
            this.txtMapTitle.Location = new System.Drawing.Point(20, 79);
            this.txtMapTitle.Name = "txtMapTitle";
            this.txtMapTitle.Size = new System.Drawing.Size(292, 24);
            this.txtMapTitle.TabIndex = 34;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(86, 425);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(166, 35);
            this.btnRemove.TabIndex = 33;
            this.btnRemove.Text = "Remove graticule";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Name of graticule";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(21, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(292, 24);
            this.txtName.TabIndex = 31;
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(238, 358);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(102, 22);
            this.chkBold.TabIndex = 30;
            this.chkBold.Text = "Bold labels";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // chkBottom
            // 
            this.chkBottom.AutoSize = true;
            this.chkBottom.Location = new System.Drawing.Point(238, 385);
            this.chkBottom.Name = "chkBottom";
            this.chkBottom.Size = new System.Drawing.Size(79, 22);
            this.chkBottom.TabIndex = 29;
            this.chkBottom.Text = "Bottom";
            this.chkBottom.UseVisualStyleBackColor = true;
            // 
            // chkRight
            // 
            this.chkRight.AutoSize = true;
            this.chkRight.Location = new System.Drawing.Point(167, 385);
            this.chkRight.Name = "chkRight";
            this.chkRight.Size = new System.Drawing.Size(64, 22);
            this.chkRight.TabIndex = 28;
            this.chkRight.Text = "Right";
            this.chkRight.UseVisualStyleBackColor = true;
            // 
            // chkTop
            // 
            this.chkTop.AutoSize = true;
            this.chkTop.Location = new System.Drawing.Point(100, 385);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(56, 22);
            this.chkTop.TabIndex = 27;
            this.chkTop.Text = "Top";
            this.chkTop.UseVisualStyleBackColor = true;
            // 
            // chkLeft
            // 
            this.chkLeft.AutoSize = true;
            this.chkLeft.Location = new System.Drawing.Point(33, 385);
            this.chkLeft.Name = "chkLeft";
            this.chkLeft.Size = new System.Drawing.Size(54, 22);
            this.chkLeft.TabIndex = 26;
            this.chkLeft.Text = "Left";
            this.chkLeft.UseVisualStyleBackColor = true;
            // 
            // chkShowGrid
            // 
            this.chkShowGrid.AutoSize = true;
            this.chkShowGrid.Location = new System.Drawing.Point(33, 358);
            this.chkShowGrid.Name = "chkShowGrid";
            this.chkShowGrid.Size = new System.Drawing.Size(96, 22);
            this.chkShowGrid.TabIndex = 25;
            this.chkShowGrid.Text = "Show grid";
            this.chkShowGrid.UseVisualStyleBackColor = true;
            // 
            // txtGridlineWidth
            // 
            this.txtGridlineWidth.Location = new System.Drawing.Point(178, 322);
            this.txtGridlineWidth.Name = "txtGridlineWidth";
            this.txtGridlineWidth.Size = new System.Drawing.Size(59, 24);
            this.txtGridlineWidth.TabIndex = 24;
            // 
            // txtBordeWidth
            // 
            this.txtBordeWidth.Location = new System.Drawing.Point(178, 288);
            this.txtBordeWidth.Name = "txtBordeWidth";
            this.txtBordeWidth.Size = new System.Drawing.Size(59, 24);
            this.txtBordeWidth.TabIndex = 23;
            // 
            // txtNumberOfGridlines
            // 
            this.txtNumberOfGridlines.Location = new System.Drawing.Point(178, 255);
            this.txtNumberOfGridlines.Name = "txtNumberOfGridlines";
            this.txtNumberOfGridlines.Size = new System.Drawing.Size(59, 24);
            this.txtNumberOfGridlines.TabIndex = 22;
            // 
            // txtLabelSize
            // 
            this.txtLabelSize.Location = new System.Drawing.Point(178, 222);
            this.txtLabelSize.Name = "txtLabelSize";
            this.txtLabelSize.Size = new System.Drawing.Size(59, 24);
            this.txtLabelSize.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Border width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Gridline width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Number of gridlines";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Size of coordinate labels";
            // 
            // tabConfigureText
            // 
            this.tabConfigureText.Controls.Add(this.lnkNote);
            this.tabConfigureText.Controls.Add(this.lnkTitle);
            this.tabConfigureText.Controls.Add(this.groupBox1);
            this.tabConfigureText.Controls.Add(this.picPreview);
            this.tabConfigureText.Location = new System.Drawing.Point(4, 27);
            this.tabConfigureText.Name = "tabConfigureText";
            this.tabConfigureText.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfigureText.Size = new System.Drawing.Size(344, 438);
            this.tabConfigureText.TabIndex = 1;
            this.tabConfigureText.Text = "Labels";
            this.tabConfigureText.UseVisualStyleBackColor = true;
            // 
            // lnkNote
            // 
            this.lnkNote.AutoSize = true;
            this.lnkNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkNote.Location = new System.Drawing.Point(118, 365);
            this.lnkNote.Name = "lnkNote";
            this.lnkNote.Size = new System.Drawing.Size(132, 17);
            this.lnkNote.TabIndex = 9;
            this.lnkNote.TabStop = true;
            this.lnkNote.Text = "Configure map note";
            this.lnkNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkNote.Visible = false;
            this.lnkNote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClick);
            // 
            // lnkTitle
            // 
            this.lnkTitle.AutoSize = true;
            this.lnkTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTitle.Location = new System.Drawing.Point(89, 16);
            this.lnkTitle.Name = "lnkTitle";
            this.lnkTitle.Size = new System.Drawing.Size(185, 24);
            this.lnkTitle.TabIndex = 8;
            this.lnkTitle.TabStop = true;
            this.lnkTitle.Text = "Configure map title";
            this.lnkTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkTitle.Visible = false;
            this.lnkTitle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTitle);
            this.groupBox1.Controls.Add(this.chkNote);
            this.groupBox1.Location = new System.Drawing.Point(85, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elements";
            // 
            // chkTitle
            // 
            this.chkTitle.AutoSize = true;
            this.chkTitle.Enabled = false;
            this.chkTitle.Location = new System.Drawing.Point(26, 21);
            this.chkTitle.Name = "chkTitle";
            this.chkTitle.Size = new System.Drawing.Size(57, 22);
            this.chkTitle.TabIndex = 3;
            this.chkTitle.Text = "Title";
            this.chkTitle.UseVisualStyleBackColor = true;
            this.chkTitle.CheckedChanged += new System.EventHandler(this.OnCheckChange);
            // 
            // chkNote
            // 
            this.chkNote.AutoSize = true;
            this.chkNote.Enabled = false;
            this.chkNote.Location = new System.Drawing.Point(97, 21);
            this.chkNote.Name = "chkNote";
            this.chkNote.Size = new System.Drawing.Size(62, 22);
            this.chkNote.TabIndex = 4;
            this.chkNote.Text = "Note";
            this.chkNote.UseVisualStyleBackColor = true;
            this.chkNote.CheckedChanged += new System.EventHandler(this.OnCheckChange);
            // 
            // picPreview
            // 
            this.picPreview.Image = global::GridMapper.Properties.Resources.mapPreview;
            this.picPreview.Location = new System.Drawing.Point(21, 45);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(307, 310);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 5;
            this.picPreview.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Scale";
            // 
            // txtMapScale
            // 
            this.txtMapScale.Location = new System.Drawing.Point(20, 135);
            this.txtMapScale.Name = "txtMapScale";
            this.txtMapScale.Size = new System.Drawing.Size(147, 24);
            this.txtMapScale.TabIndex = 39;
            // 
            // GraticuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 599);
            this.Controls.Add(this.tabsGraticule);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GraticuleForm";
            this.ShowInTaskbar = false;
            this.Text = "Graticule";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraticuleForm_FormClosed);
            this.Load += new System.EventHandler(this.OnGraticuleForm_Load);
            this.tabsGraticule.ResumeLayout(false);
            this.tabConfigureGrid.ResumeLayout(false);
            this.tabConfigureGrid.PerformLayout();
            this.tabConfigureText.ResumeLayout(false);
            this.tabConfigureText.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabsGraticule;
        private System.Windows.Forms.TabPage tabConfigureGrid;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkBottom;
        private System.Windows.Forms.CheckBox chkRight;
        private System.Windows.Forms.CheckBox chkTop;
        private System.Windows.Forms.CheckBox chkLeft;
        private System.Windows.Forms.CheckBox chkShowGrid;
        private System.Windows.Forms.TextBox txtGridlineWidth;
        private System.Windows.Forms.TextBox txtBordeWidth;
        private System.Windows.Forms.TextBox txtNumberOfGridlines;
        private System.Windows.Forms.TextBox txtLabelSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabConfigureText;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.CheckBox chkNote;
        private System.Windows.Forms.CheckBox chkTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkNote;
        private System.Windows.Forms.LinkLabel lnkTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMapTitle;
        private System.Windows.Forms.TextBox txtTitleSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMapScale;
        private System.Windows.Forms.Label label8;
    }
}