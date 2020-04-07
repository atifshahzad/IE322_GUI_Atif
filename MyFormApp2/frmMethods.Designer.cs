namespace IE322_App_KAU
{
    partial class frmMethods
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
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCheckBalance = new System.Windows.Forms.Button();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(57, 106);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(95, 28);
            this.BtnCalculate.TabIndex = 0;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtB);
            this.groupBox1.Controls.Add(this.BtnCalculate);
            this.groupBox1.Controls.Add(this.TxtA);
            this.groupBox1.Location = new System.Drawing.Point(41, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator using Methods";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a";
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(57, 63);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(100, 20);
            this.TxtB.TabIndex = 0;
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(57, 28);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(100, 20);
            this.TxtA.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCheckBalance);
            this.groupBox2.Controls.Add(this.BtnWithdraw);
            this.groupBox2.Controls.Add(this.BtnDeposit);
            this.groupBox2.Location = new System.Drawing.Point(302, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 231);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IE Bank";
            // 
            // BtnCheckBalance
            // 
            this.BtnCheckBalance.Location = new System.Drawing.Point(145, 106);
            this.BtnCheckBalance.Name = "BtnCheckBalance";
            this.BtnCheckBalance.Size = new System.Drawing.Size(75, 23);
            this.BtnCheckBalance.TabIndex = 0;
            this.BtnCheckBalance.Text = "Check Balance";
            this.BtnCheckBalance.UseVisualStyleBackColor = true;
            this.BtnCheckBalance.Click += new System.EventHandler(this.BtnCheckBalance_Click);
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.Location = new System.Drawing.Point(145, 60);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.BtnWithdraw.TabIndex = 0;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseVisualStyleBackColor = true;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.Location = new System.Drawing.Point(145, 23);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(75, 23);
            this.BtnDeposit.TabIndex = 0;
            this.BtnDeposit.Text = "Deposit";
            this.BtnDeposit.UseVisualStyleBackColor = true;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(687, 400);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMethods";
            this.Text = "Methods";
            this.Load += new System.EventHandler(this.frmMethods_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCheckBalance;
        private System.Windows.Forms.Button BtnWithdraw;
        private System.Windows.Forms.Button BtnDeposit;
        private System.Windows.Forms.Button btnBack;
    }
}