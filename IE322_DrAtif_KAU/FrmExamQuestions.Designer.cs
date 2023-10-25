namespace IE322_App_KAU
{
    partial class FrmExamQuestions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnQ05 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnQ06 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnQ06);
            this.groupBox1.Controls.Add(this.BtnQ05);
            this.groupBox1.Location = new System.Drawing.Point(591, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Practice Problems";
            // 
            // BtnQ05
            // 
            this.BtnQ05.Location = new System.Drawing.Point(24, 186);
            this.BtnQ05.Name = "BtnQ05";
            this.BtnQ05.Size = new System.Drawing.Size(130, 33);
            this.BtnQ05.TabIndex = 0;
            this.BtnQ05.Text = "Question 05";
            this.BtnQ05.UseVisualStyleBackColor = true;
            this.BtnQ05.Click += new System.EventHandler(this.BtnQ05_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(648, 388);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(103, 50);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnQ06
            // 
            this.BtnQ06.Location = new System.Drawing.Point(24, 225);
            this.BtnQ06.Name = "BtnQ06";
            this.BtnQ06.Size = new System.Drawing.Size(130, 33);
            this.BtnQ06.TabIndex = 1;
            this.BtnQ06.Text = "Question 06";
            this.BtnQ06.UseVisualStyleBackColor = true;
            this.BtnQ06.Click += new System.EventHandler(this.BtnQ06_Click);
            // 
            // FrmExamQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmExamQuestions";
            this.Text = "FrmExamQuestions";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnQ05;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnQ06;
    }
}