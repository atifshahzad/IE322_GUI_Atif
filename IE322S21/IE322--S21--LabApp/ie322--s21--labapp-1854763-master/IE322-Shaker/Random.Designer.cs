
namespace IE322_Shaker
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
            this.btnGenerateRandom = new System.Windows.Forms.Button();
            this.BtnRandomNum = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.LblRGB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerateRandom
            // 
            this.btnGenerateRandom.Location = new System.Drawing.Point(32, 33);
            this.btnGenerateRandom.Name = "btnGenerateRandom";
            this.btnGenerateRandom.Size = new System.Drawing.Size(224, 23);
            this.btnGenerateRandom.TabIndex = 0;
            this.btnGenerateRandom.Text = "Generate Random Color  ";
            this.btnGenerateRandom.UseVisualStyleBackColor = true;
            this.btnGenerateRandom.Click += new System.EventHandler(this.btnGeneraterandom_Click);
            // 
            // BtnRandomNum
            // 
            this.BtnRandomNum.Location = new System.Drawing.Point(197, 206);
            this.BtnRandomNum.Name = "BtnRandomNum";
            this.BtnRandomNum.Size = new System.Drawing.Size(184, 23);
            this.BtnRandomNum.TabIndex = 1;
            this.BtnRandomNum.Text = "Raandom Number ";
            this.BtnRandomNum.UseVisualStyleBackColor = true;
            this.BtnRandomNum.Click += new System.EventHandler(this.BtnRandomNum_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(622, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LblRGB
            // 
            this.LblRGB.AutoSize = true;
            this.LblRGB.Location = new System.Drawing.Point(197, 90);
            this.LblRGB.Name = "LblRGB";
            this.LblRGB.Size = new System.Drawing.Size(43, 17);
            this.LblRGB.TabIndex = 3;
            this.LblRGB.Text = "r-g-b ";
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblRGB);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.BtnRandomNum);
            this.Controls.Add(this.btnGenerateRandom);
            this.Name = "frmRandom";
            this.Text = "Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateRandom;
        private System.Windows.Forms.Button BtnRandomNum;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label LblRGB;
    }
}