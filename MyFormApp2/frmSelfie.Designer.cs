namespace IE322_App_KAU
{
    partial class frmSelfie
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
            this.PicSelfie = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.CmbSelfie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicSelfie)).BeginInit();
            this.SuspendLayout();
            // 
            // PicSelfie
            // 
            this.PicSelfie.Location = new System.Drawing.Point(265, 12);
            this.PicSelfie.Name = "PicSelfie";
            this.PicSelfie.Size = new System.Drawing.Size(311, 284);
            this.PicSelfie.TabIndex = 0;
            this.PicSelfie.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(501, 302);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(84, 84);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(86, 35);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add To List";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter ID:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(84, 24);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(139, 20);
            this.TxtID.TabIndex = 8;
            // 
            // CmbSelfie
            // 
            this.CmbSelfie.FormattingEnabled = true;
            this.CmbSelfie.Location = new System.Drawing.Point(84, 152);
            this.CmbSelfie.Name = "CmbSelfie";
            this.CmbSelfie.Size = new System.Drawing.Size(150, 21);
            this.CmbSelfie.TabIndex = 9;
            this.CmbSelfie.SelectedIndexChanged += new System.EventHandler(this.CmbSelfie_SelectedIndexChanged);
            // 
            // frmSelfie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 337);
            this.Controls.Add(this.CmbSelfie);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.PicSelfie);
            this.Name = "frmSelfie";
            this.Text = "Selfie of 1234567";
            this.Load += new System.EventHandler(this.frmSelfie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicSelfie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicSelfie;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.ComboBox CmbSelfie;
    }
}