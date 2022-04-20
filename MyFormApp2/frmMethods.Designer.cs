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
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.BtnCheckBalance = new System.Windows.Forms.Button();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnPrintSign = new System.Windows.Forms.Button();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.BtnPrintMax = new System.Windows.Forms.Button();
            this.BtnAdd54 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.BtnGeneratePronic = new System.Windows.Forms.Button();
            this.BtnArgByRef = new System.Windows.Forms.Button();
            this.BtnArgByVal = new System.Windows.Forms.Button();
            this.PassArg_out = new System.Windows.Forms.Button();
            this.BtnMultOutput = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(22, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 185);
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
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtBalance);
            this.groupBox2.Controls.Add(this.TxtAmount);
            this.groupBox2.Controls.Add(this.BtnCheckBalance);
            this.groupBox2.Controls.Add(this.BtnWithdraw);
            this.groupBox2.Controls.Add(this.BtnDeposit);
            this.groupBox2.Location = new System.Drawing.Point(225, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IE Bank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Balance:";
            // 
            // TxtBalance
            // 
            this.TxtBalance.Location = new System.Drawing.Point(120, 19);
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.Size = new System.Drawing.Size(100, 20);
            this.TxtBalance.TabIndex = 2;
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(28, 90);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(100, 20);
            this.TxtAmount.TabIndex = 2;
            // 
            // BtnCheckBalance
            // 
            this.BtnCheckBalance.Location = new System.Drawing.Point(145, 150);
            this.BtnCheckBalance.Name = "BtnCheckBalance";
            this.BtnCheckBalance.Size = new System.Drawing.Size(75, 23);
            this.BtnCheckBalance.TabIndex = 0;
            this.BtnCheckBalance.Text = "Check Balance";
            this.BtnCheckBalance.UseVisualStyleBackColor = true;
            this.BtnCheckBalance.Click += new System.EventHandler(this.BtnCheckBalance_Click);
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.Location = new System.Drawing.Point(145, 111);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.BtnWithdraw.TabIndex = 0;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseVisualStyleBackColor = true;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.Location = new System.Drawing.Point(145, 66);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.BtnPrintSign);
            this.groupBox3.Controls.Add(this.TxtNumber);
            this.groupBox3.Location = new System.Drawing.Point(22, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Print Sign Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "a";
            // 
            // BtnPrintSign
            // 
            this.BtnPrintSign.Location = new System.Drawing.Point(35, 54);
            this.BtnPrintSign.Name = "BtnPrintSign";
            this.BtnPrintSign.Size = new System.Drawing.Size(100, 28);
            this.BtnPrintSign.TabIndex = 0;
            this.BtnPrintSign.Text = "PrintSign Method";
            this.BtnPrintSign.UseVisualStyleBackColor = true;
            this.BtnPrintSign.Click += new System.EventHandler(this.BtnPrintSign_Click);
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(35, 28);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(100, 20);
            this.TxtNumber.TabIndex = 0;
            // 
            // BtnPrintMax
            // 
            this.BtnPrintMax.Location = new System.Drawing.Point(22, 48);
            this.BtnPrintMax.Name = "BtnPrintMax";
            this.BtnPrintMax.Size = new System.Drawing.Size(75, 26);
            this.BtnPrintMax.TabIndex = 2;
            this.BtnPrintMax.Text = "PrintMax Method";
            this.BtnPrintMax.UseVisualStyleBackColor = true;
            this.BtnPrintMax.Click += new System.EventHandler(this.BtnPrintMax_Click);
            // 
            // BtnAdd54
            // 
            this.BtnAdd54.Location = new System.Drawing.Point(22, 12);
            this.BtnAdd54.Name = "BtnAdd54";
            this.BtnAdd54.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd54.TabIndex = 4;
            this.BtnAdd54.Text = "Add 5+4";
            this.BtnAdd54.UseVisualStyleBackColor = true;
            this.BtnAdd54.Click += new System.EventHandler(this.BtnAdd54_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstDisplay);
            this.groupBox4.Controls.Add(this.BtnGeneratePronic);
            this.groupBox4.Location = new System.Drawing.Point(225, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 175);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pronic Numbers";
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(125, 12);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(87, 147);
            this.lstDisplay.TabIndex = 6;
            // 
            // BtnGeneratePronic
            // 
            this.BtnGeneratePronic.Location = new System.Drawing.Point(6, 19);
            this.BtnGeneratePronic.Name = "BtnGeneratePronic";
            this.BtnGeneratePronic.Size = new System.Drawing.Size(113, 23);
            this.BtnGeneratePronic.TabIndex = 0;
            this.BtnGeneratePronic.Text = "Generate Pronic";
            this.BtnGeneratePronic.UseVisualStyleBackColor = true;
            this.BtnGeneratePronic.Click += new System.EventHandler(this.BtnGeneratePronic_Click);
            // 
            // BtnArgByRef
            // 
            this.BtnArgByRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnArgByRef.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnArgByRef.ForeColor = System.Drawing.Color.Red;
            this.BtnArgByRef.Location = new System.Drawing.Point(479, 72);
            this.BtnArgByRef.Name = "BtnArgByRef";
            this.BtnArgByRef.Size = new System.Drawing.Size(115, 34);
            this.BtnArgByRef.TabIndex = 15;
            this.BtnArgByRef.Text = "Passing argument by ref";
            this.BtnArgByRef.UseVisualStyleBackColor = false;
            this.BtnArgByRef.Click += new System.EventHandler(this.BtnArgByRef_Click);
            // 
            // BtnArgByVal
            // 
            this.BtnArgByVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnArgByVal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnArgByVal.ForeColor = System.Drawing.Color.Red;
            this.BtnArgByVal.Location = new System.Drawing.Point(479, 31);
            this.BtnArgByVal.Name = "BtnArgByVal";
            this.BtnArgByVal.Size = new System.Drawing.Size(115, 34);
            this.BtnArgByVal.TabIndex = 16;
            this.BtnArgByVal.Text = "Passing argument by val";
            this.BtnArgByVal.UseVisualStyleBackColor = false;
            this.BtnArgByVal.Click += new System.EventHandler(this.BtnArgByVal_Click);
            // 
            // PassArg_out
            // 
            this.PassArg_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PassArg_out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PassArg_out.ForeColor = System.Drawing.Color.Red;
            this.PassArg_out.Location = new System.Drawing.Point(479, 140);
            this.PassArg_out.Name = "PassArg_out";
            this.PassArg_out.Size = new System.Drawing.Size(115, 34);
            this.PassArg_out.TabIndex = 17;
            this.PassArg_out.Text = "Passing argument as output parameter";
            this.PassArg_out.UseVisualStyleBackColor = false;
            this.PassArg_out.Click += new System.EventHandler(this.PassArg_out_Click);
            // 
            // BtnMultOutput
            // 
            this.BtnMultOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnMultOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMultOutput.ForeColor = System.Drawing.Color.Red;
            this.BtnMultOutput.Location = new System.Drawing.Point(479, 180);
            this.BtnMultOutput.Name = "BtnMultOutput";
            this.BtnMultOutput.Size = new System.Drawing.Size(115, 34);
            this.BtnMultOutput.TabIndex = 18;
            this.BtnMultOutput.Text = "Multiple outputs";
            this.BtnMultOutput.UseVisualStyleBackColor = false;
            this.BtnMultOutput.Click += new System.EventHandler(this.BtnMultOutput_Click);
            // 
            // frmMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMultOutput);
            this.Controls.Add(this.PassArg_out);
            this.Controls.Add(this.BtnArgByVal);
            this.Controls.Add(this.BtnArgByRef);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BtnAdd54);
            this.Controls.Add(this.BtnPrintMax);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMethods";
            this.Text = "Methods";
            this.Load += new System.EventHandler(this.frmMethods_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnPrintSign;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Button BtnPrintMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBalance;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Button BtnAdd54;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnGeneratePronic;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button BtnArgByRef;
        private System.Windows.Forms.Button BtnArgByVal;
        private System.Windows.Forms.Button PassArg_out;
        private System.Windows.Forms.Button BtnMultOutput;
    }
}