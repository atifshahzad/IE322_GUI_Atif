namespace IE322_App_KAU
{
    partial class frmRandom
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGenerateRandom = new System.Windows.Forms.Button();
            this.LblRGB = new System.Windows.Forms.Label();
            this.BtnRandomNum = new System.Windows.Forms.Button();
            this.btnGenerateRandomIneger = new System.Windows.Forms.Button();
            this.btnSeed = new System.Windows.Forms.Button();
            this.cmbRnd1 = new System.Windows.Forms.ComboBox();
            this.cmbRnd2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(197, 227);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGenerateRandom
            // 
            this.btnGenerateRandom.Location = new System.Drawing.Point(16, 11);
            this.btnGenerateRandom.Name = "btnGenerateRandom";
            this.btnGenerateRandom.Size = new System.Drawing.Size(256, 55);
            this.btnGenerateRandom.TabIndex = 6;
            this.btnGenerateRandom.Text = "Generate Random Color";
            this.btnGenerateRandom.UseVisualStyleBackColor = true;
            this.btnGenerateRandom.Click += new System.EventHandler(this.btnGenerateRandom_Click);
            // 
            // LblRGB
            // 
            this.LblRGB.AutoSize = true;
            this.LblRGB.Location = new System.Drawing.Point(122, 78);
            this.LblRGB.Name = "LblRGB";
            this.LblRGB.Size = new System.Drawing.Size(28, 13);
            this.LblRGB.TabIndex = 8;
            this.LblRGB.Text = "r-g-b";
            // 
            // BtnRandomNum
            // 
            this.BtnRandomNum.Location = new System.Drawing.Point(16, 170);
            this.BtnRandomNum.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRandomNum.Name = "BtnRandomNum";
            this.BtnRandomNum.Size = new System.Drawing.Size(112, 33);
            this.BtnRandomNum.TabIndex = 9;
            this.BtnRandomNum.Text = "Random Number";
            this.BtnRandomNum.UseVisualStyleBackColor = true;
            this.BtnRandomNum.Click += new System.EventHandler(this.BtnRandomNum_Click);
            // 
            // btnGenerateRandomIneger
            // 
            this.btnGenerateRandomIneger.Location = new System.Drawing.Point(328, 44);
            this.btnGenerateRandomIneger.Name = "btnGenerateRandomIneger";
            this.btnGenerateRandomIneger.Size = new System.Drawing.Size(113, 34);
            this.btnGenerateRandomIneger.TabIndex = 10;
            this.btnGenerateRandomIneger.Text = "button1";
            this.btnGenerateRandomIneger.UseVisualStyleBackColor = true;
            this.btnGenerateRandomIneger.Click += new System.EventHandler(this.btnGenerateRandomIneger_Click);
            // 
            // btnSeed
            // 
            this.btnSeed.Location = new System.Drawing.Point(328, 151);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(113, 34);
            this.btnSeed.TabIndex = 11;
            this.btnSeed.Text = "seed";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // cmbRnd1
            // 
            this.cmbRnd1.FormattingEnabled = true;
            this.cmbRnd1.Location = new System.Drawing.Point(457, 159);
            this.cmbRnd1.Name = "cmbRnd1";
            this.cmbRnd1.Size = new System.Drawing.Size(104, 21);
            this.cmbRnd1.TabIndex = 12;
            // 
            // cmbRnd2
            // 
            this.cmbRnd2.FormattingEnabled = true;
            this.cmbRnd2.Location = new System.Drawing.Point(584, 159);
            this.cmbRnd2.Name = "cmbRnd2";
            this.cmbRnd2.Size = new System.Drawing.Size(104, 21);
            this.cmbRnd2.TabIndex = 13;
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 272);
            this.Controls.Add(this.cmbRnd2);
            this.Controls.Add(this.cmbRnd1);
            this.Controls.Add(this.btnSeed);
            this.Controls.Add(this.btnGenerateRandomIneger);
            this.Controls.Add(this.BtnRandomNum);
            this.Controls.Add(this.LblRGB);
            this.Controls.Add(this.btnGenerateRandom);
            this.Controls.Add(this.btnBack);
            this.Name = "frmRandom";
            this.Text = "Random";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGenerateRandom;
        private System.Windows.Forms.Label LblRGB;
        private System.Windows.Forms.Button BtnRandomNum;
        private System.Windows.Forms.Button btnGenerateRandomIneger;
        private System.Windows.Forms.Button btnSeed;
        private System.Windows.Forms.ComboBox cmbRnd1;
        private System.Windows.Forms.ComboBox cmbRnd2;
    }
}