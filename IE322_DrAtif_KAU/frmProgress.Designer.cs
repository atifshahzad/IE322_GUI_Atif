namespace IE322_App_KAU
{
    partial class frmProgress
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
            this.BtnShowProgress = new System.Windows.Forms.Button();
            this.Pgb1 = new System.Windows.Forms.ProgressBar();
            this.Pgb2 = new System.Windows.Forms.ProgressBar();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblVal1 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.TrkMin = new System.Windows.Forms.TrackBar();
            this.TrkMax = new System.Windows.Forms.TrackBar();
            this.Grp1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrkMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkMax)).BeginInit();
            this.Grp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(441, 304);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BtnShowProgress
            // 
            this.BtnShowProgress.Location = new System.Drawing.Point(27, 12);
            this.BtnShowProgress.Name = "BtnShowProgress";
            this.BtnShowProgress.Size = new System.Drawing.Size(65, 45);
            this.BtnShowProgress.TabIndex = 6;
            this.BtnShowProgress.Text = "Show Progress";
            this.BtnShowProgress.UseVisualStyleBackColor = true;
            this.BtnShowProgress.Click += new System.EventHandler(this.btnShowProgress_Click);
            // 
            // Pgb1
            // 
            this.Pgb1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Pgb1.Location = new System.Drawing.Point(27, 103);
            this.Pgb1.Name = "Pgb1";
            this.Pgb1.Size = new System.Drawing.Size(304, 45);
            this.Pgb1.TabIndex = 7;
            this.Pgb1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Pgb2
            // 
            this.Pgb2.ForeColor = System.Drawing.Color.LightSalmon;
            this.Pgb2.Location = new System.Drawing.Point(54, 281);
            this.Pgb2.Name = "Pgb2";
            this.Pgb2.Size = new System.Drawing.Size(304, 46);
            this.Pgb2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Pgb2.TabIndex = 8;
            this.Pgb2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(24, 165);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(27, 13);
            this.lblMin.TabIndex = 9;
            this.lblMin.Text = "Min:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(306, 165);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(30, 13);
            this.lblMax.TabIndex = 10;
            this.lblMax.Text = "Max:";
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.Location = new System.Drawing.Point(151, 165);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(28, 13);
            this.lblVal1.TabIndex = 11;
            this.lblVal1.Text = "Val::";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(109, 12);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(74, 45);
            this.BtnReset.TabIndex = 12;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // TrkMin
            // 
            this.TrkMin.Location = new System.Drawing.Point(33, 19);
            this.TrkMin.Name = "TrkMin";
            this.TrkMin.Size = new System.Drawing.Size(242, 45);
            this.TrkMin.TabIndex = 13;
            // 
            // TrkMax
            // 
            this.TrkMax.Location = new System.Drawing.Point(33, 70);
            this.TrkMax.Name = "TrkMax";
            this.TrkMax.Size = new System.Drawing.Size(242, 45);
            this.TrkMax.TabIndex = 14;
            // 
            // Grp1
            // 
            this.Grp1.Controls.Add(this.Pgb1);
            this.Grp1.Controls.Add(this.TrkMax);
            this.Grp1.Controls.Add(this.lblVal1);
            this.Grp1.Controls.Add(this.TrkMin);
            this.Grp1.Controls.Add(this.lblMax);
            this.Grp1.Controls.Add(this.lblMin);
            this.Grp1.Location = new System.Drawing.Point(27, 63);
            this.Grp1.Name = "Grp1";
            this.Grp1.Size = new System.Drawing.Size(390, 197);
            this.Grp1.TabIndex = 15;
            this.Grp1.TabStop = false;
            this.Grp1.Text = "Progressbar1";
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 374);
            this.Controls.Add(this.Grp1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.Pgb2);
            this.Controls.Add(this.BtnShowProgress);
            this.Controls.Add(this.btnBack);
            this.Name = "frmProgress";
            this.Text = "Progress Bar & Track Bar";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrkMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkMax)).EndInit();
            this.Grp1.ResumeLayout(false);
            this.Grp1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button BtnShowProgress;
        private System.Windows.Forms.ProgressBar Pgb1;
        private System.Windows.Forms.ProgressBar Pgb2;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TrackBar TrkMin;
        private System.Windows.Forms.TrackBar TrkMax;
        private System.Windows.Forms.GroupBox Grp1;
    }
}