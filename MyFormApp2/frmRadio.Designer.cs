namespace IE322_App_KAU
{
    partial class frmRadio
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
            this.btnReset = new System.Windows.Forms.Button();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoYellow = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoYellow2 = new System.Windows.Forms.RadioButton();
            this.RdoBlue2 = new System.Windows.Forms.RadioButton();
            this.RdoGreen2 = new System.Windows.Forms.RadioButton();
            this.RdoRed2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(30, 30);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(225, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(30, 90);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(45, 17);
            this.rdoRed.TabIndex = 2;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(197, 226);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Location = new System.Drawing.Point(30, 113);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(54, 17);
            this.rdoGreen.TabIndex = 3;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "Green";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdoGreen_CheckedChanged);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(30, 136);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(46, 17);
            this.rdoBlue.TabIndex = 4;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdoBlue_CheckedChanged);
            // 
            // rdoYellow
            // 
            this.rdoYellow.AutoSize = true;
            this.rdoYellow.Location = new System.Drawing.Point(30, 159);
            this.rdoYellow.Name = "rdoYellow";
            this.rdoYellow.Size = new System.Drawing.Size(56, 17);
            this.rdoYellow.TabIndex = 5;
            this.rdoYellow.Text = "Yellow";
            this.rdoYellow.UseVisualStyleBackColor = true;
            this.rdoYellow.CheckedChanged += new System.EventHandler(this.rdoYellow_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoYellow2);
            this.groupBox1.Controls.Add(this.RdoBlue2);
            this.groupBox1.Controls.Add(this.RdoGreen2);
            this.groupBox1.Controls.Add(this.RdoRed2);
            this.groupBox1.Location = new System.Drawing.Point(103, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 124);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grouped Radio Buttons";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RdoYellow2
            // 
            this.RdoYellow2.AutoSize = true;
            this.RdoYellow2.Location = new System.Drawing.Point(47, 88);
            this.RdoYellow2.Name = "RdoYellow2";
            this.RdoYellow2.Size = new System.Drawing.Size(56, 17);
            this.RdoYellow2.TabIndex = 9;
            this.RdoYellow2.Text = "Yellow";
            this.RdoYellow2.UseVisualStyleBackColor = true;
            this.RdoYellow2.CheckedChanged += new System.EventHandler(this.RdoYellow2_CheckedChanged);
            // 
            // RdoBlue2
            // 
            this.RdoBlue2.AutoSize = true;
            this.RdoBlue2.Location = new System.Drawing.Point(47, 65);
            this.RdoBlue2.Name = "RdoBlue2";
            this.RdoBlue2.Size = new System.Drawing.Size(46, 17);
            this.RdoBlue2.TabIndex = 8;
            this.RdoBlue2.TabStop = true;
            this.RdoBlue2.Text = "Blue";
            this.RdoBlue2.UseVisualStyleBackColor = true;
            this.RdoBlue2.CheckedChanged += new System.EventHandler(this.RdoBlue2_CheckedChanged);
            // 
            // RdoGreen2
            // 
            this.RdoGreen2.AutoSize = true;
            this.RdoGreen2.Location = new System.Drawing.Point(47, 42);
            this.RdoGreen2.Name = "RdoGreen2";
            this.RdoGreen2.Size = new System.Drawing.Size(54, 17);
            this.RdoGreen2.TabIndex = 7;
            this.RdoGreen2.TabStop = true;
            this.RdoGreen2.Text = "Green";
            this.RdoGreen2.UseVisualStyleBackColor = true;
            this.RdoGreen2.CheckedChanged += new System.EventHandler(this.RdoGreen2_CheckedChanged);
            // 
            // RdoRed2
            // 
            this.RdoRed2.AutoSize = true;
            this.RdoRed2.Location = new System.Drawing.Point(47, 19);
            this.RdoRed2.Name = "RdoRed2";
            this.RdoRed2.Size = new System.Drawing.Size(45, 17);
            this.RdoRed2.TabIndex = 6;
            this.RdoRed2.TabStop = true;
            this.RdoRed2.Text = "Red";
            this.RdoRed2.UseVisualStyleBackColor = true;
            this.RdoRed2.CheckedChanged += new System.EventHandler(this.RdoRed2_CheckedChanged);
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rdoYellow);
            this.Controls.Add(this.rdoBlue);
            this.Controls.Add(this.rdoGreen);
            this.Controls.Add(this.rdoRed);
            this.Controls.Add(this.btnReset);
            this.Name = "frmRadio";
            this.Text = "Radio Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoYellow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoYellow2;
        private System.Windows.Forms.RadioButton RdoBlue2;
        private System.Windows.Forms.RadioButton RdoGreen2;
        private System.Windows.Forms.RadioButton RdoRed2;
    }
}