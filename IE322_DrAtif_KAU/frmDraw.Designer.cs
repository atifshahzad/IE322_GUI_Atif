namespace IE322_App_KAU
{
    partial class frmDraw
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDrawCircle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlTry = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(789, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(12, 12);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(65, 45);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "Draw Line";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Draw Rectangle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDrawCircle
            // 
            this.btnDrawCircle.Location = new System.Drawing.Point(176, 12);
            this.btnDrawCircle.Name = "btnDrawCircle";
            this.btnDrawCircle.Size = new System.Drawing.Size(65, 45);
            this.btnDrawCircle.TabIndex = 8;
            this.btnDrawCircle.Text = "Draw Circle";
            this.btnDrawCircle.UseVisualStyleBackColor = true;
            this.btnDrawCircle.Click += new System.EventHandler(this.btnDrawCircle_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "Draw Dynamically";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlTry
            // 
            this.pnlTry.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlTry.Location = new System.Drawing.Point(297, 63);
            this.pnlTry.Name = "pnlTry";
            this.pnlTry.Size = new System.Drawing.Size(483, 285);
            this.pnlTry.TabIndex = 10;
            this.pnlTry.Click += new System.EventHandler(this.pnlTry_Click);
            this.pnlTry.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTry_Paint);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 361);
            this.Controls.Add(this.pnlTry);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDrawCircle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnBack);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form10_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDrawCircle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlTry;
    }
}