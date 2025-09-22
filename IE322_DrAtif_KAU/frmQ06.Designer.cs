namespace IE322_App_KAU
{
    partial class frmQ06
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQ06));
            this.RtbQ01 = new System.Windows.Forms.RichTextBox();
            this.CmbRandom = new System.Windows.Forms.ComboBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnSum = new System.Windows.Forms.Button();
            this.BtnAvg = new System.Windows.Forms.Button();
            this.BtnHighest = new System.Windows.Forms.Button();
            this.BtnLowest = new System.Windows.Forms.Button();
            this.BtnEcenCount = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RtbQ01
            // 
            this.RtbQ01.Enabled = false;
            this.RtbQ01.Location = new System.Drawing.Point(3, 12);
            this.RtbQ01.Name = "RtbQ01";
            this.RtbQ01.Size = new System.Drawing.Size(752, 155);
            this.RtbQ01.TabIndex = 1;
            this.RtbQ01.Text = resources.GetString("RtbQ01.Text");
            this.RtbQ01.TextChanged += new System.EventHandler(this.RtbQ01_TextChanged);
            // 
            // CmbRandom
            // 
            this.CmbRandom.FormattingEnabled = true;
            this.CmbRandom.Location = new System.Drawing.Point(259, 222);
            this.CmbRandom.Name = "CmbRandom";
            this.CmbRandom.Size = new System.Drawing.Size(124, 21);
            this.CmbRandom.TabIndex = 2;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(277, 309);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(35, 13);
            this.LblResult.TabIndex = 3;
            this.LblResult.Text = "label1";
            // 
            // BtnSum
            // 
            this.BtnSum.Location = new System.Drawing.Point(60, 260);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(77, 33);
            this.BtnSum.TabIndex = 4;
            this.BtnSum.Text = "Sum";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // BtnAvg
            // 
            this.BtnAvg.Location = new System.Drawing.Point(60, 299);
            this.BtnAvg.Name = "BtnAvg";
            this.BtnAvg.Size = new System.Drawing.Size(77, 33);
            this.BtnAvg.TabIndex = 5;
            this.BtnAvg.Text = "Average";
            this.BtnAvg.UseVisualStyleBackColor = true;
            this.BtnAvg.Click += new System.EventHandler(this.BtnAvg_Click);
            // 
            // BtnHighest
            // 
            this.BtnHighest.Location = new System.Drawing.Point(60, 338);
            this.BtnHighest.Name = "BtnHighest";
            this.BtnHighest.Size = new System.Drawing.Size(77, 33);
            this.BtnHighest.TabIndex = 6;
            this.BtnHighest.Text = "Highest";
            this.BtnHighest.UseVisualStyleBackColor = true;
            this.BtnHighest.Click += new System.EventHandler(this.BtnHighest_Click);
            // 
            // BtnLowest
            // 
            this.BtnLowest.Location = new System.Drawing.Point(143, 260);
            this.BtnLowest.Name = "BtnLowest";
            this.BtnLowest.Size = new System.Drawing.Size(77, 33);
            this.BtnLowest.TabIndex = 7;
            this.BtnLowest.Text = "Lowest";
            this.BtnLowest.UseVisualStyleBackColor = true;
            this.BtnLowest.Click += new System.EventHandler(this.BtnLowest_Click);
            // 
            // BtnEcenCount
            // 
            this.BtnEcenCount.Location = new System.Drawing.Point(143, 299);
            this.BtnEcenCount.Name = "BtnEcenCount";
            this.BtnEcenCount.Size = new System.Drawing.Size(77, 33);
            this.BtnEcenCount.TabIndex = 8;
            this.BtnEcenCount.Text = "Even Count";
            this.BtnEcenCount.UseVisualStyleBackColor = true;
            this.BtnEcenCount.Click += new System.EventHandler(this.BtnEcenCount_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(652, 375);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(103, 50);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmQ06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnEcenCount);
            this.Controls.Add(this.BtnLowest);
            this.Controls.Add(this.BtnHighest);
            this.Controls.Add(this.BtnAvg);
            this.Controls.Add(this.BtnSum);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.CmbRandom);
            this.Controls.Add(this.RtbQ01);
            this.Name = "frmQ06";
            this.Text = "frmQ06";
            this.Load += new System.EventHandler(this.frmQ06_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtbQ01;
        private System.Windows.Forms.ComboBox CmbRandom;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Button BtnAvg;
        private System.Windows.Forms.Button BtnHighest;
        private System.Windows.Forms.Button BtnLowest;
        private System.Windows.Forms.Button BtnEcenCount;
        private System.Windows.Forms.Button BtnBack;
    }
}