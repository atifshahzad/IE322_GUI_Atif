namespace IE322_App_KAU
{
    partial class frmPic01
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
            this.picTry = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.BtnImageFromFile = new System.Windows.Forms.Button();
            this.picTry2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnImageFromRes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdoNormal = new System.Windows.Forms.RadioButton();
            this.RdoStretch = new System.Windows.Forms.RadioButton();
            this.RdoAuto = new System.Windows.Forms.RadioButton();
            this.RdoCentre = new System.Windows.Forms.RadioButton();
            this.RdoZoom = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTry
            // 
            this.picTry.Location = new System.Drawing.Point(16, 18);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(231, 254);
            this.picTry.TabIndex = 0;
            this.picTry.TabStop = false;
            this.picTry.Click += new System.EventHandler(this.picTry_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(580, 307);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BtnImageFromFile
            // 
            this.BtnImageFromFile.Location = new System.Drawing.Point(10, 12);
            this.BtnImageFromFile.Name = "BtnImageFromFile";
            this.BtnImageFromFile.Size = new System.Drawing.Size(127, 45);
            this.BtnImageFromFile.TabIndex = 6;
            this.BtnImageFromFile.Text = "Image from File";
            this.BtnImageFromFile.UseVisualStyleBackColor = true;
            this.BtnImageFromFile.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // picTry2
            // 
            this.picTry2.Location = new System.Drawing.Point(263, 18);
            this.picTry2.Name = "picTry2";
            this.picTry2.Size = new System.Drawing.Size(231, 254);
            this.picTry2.TabIndex = 7;
            this.picTry2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picTry);
            this.groupBox1.Controls.Add(this.picTry2);
            this.groupBox1.Location = new System.Drawing.Point(142, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(513, 289);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture Boxes";
            // 
            // BtnImageFromRes
            // 
            this.BtnImageFromRes.Location = new System.Drawing.Point(10, 75);
            this.BtnImageFromRes.Name = "BtnImageFromRes";
            this.BtnImageFromRes.Size = new System.Drawing.Size(127, 45);
            this.BtnImageFromRes.TabIndex = 9;
            this.BtnImageFromRes.Text = "Image from Resource";
            this.BtnImageFromRes.UseVisualStyleBackColor = true;
            this.BtnImageFromRes.Click += new System.EventHandler(this.BtnImageFromRes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdoZoom);
            this.groupBox2.Controls.Add(this.RdoCentre);
            this.groupBox2.Controls.Add(this.RdoAuto);
            this.groupBox2.Controls.Add(this.RdoStretch);
            this.groupBox2.Controls.Add(this.RdoNormal);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 173);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size Mode";
            // 
            // RdoNormal
            // 
            this.RdoNormal.AutoSize = true;
            this.RdoNormal.Location = new System.Drawing.Point(18, 29);
            this.RdoNormal.Name = "RdoNormal";
            this.RdoNormal.Size = new System.Drawing.Size(58, 17);
            this.RdoNormal.TabIndex = 0;
            this.RdoNormal.TabStop = true;
            this.RdoNormal.Text = "Normal";
            this.RdoNormal.UseVisualStyleBackColor = true;
            this.RdoNormal.CheckedChanged += new System.EventHandler(this.RdoNormal_CheckedChanged);
            // 
            // RdoStretch
            // 
            this.RdoStretch.AutoSize = true;
            this.RdoStretch.Location = new System.Drawing.Point(18, 55);
            this.RdoStretch.Name = "RdoStretch";
            this.RdoStretch.Size = new System.Drawing.Size(90, 17);
            this.RdoStretch.TabIndex = 1;
            this.RdoStretch.TabStop = true;
            this.RdoStretch.Text = "StretchImage";
            this.RdoStretch.UseVisualStyleBackColor = true;
            this.RdoStretch.CheckedChanged += new System.EventHandler(this.RdoStretch_CheckedChanged);
            // 
            // RdoAuto
            // 
            this.RdoAuto.AutoSize = true;
            this.RdoAuto.Location = new System.Drawing.Point(18, 81);
            this.RdoAuto.Name = "RdoAuto";
            this.RdoAuto.Size = new System.Drawing.Size(67, 17);
            this.RdoAuto.TabIndex = 2;
            this.RdoAuto.TabStop = true;
            this.RdoAuto.Text = "AutoSize";
            this.RdoAuto.UseVisualStyleBackColor = true;
            this.RdoAuto.CheckedChanged += new System.EventHandler(this.RdoAuto_CheckedChanged);
            // 
            // RdoCentre
            // 
            this.RdoCentre.AutoSize = true;
            this.RdoCentre.Location = new System.Drawing.Point(18, 107);
            this.RdoCentre.Name = "RdoCentre";
            this.RdoCentre.Size = new System.Drawing.Size(88, 17);
            this.RdoCentre.TabIndex = 3;
            this.RdoCentre.TabStop = true;
            this.RdoCentre.Text = "CentreImage";
            this.RdoCentre.UseVisualStyleBackColor = true;
            this.RdoCentre.CheckedChanged += new System.EventHandler(this.RdoCentre_CheckedChanged);
            // 
            // RdoZoom
            // 
            this.RdoZoom.AutoSize = true;
            this.RdoZoom.Location = new System.Drawing.Point(18, 133);
            this.RdoZoom.Name = "RdoZoom";
            this.RdoZoom.Size = new System.Drawing.Size(51, 17);
            this.RdoZoom.TabIndex = 4;
            this.RdoZoom.TabStop = true;
            this.RdoZoom.Text = "Zoom";
            this.RdoZoom.UseVisualStyleBackColor = true;
            this.RdoZoom.CheckedChanged += new System.EventHandler(this.RdoZoom_CheckedChanged);
            // 
            // frmPic01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 348);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnImageFromRes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnImageFromFile);
            this.Controls.Add(this.btnBack);
            this.Name = "frmPic01";
            this.Text = "Picture";
            this.Load += new System.EventHandler(this.frmPic01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTry;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button BtnImageFromFile;
        private System.Windows.Forms.PictureBox picTry2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnImageFromRes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdoZoom;
        private System.Windows.Forms.RadioButton RdoCentre;
        private System.Windows.Forms.RadioButton RdoAuto;
        private System.Windows.Forms.RadioButton RdoStretch;
        private System.Windows.Forms.RadioButton RdoNormal;
    }
}
