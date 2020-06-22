namespace IE322_App_KAU
{
    partial class frmLoops
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
            this.BtnNestedForLoop = new System.Windows.Forms.Button();
            this.LblDisplay = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.BtnBreak1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnContinue1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnContinueNested = new System.Windows.Forms.Button();
            this.BtnBreakNested = new System.Windows.Forms.Button();
            this.BtnWhile1 = new System.Windows.Forms.Button();
            this.BtnWhile2 = new System.Windows.Forms.Button();
            this.BtnDoWhile1 = new System.Windows.Forms.Button();
            this.BtnForLoop1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNestedForLoop
            // 
            this.BtnNestedForLoop.Location = new System.Drawing.Point(22, 28);
            this.BtnNestedForLoop.Name = "BtnNestedForLoop";
            this.BtnNestedForLoop.Size = new System.Drawing.Size(102, 32);
            this.BtnNestedForLoop.TabIndex = 7;
            this.BtnNestedForLoop.Text = "Nested for loop";
            this.BtnNestedForLoop.UseVisualStyleBackColor = true;
            this.BtnNestedForLoop.Click += new System.EventHandler(this.BtnNestedForLoop_Click);
            // 
            // LblDisplay
            // 
            this.LblDisplay.AutoSize = true;
            this.LblDisplay.Location = new System.Drawing.Point(263, 28);
            this.LblDisplay.Name = "LblDisplay";
            this.LblDisplay.Size = new System.Drawing.Size(44, 13);
            this.LblDisplay.TabIndex = 8;
            this.LblDisplay.Text = "Display:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(635, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BtnBreak1
            // 
            this.BtnBreak1.Location = new System.Drawing.Point(16, 19);
            this.BtnBreak1.Name = "BtnBreak1";
            this.BtnBreak1.Size = new System.Drawing.Size(114, 40);
            this.BtnBreak1.TabIndex = 10;
            this.BtnBreak1.Text = "Break Statement";
            this.BtnBreak1.UseVisualStyleBackColor = true;
            this.BtnBreak1.Click += new System.EventHandler(this.BtnBreak1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnContinueNested);
            this.groupBox1.Controls.Add(this.BtnBreakNested);
            this.groupBox1.Controls.Add(this.BtnContinue1);
            this.groupBox1.Controls.Add(this.BtnBreak1);
            this.groupBox1.Location = new System.Drawing.Point(453, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 201);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jump Statements";
            // 
            // BtnContinue1
            // 
            this.BtnContinue1.Location = new System.Drawing.Point(16, 57);
            this.BtnContinue1.Name = "BtnContinue1";
            this.BtnContinue1.Size = new System.Drawing.Size(114, 40);
            this.BtnContinue1.TabIndex = 11;
            this.BtnContinue1.Text = "Continue Statement";
            this.BtnContinue1.UseVisualStyleBackColor = true;
            this.BtnContinue1.Click += new System.EventHandler(this.BtnContinue1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnForLoop1);
            this.groupBox2.Location = new System.Drawing.Point(25, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "for loop";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnWhile2);
            this.groupBox3.Controls.Add(this.BtnWhile1);
            this.groupBox3.Location = new System.Drawing.Point(25, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "while loop";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnDoWhile1);
            this.groupBox4.Location = new System.Drawing.Point(25, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "do while loop";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnNestedForLoop);
            this.groupBox5.Location = new System.Drawing.Point(510, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "nesting of loops";
            // 
            // BtnContinueNested
            // 
            this.BtnContinueNested.Location = new System.Drawing.Point(137, 57);
            this.BtnContinueNested.Name = "BtnContinueNested";
            this.BtnContinueNested.Size = new System.Drawing.Size(114, 40);
            this.BtnContinueNested.TabIndex = 13;
            this.BtnContinueNested.Text = "Continue in nested loops";
            this.BtnContinueNested.UseVisualStyleBackColor = true;
            this.BtnContinueNested.Click += new System.EventHandler(this.BtnContinueNested_Click);
            // 
            // BtnBreakNested
            // 
            this.BtnBreakNested.Location = new System.Drawing.Point(137, 19);
            this.BtnBreakNested.Name = "BtnBreakNested";
            this.BtnBreakNested.Size = new System.Drawing.Size(114, 40);
            this.BtnBreakNested.TabIndex = 12;
            this.BtnBreakNested.Text = "Break from nested loops";
            this.BtnBreakNested.UseVisualStyleBackColor = true;
            this.BtnBreakNested.Click += new System.EventHandler(this.BtnBreakNested_Click);
            // 
            // BtnWhile1
            // 
            this.BtnWhile1.Location = new System.Drawing.Point(6, 19);
            this.BtnWhile1.Name = "BtnWhile1";
            this.BtnWhile1.Size = new System.Drawing.Size(110, 23);
            this.BtnWhile1.TabIndex = 0;
            this.BtnWhile1.Text = "while loop simple";
            this.BtnWhile1.UseVisualStyleBackColor = true;
            this.BtnWhile1.Click += new System.EventHandler(this.BtnWhile1_Click);
            // 
            // BtnWhile2
            // 
            this.BtnWhile2.Location = new System.Drawing.Point(6, 48);
            this.BtnWhile2.Name = "BtnWhile2";
            this.BtnWhile2.Size = new System.Drawing.Size(110, 23);
            this.BtnWhile2.TabIndex = 1;
            this.BtnWhile2.Text = "while loop short";
            this.BtnWhile2.UseVisualStyleBackColor = true;
            this.BtnWhile2.Click += new System.EventHandler(this.BtnWhile2_Click);
            // 
            // BtnDoWhile1
            // 
            this.BtnDoWhile1.Location = new System.Drawing.Point(6, 19);
            this.BtnDoWhile1.Name = "BtnDoWhile1";
            this.BtnDoWhile1.Size = new System.Drawing.Size(110, 23);
            this.BtnDoWhile1.TabIndex = 2;
            this.BtnDoWhile1.Text = "do while loop simple";
            this.BtnDoWhile1.UseVisualStyleBackColor = true;
            this.BtnDoWhile1.Click += new System.EventHandler(this.BtnDoWhile1_Click);
            // 
            // BtnForLoop1
            // 
            this.BtnForLoop1.Location = new System.Drawing.Point(6, 19);
            this.BtnForLoop1.Name = "BtnForLoop1";
            this.BtnForLoop1.Size = new System.Drawing.Size(110, 23);
            this.BtnForLoop1.TabIndex = 3;
            this.BtnForLoop1.Text = "for loop simple";
            this.BtnForLoop1.UseVisualStyleBackColor = true;
            this.BtnForLoop1.Click += new System.EventHandler(this.BtnForLoop1_Click);
            // 
            // frmLoops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.LblDisplay);
            this.Name = "frmLoops";
            this.Text = "Loops";
            this.Load += new System.EventHandler(this.frmLoops_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNestedForLoop;
        private System.Windows.Forms.Label LblDisplay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button BtnBreak1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnContinue1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnContinueNested;
        private System.Windows.Forms.Button BtnBreakNested;
        private System.Windows.Forms.Button BtnWhile1;
        private System.Windows.Forms.Button BtnWhile2;
        private System.Windows.Forms.Button BtnForLoop1;
        private System.Windows.Forms.Button BtnDoWhile1;
    }
}