namespace GridMapper.views
{
    partial class SaveMapForm
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
            this.txtSave = new System.Windows.Forms.TextBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.chkLayout = new System.Windows.Forms.CheckBox();
            this.lblLayout = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblScaleFactor = new System.Windows.Forms.Label();
            this.txtScaleFactor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(135, 22);
            this.txtSave.Margin = new System.Windows.Forms.Padding(4);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(154, 24);
            this.txtSave.TabIndex = 0;
            this.txtSave.Validating += new System.ComponentModel.CancelEventHandler(this.OnTxtSave_Validating);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(3, 24);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(117, 18);
            this.lblSave.TabIndex = 1;
            this.lblSave.Text = "Resolution (DPI)";
            // 
            // chkLayout
            // 
            this.chkLayout.AutoSize = true;
            this.chkLayout.Location = new System.Drawing.Point(135, 55);
            this.chkLayout.Name = "chkLayout";
            this.chkLayout.Size = new System.Drawing.Size(18, 17);
            this.chkLayout.TabIndex = 6;
            this.chkLayout.UseVisualStyleBackColor = true;
            this.chkLayout.CheckedChanged += new System.EventHandler(this.OnCheckChanged);
            // 
            // lblLayout
            // 
            this.lblLayout.AutoSize = true;
            this.lblLayout.Location = new System.Drawing.Point(3, 55);
            this.lblLayout.Name = "lblLayout";
            this.lblLayout.Size = new System.Drawing.Size(52, 18);
            this.lblLayout.TabIndex = 7;
            this.lblLayout.Text = "Layout";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(242, 120);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(46, 24);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(167, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 24);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // lblScaleFactor
            // 
            this.lblScaleFactor.AutoSize = true;
            this.lblScaleFactor.Location = new System.Drawing.Point(3, 83);
            this.lblScaleFactor.Name = "lblScaleFactor";
            this.lblScaleFactor.Size = new System.Drawing.Size(123, 18);
            this.lblScaleFactor.TabIndex = 9;
            this.lblScaleFactor.Text = "Logo scale factor";
            // 
            // txtScaleFactor
            // 
            this.txtScaleFactor.Location = new System.Drawing.Point(135, 81);
            this.txtScaleFactor.Margin = new System.Windows.Forms.Padding(4);
            this.txtScaleFactor.Name = "txtScaleFactor";
            this.txtScaleFactor.Size = new System.Drawing.Size(154, 24);
            this.txtScaleFactor.TabIndex = 8;
            // 
            // SaveMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 156);
            this.Controls.Add(this.lblScaleFactor);
            this.Controls.Add(this.txtScaleFactor);
            this.Controls.Add(this.lblLayout);
            this.Controls.Add(this.chkLayout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.txtSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaveMapForm";
            this.ShowInTaskbar = false;
            this.Text = "Save fishing grid";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnGrid25SaveForm_FormClosed);
            this.Load += new System.EventHandler(this.OnGrid25SaveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.CheckBox chkLayout;
        private System.Windows.Forms.Label lblLayout;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblScaleFactor;
        private System.Windows.Forms.TextBox txtScaleFactor;
    }
}