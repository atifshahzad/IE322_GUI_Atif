namespace IE322_App_KAU
{
    partial class frmRandomCombo
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnProblem1 = new System.Windows.Forms.Button();
            this.rdoGreater = new System.Windows.Forms.RadioButton();
            this.rdoLess = new System.Windows.Forms.RadioButton();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.cmbRandom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblCount2 = new System.Windows.Forms.Label();
            this.rdoGreater2 = new System.Windows.Forms.RadioButton();
            this.rdoLess2 = new System.Windows.Forms.RadioButton();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.cmbRandom2 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnReset3 = new System.Windows.Forms.Button();
            this.CmbColor = new System.Windows.Forms.ComboBox();
            this.BtnGenerateColor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(114, 136);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(71, 27);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(613, 286);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(59, 22);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnProblem1);
            this.groupBox1.Controls.Add(this.rdoGreater);
            this.groupBox1.Controls.Add(this.rdoLess);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.BtnGenerate);
            this.groupBox1.Controls.Add(this.cmbRandom);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(11, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(216, 197);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz03_AAF19";
            // 
            // BtnProblem1
            // 
            this.BtnProblem1.Location = new System.Drawing.Point(16, 103);
            this.BtnProblem1.Name = "BtnProblem1";
            this.BtnProblem1.Size = new System.Drawing.Size(80, 60);
            this.BtnProblem1.TabIndex = 8;
            this.BtnProblem1.Text = "Problem Description";
            this.BtnProblem1.UseVisualStyleBackColor = true;
            this.BtnProblem1.Click += new System.EventHandler(this.Problem1_Click);
            // 
            // rdoGreater
            // 
            this.rdoGreater.AutoSize = true;
            this.rdoGreater.Location = new System.Drawing.Point(106, 102);
            this.rdoGreater.Margin = new System.Windows.Forms.Padding(2);
            this.rdoGreater.Name = "rdoGreater";
            this.rdoGreater.Size = new System.Drawing.Size(108, 17);
            this.rdoGreater.TabIndex = 7;
            this.rdoGreater.TabStop = true;
            this.rdoGreater.Text = "Greater than 500";
            this.rdoGreater.UseVisualStyleBackColor = true;
            // 
            // rdoLess
            // 
            this.rdoLess.AutoSize = true;
            this.rdoLess.Location = new System.Drawing.Point(104, 80);
            this.rdoLess.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLess.Name = "rdoLess";
            this.rdoLess.Size = new System.Drawing.Size(92, 17);
            this.rdoLess.TabIndex = 6;
            this.rdoLess.TabStop = true;
            this.rdoLess.Text = "Less than 500";
            this.rdoLess.UseVisualStyleBackColor = true;
            this.rdoLess.CheckedChanged += new System.EventHandler(this.rdoLess_CheckedChanged);
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(106, 35);
            this.BtnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(89, 29);
            this.BtnGenerate.TabIndex = 5;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // cmbRandom
            // 
            this.cmbRandom.FormattingEnabled = true;
            this.cmbRandom.Location = new System.Drawing.Point(4, 35);
            this.cmbRandom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRandom.Name = "cmbRandom";
            this.cmbRandom.Size = new System.Drawing.Size(92, 21);
            this.cmbRandom.TabIndex = 4;
            this.cmbRandom.SelectedIndexChanged += new System.EventHandler(this.cmbRandom_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblCount2);
            this.groupBox2.Controls.Add(this.rdoGreater2);
            this.groupBox2.Controls.Add(this.rdoLess2);
            this.groupBox2.Controls.Add(this.btnReset2);
            this.groupBox2.Controls.Add(this.BtnGenerate2);
            this.groupBox2.Controls.Add(this.cmbRandom2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(231, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(216, 197);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quiz03_EAF19";
            // 
            // LblCount2
            // 
            this.LblCount2.AutoSize = true;
            this.LblCount2.Location = new System.Drawing.Point(4, 68);
            this.LblCount2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCount2.Name = "LblCount2";
            this.LblCount2.Size = new System.Drawing.Size(40, 13);
            this.LblCount2.TabIndex = 8;
            this.LblCount2.Text = "Count:";
            // 
            // rdoGreater2
            // 
            this.rdoGreater2.AutoSize = true;
            this.rdoGreater2.Location = new System.Drawing.Point(106, 102);
            this.rdoGreater2.Margin = new System.Windows.Forms.Padding(2);
            this.rdoGreater2.Name = "rdoGreater2";
            this.rdoGreater2.Size = new System.Drawing.Size(102, 17);
            this.rdoGreater2.TabIndex = 7;
            this.rdoGreater2.TabStop = true;
            this.rdoGreater2.Text = "Greater than 50";
            this.rdoGreater2.UseVisualStyleBackColor = true;
            // 
            // rdoLess2
            // 
            this.rdoLess2.AutoSize = true;
            this.rdoLess2.Location = new System.Drawing.Point(104, 80);
            this.rdoLess2.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLess2.Name = "rdoLess2";
            this.rdoLess2.Size = new System.Drawing.Size(86, 17);
            this.rdoLess2.TabIndex = 6;
            this.rdoLess2.TabStop = true;
            this.rdoLess2.Text = "Less than 50";
            this.rdoLess2.UseVisualStyleBackColor = true;
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(114, 136);
            this.btnReset2.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(71, 27);
            this.btnReset2.TabIndex = 4;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.Location = new System.Drawing.Point(106, 35);
            this.BtnGenerate2.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(89, 29);
            this.BtnGenerate2.TabIndex = 5;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = true;
            this.BtnGenerate2.Click += new System.EventHandler(this.BtnGenerate2_Click);
            // 
            // cmbRandom2
            // 
            this.cmbRandom2.FormattingEnabled = true;
            this.cmbRandom2.Location = new System.Drawing.Point(4, 35);
            this.cmbRandom2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRandom2.Name = "cmbRandom2";
            this.cmbRandom2.Size = new System.Drawing.Size(92, 21);
            this.cmbRandom2.TabIndex = 4;
            this.cmbRandom2.SelectedIndexChanged += new System.EventHandler(this.cmbRandom2_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnReset3);
            this.groupBox3.Controls.Add(this.CmbColor);
            this.groupBox3.Controls.Add(this.BtnGenerateColor);
            this.groupBox3.Location = new System.Drawing.Point(452, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 197);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quiz_BAS22";
            // 
            // BtnReset3
            // 
            this.BtnReset3.Location = new System.Drawing.Point(161, 136);
            this.BtnReset3.Name = "BtnReset3";
            this.BtnReset3.Size = new System.Drawing.Size(75, 25);
            this.BtnReset3.TabIndex = 2;
            this.BtnReset3.Text = "Reset";
            this.BtnReset3.UseVisualStyleBackColor = true;
            this.BtnReset3.Click += new System.EventHandler(this.BtnReset3_Click);
            // 
            // CmbColor
            // 
            this.CmbColor.FormattingEnabled = true;
            this.CmbColor.Location = new System.Drawing.Point(14, 35);
            this.CmbColor.Name = "CmbColor";
            this.CmbColor.Size = new System.Drawing.Size(146, 21);
            this.CmbColor.TabIndex = 1;
            this.CmbColor.SelectedIndexChanged += new System.EventHandler(this.CmbColor_SelectedIndexChanged);
            // 
            // BtnGenerateColor
            // 
            this.BtnGenerateColor.Location = new System.Drawing.Point(161, 77);
            this.BtnGenerateColor.Name = "BtnGenerateColor";
            this.BtnGenerateColor.Size = new System.Drawing.Size(75, 42);
            this.BtnGenerateColor.TabIndex = 0;
            this.BtnGenerateColor.Text = "Generate Color";
            this.BtnGenerateColor.UseVisualStyleBackColor = true;
            this.BtnGenerateColor.Click += new System.EventHandler(this.BtnGenerateColor_Click);
            // 
            // frmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 366);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRandomCombo";
            this.Text = "RandomCombo";
            this.Load += new System.EventHandler(this.frmRandomCombo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button BtnBack;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoGreater;
        private System.Windows.Forms.RadioButton rdoLess;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.ComboBox cmbRandom;
        private System.Windows.Forms.Button BtnProblem1;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoGreater2;
        private System.Windows.Forms.RadioButton rdoLess2;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.ComboBox cmbRandom2;
        private System.Windows.Forms.Label LblCount2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnReset3;
        private System.Windows.Forms.ComboBox CmbColor;
        private System.Windows.Forms.Button BtnGenerateColor;
    }
}