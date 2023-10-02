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
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTry
            // 
            this.picTry.Location = new System.Drawing.Point(21, 22);
            this.picTry.Margin = new System.Windows.Forms.Padding(4);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(308, 312);
            this.picTry.TabIndex = 0;
            this.picTry.TabStop = false;
            this.picTry.Click += new System.EventHandler(this.picTry_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(773, 378);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BtnImageFromFile
            // 
            this.BtnImageFromFile.Location = new System.Drawing.Point(13, 15);
            this.BtnImageFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.BtnImageFromFile.Name = "BtnImageFromFile";
            this.BtnImageFromFile.Size = new System.Drawing.Size(169, 55);
            this.BtnImageFromFile.TabIndex = 6;
            this.BtnImageFromFile.Text = "Image from File";
            this.BtnImageFromFile.UseVisualStyleBackColor = true;
            this.BtnImageFromFile.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // picTry2
            // 
            this.picTry2.Location = new System.Drawing.Point(351, 22);
            this.picTry2.Margin = new System.Windows.Forms.Padding(4);
            this.picTry2.Name = "picTry2";
            this.picTry2.Size = new System.Drawing.Size(308, 312);
            this.picTry2.TabIndex = 7;
            this.picTry2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picTry);
            this.groupBox1.Controls.Add(this.picTry2);
            this.groupBox1.Location = new System.Drawing.Point(189, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 356);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture Boxes";
            // 
            // BtnImageFromRes
            // 
            this.BtnImageFromRes.Location = new System.Drawing.Point(13, 92);
            this.BtnImageFromRes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnImageFromRes.Name = "BtnImageFromRes";
            this.BtnImageFromRes.Size = new System.Drawing.Size(169, 55);
            this.BtnImageFromRes.TabIndex = 9;
            this.BtnImageFromRes.Text = "Image from Resource";
            this.BtnImageFromRes.UseVisualStyleBackColor = true;
            this.BtnImageFromRes.Click += new System.EventHandler(this.BtnImageFromRes_Click);
            // 
            // frmPic01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 428);
            this.Controls.Add(this.BtnImageFromRes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnImageFromFile);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPic01";
            this.Text = "Picture";
            this.Load += new System.EventHandler(this.frmPic01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTry;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button BtnImageFromFile;
        private System.Windows.Forms.PictureBox picTry2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnImageFromRes;
    }
}