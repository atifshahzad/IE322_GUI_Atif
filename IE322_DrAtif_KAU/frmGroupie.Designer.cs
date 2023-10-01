namespace IE322_App_KAU
{
    partial class frmGroupie
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
            this.PicMe = new System.Windows.Forms.PictureBox();
            this.PicLeft = new System.Windows.Forms.PictureBox();
            this.PicRight = new System.Windows.Forms.PictureBox();
            this.PicFront = new System.Windows.Forms.PictureBox();
            this.PicBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.CmbGroupie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicMe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            this.SuspendLayout();
            // 
            // PicMe
            // 
            this.PicMe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicMe.Location = new System.Drawing.Point(208, 162);
            this.PicMe.Name = "PicMe";
            this.PicMe.Size = new System.Drawing.Size(182, 147);
            this.PicMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMe.TabIndex = 0;
            this.PicMe.TabStop = false;
            this.PicMe.Click += new System.EventHandler(this.PicMe_Click);
            // 
            // PicLeft
            // 
            this.PicLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicLeft.Location = new System.Drawing.Point(20, 162);
            this.PicLeft.Name = "PicLeft";
            this.PicLeft.Size = new System.Drawing.Size(182, 147);
            this.PicLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLeft.TabIndex = 1;
            this.PicLeft.TabStop = false;
            this.PicLeft.Click += new System.EventHandler(this.PicLeft_Click);
            // 
            // PicRight
            // 
            this.PicRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicRight.Location = new System.Drawing.Point(396, 162);
            this.PicRight.Name = "PicRight";
            this.PicRight.Size = new System.Drawing.Size(182, 147);
            this.PicRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicRight.TabIndex = 2;
            this.PicRight.TabStop = false;
            this.PicRight.Click += new System.EventHandler(this.PicRight_Click);
            // 
            // PicFront
            // 
            this.PicFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicFront.Location = new System.Drawing.Point(208, 9);
            this.PicFront.Name = "PicFront";
            this.PicFront.Size = new System.Drawing.Size(182, 147);
            this.PicFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFront.TabIndex = 3;
            this.PicFront.TabStop = false;
            this.PicFront.Click += new System.EventHandler(this.PicFront_Click);
            // 
            // PicBack
            // 
            this.PicBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBack.Location = new System.Drawing.Point(208, 315);
            this.PicBack.Name = "PicBack";
            this.PicBack.Size = new System.Drawing.Size(182, 147);
            this.PicBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBack.TabIndex = 4;
            this.PicBack.TabStop = false;
            this.PicBack.Click += new System.EventHandler(this.PicBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Member ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(27, 58);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(137, 20);
            this.TxtID.TabIndex = 6;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(503, 439);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // CmbGroupie
            // 
            this.CmbGroupie.FormattingEnabled = true;
            this.CmbGroupie.Location = new System.Drawing.Point(425, 58);
            this.CmbGroupie.Name = "CmbGroupie";
            this.CmbGroupie.Size = new System.Drawing.Size(126, 21);
            this.CmbGroupie.TabIndex = 8;
            this.CmbGroupie.SelectedIndexChanged += new System.EventHandler(this.CmbGroupie_SelectedIndexChanged);
            // 
            // frmGroupie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 476);
            this.Controls.Add(this.CmbGroupie);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicBack);
            this.Controls.Add(this.PicFront);
            this.Controls.Add(this.PicRight);
            this.Controls.Add(this.PicLeft);
            this.Controls.Add(this.PicMe);
            this.Name = "frmGroupie";
            this.Text = "GroupieApp by 1234567";
            this.Load += new System.EventHandler(this.frmGroupie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicMe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicMe;
        private System.Windows.Forms.PictureBox PicLeft;
        private System.Windows.Forms.PictureBox PicRight;
        private System.Windows.Forms.PictureBox PicFront;
        private System.Windows.Forms.PictureBox PicBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ComboBox CmbGroupie;
    }
}