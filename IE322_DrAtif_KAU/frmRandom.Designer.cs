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
            this.BtnRandomIneger = new System.Windows.Forms.Button();
            this.btnSeed = new System.Windows.Forms.Button();
            this.cmbRnd1 = new System.Windows.Forms.ComboBox();
            this.cmbRnd2 = new System.Windows.Forms.ComboBox();
            this.LblDisplay = new System.Windows.Forms.Label();
            this.BtnRandomInegerDefault = new System.Windows.Forms.Button();
            this.BtnRandomInegerMax = new System.Windows.Forms.Button();
            this.BtnRandomDouble = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(618, 315);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGenerateRandom
            // 
            this.btnGenerateRandom.Location = new System.Drawing.Point(12, 283);
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
            this.LblRGB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRGB.Location = new System.Drawing.Point(120, 341);
            this.LblRGB.Name = "LblRGB";
            this.LblRGB.Size = new System.Drawing.Size(45, 19);
            this.LblRGB.TabIndex = 8;
            this.LblRGB.Text = "r-g-b";
            // 
            // BtnRandomNum
            // 
            this.BtnRandomNum.Location = new System.Drawing.Point(170, 21);
            this.BtnRandomNum.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRandomNum.Name = "BtnRandomNum";
            this.BtnRandomNum.Size = new System.Drawing.Size(112, 33);
            this.BtnRandomNum.TabIndex = 9;
            this.BtnRandomNum.Text = "Random Number";
            this.BtnRandomNum.UseVisualStyleBackColor = true;
            this.BtnRandomNum.Click += new System.EventHandler(this.BtnRandomNum_Click);
            // 
            // BtnRandomIneger
            // 
            this.BtnRandomIneger.Location = new System.Drawing.Point(8, 3);
            this.BtnRandomIneger.Name = "BtnRandomIneger";
            this.BtnRandomIneger.Size = new System.Drawing.Size(131, 43);
            this.BtnRandomIneger.TabIndex = 10;
            this.BtnRandomIneger.Text = "Random Ineger";
            this.BtnRandomIneger.UseVisualStyleBackColor = true;
            this.BtnRandomIneger.Click += new System.EventHandler(this.BtnRandomIneger_Click);
            // 
            // btnSeed
            // 
            this.btnSeed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeed.Location = new System.Drawing.Point(53, 3);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(113, 34);
            this.btnSeed.TabIndex = 11;
            this.btnSeed.Text = "Seed";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // cmbRnd1
            // 
            this.cmbRnd1.FormattingEnabled = true;
            this.cmbRnd1.Location = new System.Drawing.Point(3, 43);
            this.cmbRnd1.Name = "cmbRnd1";
            this.cmbRnd1.Size = new System.Drawing.Size(104, 21);
            this.cmbRnd1.TabIndex = 12;
            // 
            // cmbRnd2
            // 
            this.cmbRnd2.FormattingEnabled = true;
            this.cmbRnd2.Location = new System.Drawing.Point(113, 43);
            this.cmbRnd2.Name = "cmbRnd2";
            this.cmbRnd2.Size = new System.Drawing.Size(104, 21);
            this.cmbRnd2.TabIndex = 13;
            // 
            // LblDisplay
            // 
            this.LblDisplay.AutoSize = true;
            this.LblDisplay.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblDisplay.Location = new System.Drawing.Point(3, 196);
            this.LblDisplay.Name = "LblDisplay";
            this.LblDisplay.Size = new System.Drawing.Size(136, 26);
            this.LblDisplay.TabIndex = 14;
            this.LblDisplay.Text = "Display Label";
            this.LblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnRandomInegerDefault
            // 
            this.BtnRandomInegerDefault.Location = new System.Drawing.Point(8, 52);
            this.BtnRandomInegerDefault.Name = "BtnRandomInegerDefault";
            this.BtnRandomInegerDefault.Size = new System.Drawing.Size(131, 43);
            this.BtnRandomInegerDefault.TabIndex = 15;
            this.BtnRandomInegerDefault.Text = "Random Ineger Default Range";
            this.BtnRandomInegerDefault.UseVisualStyleBackColor = true;
            this.BtnRandomInegerDefault.Click += new System.EventHandler(this.BtnRandomInegerDefault_Click);
            // 
            // BtnRandomInegerMax
            // 
            this.BtnRandomInegerMax.Location = new System.Drawing.Point(8, 101);
            this.BtnRandomInegerMax.Name = "BtnRandomInegerMax";
            this.BtnRandomInegerMax.Size = new System.Drawing.Size(131, 43);
            this.BtnRandomInegerMax.TabIndex = 16;
            this.BtnRandomInegerMax.Text = "Random Ineger Max";
            this.BtnRandomInegerMax.UseVisualStyleBackColor = true;
            this.BtnRandomInegerMax.Click += new System.EventHandler(this.BtnRandomInegerMax_Click);
            // 
            // BtnRandomDouble
            // 
            this.BtnRandomDouble.Location = new System.Drawing.Point(8, 150);
            this.BtnRandomDouble.Name = "BtnRandomDouble";
            this.BtnRandomDouble.Size = new System.Drawing.Size(131, 43);
            this.BtnRandomDouble.TabIndex = 18;
            this.BtnRandomDouble.Text = "Random Double";
            this.BtnRandomDouble.UseVisualStyleBackColor = true;
            this.BtnRandomDouble.Click += new System.EventHandler(this.BtnRandomDouble_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.LblDisplay);
            this.panel1.Controls.Add(this.BtnRandomDouble);
            this.panel1.Controls.Add(this.BtnRandomInegerMax);
            this.panel1.Controls.Add(this.BtnRandomIneger);
            this.panel1.Controls.Add(this.BtnRandomInegerDefault);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 232);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSeed);
            this.panel2.Controls.Add(this.cmbRnd1);
            this.panel2.Controls.Add(this.cmbRnd2);
            this.panel2.Location = new System.Drawing.Point(455, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 129);
            this.panel2.TabIndex = 20;
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 365);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnRandomNum);
            this.Controls.Add(this.LblRGB);
            this.Controls.Add(this.btnGenerateRandom);
            this.Controls.Add(this.btnBack);
            this.Name = "frmRandom";
            this.Text = "Random";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGenerateRandom;
        private System.Windows.Forms.Label LblRGB;
        private System.Windows.Forms.Button BtnRandomNum;
        private System.Windows.Forms.Button BtnRandomIneger;
        private System.Windows.Forms.Button btnSeed;
        private System.Windows.Forms.ComboBox cmbRnd1;
        private System.Windows.Forms.ComboBox cmbRnd2;
        private System.Windows.Forms.Label LblDisplay;
        private System.Windows.Forms.Button BtnRandomInegerDefault;
        private System.Windows.Forms.Button BtnRandomInegerMax;
        private System.Windows.Forms.Button BtnRandomDouble;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}