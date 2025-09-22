namespace IE322_App_KAU
{
    partial class frmQ05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQ05));
            this.RtbQ01 = new System.Windows.Forms.RichTextBox();
            this.LblAttempts = new System.Windows.Forms.Label();
            this.CmbLotteryNumbers = new System.Windows.Forms.ComboBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.TxtUserNumbers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RtbQ01
            // 
            this.RtbQ01.Enabled = false;
            this.RtbQ01.Location = new System.Drawing.Point(12, 12);
            this.RtbQ01.Name = "RtbQ01";
            this.RtbQ01.Size = new System.Drawing.Size(761, 78);
            this.RtbQ01.TabIndex = 0;
            this.RtbQ01.Text = resources.GetString("RtbQ01.Text");
            this.RtbQ01.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // LblAttempts
            // 
            this.LblAttempts.AutoSize = true;
            this.LblAttempts.Location = new System.Drawing.Point(23, 140);
            this.LblAttempts.Name = "LblAttempts";
            this.LblAttempts.Size = new System.Drawing.Size(35, 13);
            this.LblAttempts.TabIndex = 1;
            this.LblAttempts.Text = "label1";
            // 
            // CmbLotteryNumbers
            // 
            this.CmbLotteryNumbers.FormattingEnabled = true;
            this.CmbLotteryNumbers.Location = new System.Drawing.Point(26, 215);
            this.CmbLotteryNumbers.Name = "CmbLotteryNumbers";
            this.CmbLotteryNumbers.Size = new System.Drawing.Size(121, 21);
            this.CmbLotteryNumbers.TabIndex = 4;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(315, 257);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(75, 23);
            this.BtnPlay.TabIndex = 5;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(669, 380);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(103, 50);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TxtUserNumbers
            // 
            this.TxtUserNumbers.Location = new System.Drawing.Point(26, 257);
            this.TxtUserNumbers.Name = "TxtUserNumbers";
            this.TxtUserNumbers.Size = new System.Drawing.Size(218, 20);
            this.TxtUserNumbers.TabIndex = 7;
            this.TxtUserNumbers.Text = "Enter six numbers here  separated by comma";
            // 
            // frmQ05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtUserNumbers);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.CmbLotteryNumbers);
            this.Controls.Add(this.LblAttempts);
            this.Controls.Add(this.RtbQ01);
            this.Name = "frmQ05";
            this.Text = "Q05";
            this.Load += new System.EventHandler(this.frmQ01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtbQ01;
        private System.Windows.Forms.Label LblAttempts;
        private System.Windows.Forms.ComboBox CmbLotteryNumbers;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox TxtUserNumbers;
    }
}