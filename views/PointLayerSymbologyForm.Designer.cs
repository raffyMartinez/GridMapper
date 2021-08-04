
namespace GridMapper.views
{
    partial class PointLayerSymbologyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.udRotation = new MWLite.Symbology.Controls.NumericUpDownExt(this.components);
            this.udSize = new MWLite.Symbology.Controls.NumericUpDownExt(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transpFillColor = new GridMapper.views.UserControls.TransparencyControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkFillVisible = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkOutlineVisible = new System.Windows.Forms.CheckBox();
            this.comboLineWidth = new GridMapper.views.UserControls.ImageCombo();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabPointSymbol = new System.Windows.Forms.TabPage();
            this.comboPointType = new GridMapper.views.UserControls.ImageCombo();
            this.symbolControl1 = new GridMapper.views.UserControls.SymbolControl();
            this.udSideRatio = new MWLite.Symbology.Controls.NumericUpDownExt(this.components);
            this.udNumberOfSides = new MWLite.Symbology.Controls.NumericUpDownExt(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabFontSymbol = new System.Windows.Forms.TabPage();
            this.characterControl1 = new GridMapper.views.UserControls.CharacterControl();
            this.lblFont = new System.Windows.Forms.Label();
            this.comboCharacterFont = new System.Windows.Forms.ComboBox();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pickerFill = new Owf.Controls.Office2007ColorPicker(this.components);
            this.pickerOutline = new Owf.Controls.Office2007ColorPicker(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSize)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.tabPointSymbol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSideRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumberOfSides)).BeginInit();
            this.tabFontSymbol.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preview:";
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.SystemColors.Window;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(13, 38);
            this.picPreview.Margin = new System.Windows.Forms.Padding(4);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(169, 94);
            this.picPreview.TabIndex = 5;
            this.picPreview.TabStop = false;
            // 
            // udRotation
            // 
            this.udRotation.Location = new System.Drawing.Point(117, 191);
            this.udRotation.Margin = new System.Windows.Forms.Padding(4);
            this.udRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.udRotation.Name = "udRotation";
            this.udRotation.Size = new System.Drawing.Size(65, 22);
            this.udRotation.TabIndex = 21;
            this.udRotation.ValueChanged += new System.EventHandler(this.ApplyOptionsToGUI);
            // 
            // udSize
            // 
            this.udSize.Location = new System.Drawing.Point(117, 157);
            this.udSize.Margin = new System.Windows.Forms.Padding(4);
            this.udSize.Name = "udSize";
            this.udSize.Size = new System.Drawing.Size(65, 22);
            this.udSize.TabIndex = 20;
            this.udSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udSize.ValueChanged += new System.EventHandler(this.ApplyOptionsToGUI);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Rotation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Size";
            // 
            // transpFillColor
            // 
            this.transpFillColor.BandColor = System.Drawing.Color.Empty;
            this.transpFillColor.Location = new System.Drawing.Point(13, 250);
            this.transpFillColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transpFillColor.MaximumSize = new System.Drawing.Size(1365, 39);
            this.transpFillColor.MinimumSize = new System.Drawing.Size(171, 39);
            this.transpFillColor.Name = "transpFillColor";
            this.transpFillColor.Size = new System.Drawing.Size(171, 39);
            this.transpFillColor.TabIndex = 22;
            this.transpFillColor.Value = ((byte)(255));
            this.transpFillColor.ValueChanged += new GridMapper.views.UserControls.TransparencyControl.ValueChangedDeleg(this.OnTransparencyValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Transparency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Color";
            // 
            // chkFillVisible
            // 
            this.chkFillVisible.AutoSize = true;
            this.chkFillVisible.Location = new System.Drawing.Point(19, 29);
            this.chkFillVisible.Margin = new System.Windows.Forms.Padding(4);
            this.chkFillVisible.Name = "chkFillVisible";
            this.chkFillVisible.Size = new System.Drawing.Size(90, 21);
            this.chkFillVisible.TabIndex = 24;
            this.chkFillVisible.Text = "Fill visible";
            this.chkFillVisible.UseVisualStyleBackColor = true;
            this.chkFillVisible.CheckedChanged += new System.EventHandler(this.ApplyOptionsToGUI);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Width";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Color";
            // 
            // chkOutlineVisible
            // 
            this.chkOutlineVisible.AutoSize = true;
            this.chkOutlineVisible.Location = new System.Drawing.Point(19, 81);
            this.chkOutlineVisible.Margin = new System.Windows.Forms.Padding(4);
            this.chkOutlineVisible.Name = "chkOutlineVisible";
            this.chkOutlineVisible.Size = new System.Drawing.Size(118, 21);
            this.chkOutlineVisible.TabIndex = 28;
            this.chkOutlineVisible.Text = "Outline visible";
            this.chkOutlineVisible.UseVisualStyleBackColor = true;
            this.chkOutlineVisible.CheckedChanged += new System.EventHandler(this.ApplyOptionsToGUI);
            // 
            // comboLineWidth
            // 
            this.comboLineWidth.Color1 = System.Drawing.Color.Gray;
            this.comboLineWidth.Color2 = System.Drawing.Color.Gray;
            this.comboLineWidth.ColorSchemes = null;
            this.comboLineWidth.ComboStyle = GridMapper.views.UserControls.ImageComboStyle.Common;
            this.comboLineWidth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboLineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLineWidth.FormattingEnabled = true;
            this.comboLineWidth.Location = new System.Drawing.Point(58, 147);
            this.comboLineWidth.Name = "comboLineWidth";
            this.comboLineWidth.OutlineColor = System.Drawing.Color.Black;
            this.comboLineWidth.Size = new System.Drawing.Size(81, 23);
            this.comboLineWidth.TabIndex = 30;
            this.comboLineWidth.SelectedIndexChanged += new System.EventHandler(this.ApplyOptionsToGUI);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabPointSymbol);
            this.tabSettings.Controls.Add(this.tabFontSymbol);
            this.tabSettings.Controls.Add(this.tabOptions);
            this.tabSettings.Location = new System.Drawing.Point(215, 16);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(576, 442);
            this.tabSettings.TabIndex = 31;
            // 
            // tabPointSymbol
            // 
            this.tabPointSymbol.Controls.Add(this.comboPointType);
            this.tabPointSymbol.Controls.Add(this.symbolControl1);
            this.tabPointSymbol.Controls.Add(this.udSideRatio);
            this.tabPointSymbol.Controls.Add(this.udNumberOfSides);
            this.tabPointSymbol.Controls.Add(this.label5);
            this.tabPointSymbol.Controls.Add(this.label7);
            this.tabPointSymbol.Controls.Add(this.label6);
            this.tabPointSymbol.Location = new System.Drawing.Point(4, 25);
            this.tabPointSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.tabPointSymbol.Name = "tabPointSymbol";
            this.tabPointSymbol.Padding = new System.Windows.Forms.Padding(4);
            this.tabPointSymbol.Size = new System.Drawing.Size(515, 413);
            this.tabPointSymbol.TabIndex = 0;
            this.tabPointSymbol.Text = "Point symbol";
            this.tabPointSymbol.UseVisualStyleBackColor = true;
            // 
            // comboPointType
            // 
            this.comboPointType.Color1 = System.Drawing.Color.Gray;
            this.comboPointType.Color2 = System.Drawing.Color.Gray;
            this.comboPointType.ColorSchemes = null;
            this.comboPointType.ComboStyle = GridMapper.views.UserControls.ImageComboStyle.Common;
            this.comboPointType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboPointType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPointType.FormattingEnabled = true;
            this.comboPointType.Location = new System.Drawing.Point(231, 42);
            this.comboPointType.Name = "comboPointType";
            this.comboPointType.OutlineColor = System.Drawing.Color.Black;
            this.comboPointType.Size = new System.Drawing.Size(195, 23);
            this.comboPointType.TabIndex = 17;
            // 
            // symbolControl1
            // 
            this.symbolControl1.BackColor = System.Drawing.Color.Transparent;
            this.symbolControl1.CellHeight = 24;
            this.symbolControl1.CellWidth = 24;
            this.symbolControl1.Font = new System.Drawing.Font("Arial", 25.6F);
            this.symbolControl1.GridColor = System.Drawing.Color.Black;
            this.symbolControl1.GridVisible = true;
            this.symbolControl1.ItemCount = 17;
            this.symbolControl1.Location = new System.Drawing.Point(71, 207);
            this.symbolControl1.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.symbolControl1.Name = "symbolControl1";
            this.symbolControl1.SelectedIndex = -1;
            this.symbolControl1.Size = new System.Drawing.Size(396, 145);
            this.symbolControl1.TabIndex = 16;
            // 
            // udSideRatio
            // 
            this.udSideRatio.Location = new System.Drawing.Point(231, 145);
            this.udSideRatio.Margin = new System.Windows.Forms.Padding(4);
            this.udSideRatio.Name = "udSideRatio";
            this.udSideRatio.Size = new System.Drawing.Size(65, 22);
            this.udSideRatio.TabIndex = 15;
            this.udSideRatio.ValueChanged += new System.EventHandler(this.ApplyOptionsToGUI);
            // 
            // udNumberOfSides
            // 
            this.udNumberOfSides.Location = new System.Drawing.Point(231, 98);
            this.udNumberOfSides.Margin = new System.Windows.Forms.Padding(4);
            this.udNumberOfSides.Name = "udNumberOfSides";
            this.udNumberOfSides.Size = new System.Drawing.Size(65, 22);
            this.udNumberOfSides.TabIndex = 14;
            this.udNumberOfSides.ValueChanged += new System.EventHandler(this.ApplyOptionsToGUI);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Point type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Side ratio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Number of sides";
            // 
            // tabFontSymbol
            // 
            this.tabFontSymbol.Controls.Add(this.characterControl1);
            this.tabFontSymbol.Controls.Add(this.lblFont);
            this.tabFontSymbol.Controls.Add(this.comboCharacterFont);
            this.tabFontSymbol.Location = new System.Drawing.Point(4, 25);
            this.tabFontSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.tabFontSymbol.Name = "tabFontSymbol";
            this.tabFontSymbol.Padding = new System.Windows.Forms.Padding(4);
            this.tabFontSymbol.Size = new System.Drawing.Size(568, 413);
            this.tabFontSymbol.TabIndex = 1;
            this.tabFontSymbol.Text = "Character symbols";
            this.tabFontSymbol.UseVisualStyleBackColor = true;
            // 
            // characterControl1
            // 
            this.characterControl1.BackColor = System.Drawing.Color.Transparent;
            this.characterControl1.CellHeight = 32;
            this.characterControl1.CellWidth = 32;
            this.characterControl1.Font = new System.Drawing.Font("Arial", 25.6F);
            this.characterControl1.GridColor = System.Drawing.Color.Black;
            this.characterControl1.GridVisible = true;
            this.characterControl1.ItemCount = 224;
            this.characterControl1.Location = new System.Drawing.Point(26, 56);
            this.characterControl1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.characterControl1.Name = "characterControl1";
            this.characterControl1.SelectedCharacterCode = ((byte)(0));
            this.characterControl1.SelectedIndex = -1;
            this.characterControl1.Size = new System.Drawing.Size(422, 330);
            this.characterControl1.TabIndex = 3;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(15, 17);
            this.lblFont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(118, 17);
            this.lblFont.TabIndex = 2;
            this.lblFont.Text = "Character symbol";
            // 
            // comboCharacterFont
            // 
            this.comboCharacterFont.FormattingEnabled = true;
            this.comboCharacterFont.Location = new System.Drawing.Point(139, 11);
            this.comboCharacterFont.Margin = new System.Windows.Forms.Padding(4);
            this.comboCharacterFont.Name = "comboCharacterFont";
            this.comboCharacterFont.Size = new System.Drawing.Size(299, 24);
            this.comboCharacterFont.TabIndex = 1;
            this.comboCharacterFont.SelectedIndexChanged += new System.EventHandler(this.OnComboFontSelectionIndexChanged);
            // 
            // tabOptions
            // 
            this.tabOptions.Location = new System.Drawing.Point(4, 25);
            this.tabOptions.Margin = new System.Windows.Forms.Padding(4);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(4);
            this.tabOptions.Size = new System.Drawing.Size(515, 413);
            this.tabOptions.TabIndex = 2;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(648, 473);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(72, 33);
            this.btnApply.TabIndex = 34;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(570, 473);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 33);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(725, 473);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(60, 33);
            this.btnOk.TabIndex = 32;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickerOutline);
            this.groupBox1.Controls.Add(this.pickerFill);
            this.groupBox1.Controls.Add(this.comboLineWidth);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chkOutlineVisible);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkFillVisible);
            this.groupBox1.Location = new System.Drawing.Point(12, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 205);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // pickerFill
            // 
            this.pickerFill.Color = System.Drawing.Color.Black;
            this.pickerFill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.pickerFill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickerFill.FormattingEnabled = true;
            this.pickerFill.Items.AddRange(new object[] {
            "Color"});
            this.pickerFill.Location = new System.Drawing.Point(85, 51);
            this.pickerFill.Name = "pickerFill";
            this.pickerFill.Size = new System.Drawing.Size(50, 23);
            this.pickerFill.TabIndex = 31;
            // 
            // pickerOutline
            // 
            this.pickerOutline.Color = System.Drawing.Color.Black;
            this.pickerOutline.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.pickerOutline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickerOutline.FormattingEnabled = true;
            this.pickerOutline.Items.AddRange(new object[] {
            "Color"});
            this.pickerOutline.Location = new System.Drawing.Point(85, 109);
            this.pickerOutline.Name = "pickerOutline";
            this.pickerOutline.Size = new System.Drawing.Size(50, 23);
            this.pickerOutline.TabIndex = 32;
            // 
            // PointLayerSymbologyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.transpFillColor);
            this.Controls.Add(this.udRotation);
            this.Controls.Add(this.udSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PointLayerSymbologyForm";
            this.Text = "PointLayerSymbologyForm";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSize)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabPointSymbol.ResumeLayout(false);
            this.tabPointSymbol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSideRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumberOfSides)).EndInit();
            this.tabFontSymbol.ResumeLayout(false);
            this.tabFontSymbol.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPreview;
        private MWLite.Symbology.Controls.NumericUpDownExt udRotation;
        private MWLite.Symbology.Controls.NumericUpDownExt udSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private UserControls.TransparencyControl transpFillColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkFillVisible;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkOutlineVisible;
        private UserControls.ImageCombo comboLineWidth;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabPointSymbol;
        private UserControls.SymbolControl symbolControl1;
        private MWLite.Symbology.Controls.NumericUpDownExt udSideRatio;
        private MWLite.Symbology.Controls.NumericUpDownExt udNumberOfSides;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabFontSymbol;
        private UserControls.CharacterControl characterControl1;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox comboCharacterFont;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private UserControls.ImageCombo comboPointType;
        private System.Windows.Forms.GroupBox groupBox1;
        private Owf.Controls.Office2007ColorPicker pickerOutline;
        private Owf.Controls.Office2007ColorPicker pickerFill;
    }
}