
namespace GridMapper.views
{
    partial class LabelCategroyForm_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelCategroyForm_1));
            this.cboFields = new System.Windows.Forms.ComboBox();
            this.listValues = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFont = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCollisionBuffer = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.chkAvoidCollision = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboVerticalPosition = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.chkAutoOffset = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtFontOffsetX = new System.Windows.Forms.TextBox();
            this.txtFontOffsetY = new System.Windows.Forms.TextBox();
            this.lblFontName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkOutlineVisible = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optionBR = new System.Windows.Forms.RadioButton();
            this.optionBC = new System.Windows.Forms.RadioButton();
            this.optionBL = new System.Windows.Forms.RadioButton();
            this.optionCR = new System.Windows.Forms.RadioButton();
            this.optionCC = new System.Windows.Forms.RadioButton();
            this.optionCL = new System.Windows.Forms.RadioButton();
            this.optionTR = new System.Windows.Forms.RadioButton();
            this.optionTC = new System.Windows.Forms.RadioButton();
            this.optionTL = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFontTransparency = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.imagesLabel = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabFont.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboFields
            // 
            this.cboFields.FormattingEnabled = true;
            this.cboFields.Location = new System.Drawing.Point(12, 97);
            this.cboFields.Name = "cboFields";
            this.cboFields.Size = new System.Drawing.Size(225, 24);
            this.cboFields.TabIndex = 0;
            // 
            // listValues
            // 
            this.listValues.FormattingEnabled = true;
            this.listValues.Location = new System.Drawing.Point(12, 160);
            this.listValues.Name = "listValues";
            this.listValues.Size = new System.Drawing.Size(225, 259);
            this.listValues.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFont);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(255, 128);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 401);
            this.tabControl1.TabIndex = 2;
            // 
            // tabFont
            // 
            this.tabFont.Controls.Add(this.txtCollisionBuffer);
            this.tabFont.Controls.Add(this.label25);
            this.tabFont.Controls.Add(this.chkAvoidCollision);
            this.tabFont.Controls.Add(this.groupBox6);
            this.tabFont.Controls.Add(this.lblFontName);
            this.tabFont.Controls.Add(this.label5);
            this.tabFont.Controls.Add(this.chkOutlineVisible);
            this.tabFont.Controls.Add(this.groupBox2);
            this.tabFont.Controls.Add(this.label6);
            this.tabFont.Controls.Add(this.groupBox5);
            this.tabFont.Controls.Add(this.label3);
            this.tabFont.Controls.Add(this.txtFontTransparency);
            this.tabFont.Controls.Add(this.label4);
            this.tabFont.Controls.Add(this.txtFontSize);
            this.tabFont.Location = new System.Drawing.Point(4, 25);
            this.tabFont.Name = "tabFont";
            this.tabFont.Padding = new System.Windows.Forms.Padding(3);
            this.tabFont.Size = new System.Drawing.Size(504, 372);
            this.tabFont.TabIndex = 1;
            this.tabFont.Text = "Font";
            this.tabFont.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select field containing categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unique values in selected column";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(504, 372);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCollisionBuffer
            // 
            this.txtCollisionBuffer.Location = new System.Drawing.Point(103, 304);
            this.txtCollisionBuffer.Margin = new System.Windows.Forms.Padding(4);
            this.txtCollisionBuffer.Name = "txtCollisionBuffer";
            this.txtCollisionBuffer.Size = new System.Drawing.Size(35, 22);
            this.txtCollisionBuffer.TabIndex = 83;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(17, 300);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 43);
            this.label25.TabIndex = 82;
            this.label25.Text = "Collision buffer";
            // 
            // chkAvoidCollision
            // 
            this.chkAvoidCollision.AutoSize = true;
            this.chkAvoidCollision.Location = new System.Drawing.Point(8, 278);
            this.chkAvoidCollision.Margin = new System.Windows.Forms.Padding(4);
            this.chkAvoidCollision.Name = "chkAvoidCollision";
            this.chkAvoidCollision.Size = new System.Drawing.Size(126, 21);
            this.chkAvoidCollision.TabIndex = 81;
            this.chkAvoidCollision.Text = "Avoid collisions";
            this.chkAvoidCollision.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboVerticalPosition);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.chkAutoOffset);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.txtFontOffsetX);
            this.groupBox6.Controls.Add(this.txtFontOffsetY);
            this.groupBox6.Location = new System.Drawing.Point(181, 193);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(291, 162);
            this.groupBox6.TabIndex = 80;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Position";
            // 
            // comboVerticalPosition
            // 
            this.comboVerticalPosition.FormattingEnabled = true;
            this.comboVerticalPosition.Location = new System.Drawing.Point(87, 113);
            this.comboVerticalPosition.Margin = new System.Windows.Forms.Padding(4);
            this.comboVerticalPosition.Name = "comboVerticalPosition";
            this.comboVerticalPosition.Size = new System.Drawing.Size(177, 24);
            this.comboVerticalPosition.TabIndex = 74;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(161, 50);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 36);
            this.label32.TabIndex = 76;
            this.label32.Text = "Label offset y";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(17, 107);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 36);
            this.label21.TabIndex = 75;
            this.label21.Text = "Vertical position";
            // 
            // chkAutoOffset
            // 
            this.chkAutoOffset.AutoSize = true;
            this.chkAutoOffset.Location = new System.Drawing.Point(21, 23);
            this.chkAutoOffset.Margin = new System.Windows.Forms.Padding(4);
            this.chkAutoOffset.Name = "chkAutoOffset";
            this.chkAutoOffset.Size = new System.Drawing.Size(98, 21);
            this.chkAutoOffset.TabIndex = 73;
            this.chkAutoOffset.Text = "Auto offset";
            this.chkAutoOffset.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(29, 50);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 36);
            this.label22.TabIndex = 72;
            this.label22.Text = "Label offset x";
            // 
            // txtFontOffsetX
            // 
            this.txtFontOffsetX.Location = new System.Drawing.Point(92, 54);
            this.txtFontOffsetX.Margin = new System.Windows.Forms.Padding(4);
            this.txtFontOffsetX.Name = "txtFontOffsetX";
            this.txtFontOffsetX.Size = new System.Drawing.Size(35, 22);
            this.txtFontOffsetX.TabIndex = 71;
            // 
            // txtFontOffsetY
            // 
            this.txtFontOffsetY.Location = new System.Drawing.Point(224, 54);
            this.txtFontOffsetY.Margin = new System.Windows.Forms.Padding(4);
            this.txtFontOffsetY.Name = "txtFontOffsetY";
            this.txtFontOffsetY.Size = new System.Drawing.Size(35, 22);
            this.txtFontOffsetY.TabIndex = 70;
            // 
            // lblFontName
            // 
            this.lblFontName.AutoSize = true;
            this.lblFontName.Location = new System.Drawing.Point(7, 19);
            this.lblFontName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFontName.Name = "lblFontName";
            this.lblFontName.Size = new System.Drawing.Size(45, 17);
            this.lblFontName.TabIndex = 79;
            this.lblFontName.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 78;
            this.label5.Text = "Outline color";
            // 
            // chkOutlineVisible
            // 
            this.chkOutlineVisible.AutoSize = true;
            this.chkOutlineVisible.Location = new System.Drawing.Point(11, 193);
            this.chkOutlineVisible.Margin = new System.Windows.Forms.Padding(4);
            this.chkOutlineVisible.Name = "chkOutlineVisible";
            this.chkOutlineVisible.Size = new System.Drawing.Size(118, 21);
            this.chkOutlineVisible.TabIndex = 77;
            this.chkOutlineVisible.Text = "Outline visible";
            this.chkOutlineVisible.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optionBR);
            this.groupBox2.Controls.Add(this.optionBC);
            this.groupBox2.Controls.Add(this.optionBL);
            this.groupBox2.Controls.Add(this.optionCR);
            this.groupBox2.Controls.Add(this.optionCC);
            this.groupBox2.Controls.Add(this.optionCL);
            this.groupBox2.Controls.Add(this.optionTR);
            this.groupBox2.Controls.Add(this.optionTC);
            this.groupBox2.Controls.Add(this.optionTL);
            this.groupBox2.Location = new System.Drawing.Point(349, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(123, 119);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alignment";
            // 
            // optionBR
            // 
            this.optionBR.Appearance = System.Windows.Forms.Appearance.Button;
            this.optionBR.AutoSize = true;
            this.optionBR.ImageKey = "bottomRight.bmp";
            this.optionBR.ImageList = this.imagesLabel;
            this.optionBR.Location = new System.Drawing.Point(76, 84);
            this.optionBR.Margin = new System.Windows.Forms.Padding(4);
            this.optionBR.Name = "optionBR";
            this.optionBR.Size = new System.Drawing.Size(22, 22);
            this.optionBR.TabIndex = 25;
            this.optionBR.TabStop = true;
            this.optionBR.UseVisualStyleBackColor = true;
            // 
            // optionBC
            // 
            this.optionBC.Appearance = System.Windows.Forms.Appearance.Button;
            this.optionBC.AutoSize = true;
            this.optionBC.ImageKey = "bottomCenter.bmp";
            this.optionBC.ImageList = this.imagesLabel;
            this.optionBC.Location = new System.Drawing.Point(43, 84);
            this.optionBC.Margin = new System.Windows.Forms.Padding(4);
            this.optionBC.Name = "optionBC";
            this.optionBC.Size = new System.Drawing.Size(22, 22);
            this.optionBC.TabIndex = 24;
            this.optionBC.TabStop = true;
            this.optionBC.UseVisualStyleBackColor = true;
            // 
            // optionBL
            // 
            this.optionBL.Appearance = System.Windows.Forms.Appearance.Button;
            this.optionBL.AutoSize = true;
            this.optionBL.ImageKey = "bottomLeft.bmp";
            this.optionBL.ImageList = this.imagesLabel;
            this.optionBL.Location = new System.Drawing.Point(11, 84);
            this.optionBL.Margin = new System.Windows.Forms.Padding(4);
            this.optionBL.Name = "optionBL";
            this.optionBL.Size = new System.Drawing.Size(22, 22);
            this.optionBL.TabIndex = 23;
            this.optionBL.TabStop = true;
            this.optionBL.UseVisualStyleBackColor = true;
            // 
            // optionCR
            // 
            this.optionCR.Appearance = System.Windows.Forms.Appearance.Button;
            this.optionCR.AutoSize = true;
            this.optionCR.ImageKey = "centerRight.bmp";
            this.optionCR.ImageList = this.imagesLabel;
            this.optionCR.Location = new System.Drawing.Point(76, 55);
            this.optionCR.Margin = new System.Windows.Forms.Padding(4);
            this.optionCR.Name = "optionCR";
            this.optionCR.Size = new System.Drawing.Size(22, 22);
            this.optionCR.TabIndex = 22;
            this.optionCR.TabStop = true;
            this.optionCR.UseVisualStyleBackColor = true;
            // 
            // optionCC
            // 
            this.optionCC.Appearance = System.Windows.Forms.Appearance.Button;
            this.optionCC.AutoSize = true;
            this.optionCC.ImageKey = "centerCenter.bmp";
            this.optionCC.ImageList = this.imagesLabel;
            this.optionCC.Location = new System.Drawing.Point(43, 55);
            this.optionCC.Margin = new System.Windows.Forms.Padding(4);
            this.optionCC.Name = "optionCC";
            this.optionCC.Size = new System.Drawing.Size(22, 22);
            this.optionCC.TabIndex = 21;
            this.optionCC.TabStop = true;
            this.optionCC.UseVisualStyleBackColor = true;
            // 
            // optionCL
            // 
            this.optionCL.Appearance = System.Windows.Forms.Appearance.Button;
            this.optionCL.AutoSize = true;
            this.optionCL.ImageKey = "centerLeft.bmp";
            this.optionCL.ImageList = this.imagesLabel;
            this.optionCL.Location = new System.Drawing.Point(11, 55);
            this.optionCL.Margin = new System.Windows.Forms.Padding(4);
            this.optionCL.Name = "optionCL";
            this.optionCL.Size = new System.Drawing.Size(22, 22);
            this.optionCL.TabIndex = 20;
            this.optionCL.TabStop = true;
            this.optionCL.UseVisualStyleBackColor = true;
            // 
            // optionTR
            // 
            this.optionTR.Appearance = System.Windows.Forms.Appearance.Button;
            this.optionTR.AutoSize = true;
            this.optionTR.ImageKey = "topRight.bmp";
            this.optionTR.ImageList = this.imagesLabel;
            this.optionTR.Location = new System.Drawing.Point(77, 27);
            this.optionTR.Margin = new System.Windows.Forms.Padding(4);
            this.optionTR.Name = "optionTR";
            this.optionTR.Size = new System.Drawing.Size(22, 22);
            this.optionTR.TabIndex = 19;
            this.optionTR.TabStop = true;
            this.optionTR.UseVisualStyleBackColor = true;
            // 
            // optionTC
            // 
            this.optionTC.Appearance = System.Windows.Forms.Appearance.Button;
            this.optionTC.AutoSize = true;
            this.optionTC.ImageKey = "topCenter.bmp";
            this.optionTC.ImageList = this.imagesLabel;
            this.optionTC.Location = new System.Drawing.Point(44, 27);
            this.optionTC.Margin = new System.Windows.Forms.Padding(4);
            this.optionTC.Name = "optionTC";
            this.optionTC.Size = new System.Drawing.Size(22, 22);
            this.optionTC.TabIndex = 18;
            this.optionTC.TabStop = true;
            this.optionTC.UseVisualStyleBackColor = true;
            // 
            // optionTL
            // 
            this.optionTL.Appearance = System.Windows.Forms.Appearance.Button;
            this.optionTL.AutoSize = true;
            this.optionTL.ImageKey = "topLeft.bmp";
            this.optionTL.ImageList = this.imagesLabel;
            this.optionTL.Location = new System.Drawing.Point(12, 27);
            this.optionTL.Margin = new System.Windows.Forms.Padding(4);
            this.optionTL.Name = "optionTL";
            this.optionTL.Size = new System.Drawing.Size(22, 22);
            this.optionTL.TabIndex = 17;
            this.optionTL.TabStop = true;
            this.optionTL.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "Color";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkItalic);
            this.groupBox5.Controls.Add(this.chkUnderline);
            this.groupBox5.Controls.Add(this.chkBold);
            this.groupBox5.Location = new System.Drawing.Point(181, 52);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(123, 59);
            this.groupBox5.TabIndex = 74;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Style";
            // 
            // chkItalic
            // 
            this.chkItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkItalic.AutoSize = true;
            this.chkItalic.ImageKey = "ITL.BMP";
            this.chkItalic.ImageList = this.imagesLabel;
            this.chkItalic.Location = new System.Drawing.Point(47, 22);
            this.chkItalic.Margin = new System.Windows.Forms.Padding(4);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(22, 22);
            this.chkItalic.TabIndex = 30;
            this.chkItalic.UseVisualStyleBackColor = true;
            // 
            // chkUnderline
            // 
            this.chkUnderline.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.ImageKey = "UNDRLN.BMP";
            this.chkUnderline.ImageList = this.imagesLabel;
            this.chkUnderline.Location = new System.Drawing.Point(76, 22);
            this.chkUnderline.Margin = new System.Windows.Forms.Padding(4);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(22, 22);
            this.chkUnderline.TabIndex = 29;
            this.chkUnderline.UseVisualStyleBackColor = true;
            // 
            // chkBold
            // 
            this.chkBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBold.AutoSize = true;
            this.chkBold.ImageKey = "BLD.BMP";
            this.chkBold.ImageList = this.imagesLabel;
            this.chkBold.Location = new System.Drawing.Point(17, 22);
            this.chkBold.Margin = new System.Windows.Forms.Padding(4);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(22, 22);
            this.chkBold.TabIndex = 28;
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Transparency";
            // 
            // txtFontTransparency
            // 
            this.txtFontTransparency.Location = new System.Drawing.Point(111, 87);
            this.txtFontTransparency.Margin = new System.Windows.Forms.Padding(4);
            this.txtFontTransparency.Name = "txtFontTransparency";
            this.txtFontTransparency.Size = new System.Drawing.Size(35, 22);
            this.txtFontTransparency.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Size";
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(111, 54);
            this.txtFontSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(35, 22);
            this.txtFontSize.TabIndex = 70;
            // 
            // imagesLabel
            // 
            this.imagesLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesLabel.ImageStream")));
            this.imagesLabel.TransparentColor = System.Drawing.Color.White;
            this.imagesLabel.Images.SetKeyName(0, "BLD.BMP");
            this.imagesLabel.Images.SetKeyName(1, "ITL.BMP");
            this.imagesLabel.Images.SetKeyName(2, "UNDRLN.BMP");
            this.imagesLabel.Images.SetKeyName(3, "bottomRight.bmp");
            this.imagesLabel.Images.SetKeyName(4, "topRight.bmp");
            this.imagesLabel.Images.SetKeyName(5, "centerRight.bmp");
            this.imagesLabel.Images.SetKeyName(6, "bottomCenter.bmp");
            this.imagesLabel.Images.SetKeyName(7, "topCenter.bmp");
            this.imagesLabel.Images.SetKeyName(8, "centerCenter.bmp");
            this.imagesLabel.Images.SetKeyName(9, "bottomLeft.bmp");
            this.imagesLabel.Images.SetKeyName(10, "topLeft.bmp");
            this.imagesLabel.Images.SetKeyName(11, "centerLeft.bmp");
            // 
            // LabelCategroyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 627);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listValues);
            this.Controls.Add(this.cboFields);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LabelCategroyForm";
            this.Text = "LabelCategroyForm";
            this.tabControl1.ResumeLayout(false);
            this.tabFont.ResumeLayout(false);
            this.tabFont.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFields;
        private System.Windows.Forms.CheckedListBox listValues;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtCollisionBuffer;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox chkAvoidCollision;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboVerticalPosition;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox chkAutoOffset;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtFontOffsetX;
        private System.Windows.Forms.TextBox txtFontOffsetY;
        private System.Windows.Forms.Label lblFontName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkOutlineVisible;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optionBR;
        private System.Windows.Forms.RadioButton optionBC;
        private System.Windows.Forms.RadioButton optionBL;
        private System.Windows.Forms.RadioButton optionCR;
        private System.Windows.Forms.RadioButton optionCC;
        private System.Windows.Forms.RadioButton optionCL;
        private System.Windows.Forms.RadioButton optionTR;
        private System.Windows.Forms.RadioButton optionTC;
        private System.Windows.Forms.RadioButton optionTL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFontTransparency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.ImageList imagesLabel;
    }
}