
namespace IE322_Shaker
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
            this.TrkMin = new System.Windows.Forms.TrackBar();
            this.TrkMax = new System.Windows.Forms.TrackBar();
            this.Pgb1 = new System.Windows.Forms.ProgressBar();
            this.Pgb2 = new System.Windows.Forms.ProgressBar();
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.Grp1 = new System.Windows.Forms.GroupBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblVal1 = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrkMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkMax)).BeginInit();
            this.Grp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrkMin
            // 
            this.TrkMin.Location = new System.Drawing.Point(63, 21);
            this.TrkMin.Name = "TrkMin";
            this.TrkMin.Size = new System.Drawing.Size(227, 56);
            this.TrkMin.TabIndex = 0;
            this.TrkMin.Scroll += new System.EventHandler(this.TrkMin_Scroll);
            // 
            // TrkMax
            // 
            this.TrkMax.Location = new System.Drawing.Point(63, 66);
            this.TrkMax.Name = "TrkMax";
            this.TrkMax.Size = new System.Drawing.Size(227, 56);
            this.TrkMax.TabIndex = 1;
            // 
            // Pgb1
            // 
            this.Pgb1.Location = new System.Drawing.Point(75, 128);
            this.Pgb1.Name = "Pgb1";
            this.Pgb1.Size = new System.Drawing.Size(201, 29);
            this.Pgb1.TabIndex = 2;
            // 
            // Pgb2
            // 
            this.Pgb2.Location = new System.Drawing.Point(136, 334);
            this.Pgb2.Name = "Pgb2";
            this.Pgb2.Size = new System.Drawing.Size(201, 23);
            this.Pgb2.TabIndex = 3;
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(41, 28);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(95, 49);
            this.btnProgress.TabIndex = 4;
            this.btnProgress.Text = "Show progress";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(180, 28);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset ";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(494, 275);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Grp1
            // 
            this.Grp1.Controls.Add(this.lblMax);
            this.Grp1.Controls.Add(this.lblVal1);
            this.Grp1.Controls.Add(this.lblMin);
            this.Grp1.Controls.Add(this.TrkMin);
            this.Grp1.Controls.Add(this.TrkMax);
            this.Grp1.Controls.Add(this.Pgb1);
            this.Grp1.Location = new System.Drawing.Point(61, 100);
            this.Grp1.Name = "Grp1";
            this.Grp1.Size = new System.Drawing.Size(376, 205);
            this.Grp1.TabIndex = 7;
            this.Grp1.TabStop = false;
            this.Grp1.Text = "groupBox1";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(6, 175);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(34, 17);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "Min:";
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.Location = new System.Drawing.Point(157, 174);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(32, 17);
            this.lblVal1.TabIndex = 4;
            this.lblVal1.Text = "Val:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(302, 178);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(41, 17);
            this.lblMax.TabIndex = 5;
            this.lblMax.Text = "Max: ";
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Grp1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.Pgb2);
            this.Name = "frmProgress";
            this.Text = "Form_progress";
            ((System.ComponentModel.ISupportInitialize)(this.TrkMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkMax)).EndInit();
            this.Grp1.ResumeLayout(false);
            this.Grp1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar TrkMin;
        private System.Windows.Forms.TrackBar TrkMax;
        private System.Windows.Forms.ProgressBar Pgb1;
        private System.Windows.Forms.ProgressBar Pgb2;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox Grp1;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.Label lblMin;
    }
}