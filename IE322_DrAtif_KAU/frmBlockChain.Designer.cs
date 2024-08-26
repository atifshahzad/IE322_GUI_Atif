namespace IE322_App_KAU
{
    partial class frmBlockChain
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
            this.BtnCreateBC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnValidateBC = new System.Windows.Forms.Button();
            this.BtnDisplayBC = new System.Windows.Forms.Button();
            this.LstDispBC = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCreateBC
            // 
            this.BtnCreateBC.Location = new System.Drawing.Point(6, 19);
            this.BtnCreateBC.Name = "BtnCreateBC";
            this.BtnCreateBC.Size = new System.Drawing.Size(116, 33);
            this.BtnCreateBC.TabIndex = 0;
            this.BtnCreateBC.Text = "Create BlockChain";
            this.BtnCreateBC.UseVisualStyleBackColor = true;
            this.BtnCreateBC.Click += new System.EventHandler(this.BtnCreateBC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDisplayBC);
            this.groupBox1.Controls.Add(this.BtnValidateBC);
            this.groupBox1.Controls.Add(this.BtnCreateBC);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coffee Tracker";
            // 
            // BtnValidateBC
            // 
            this.BtnValidateBC.Location = new System.Drawing.Point(6, 58);
            this.BtnValidateBC.Name = "BtnValidateBC";
            this.BtnValidateBC.Size = new System.Drawing.Size(116, 33);
            this.BtnValidateBC.TabIndex = 1;
            this.BtnValidateBC.Text = "Validate BlockChain";
            this.BtnValidateBC.UseVisualStyleBackColor = true;
            this.BtnValidateBC.Click += new System.EventHandler(this.BtnValidateBC_Click);
            // 
            // BtnDisplayBC
            // 
            this.BtnDisplayBC.Location = new System.Drawing.Point(6, 97);
            this.BtnDisplayBC.Name = "BtnDisplayBC";
            this.BtnDisplayBC.Size = new System.Drawing.Size(116, 33);
            this.BtnDisplayBC.TabIndex = 2;
            this.BtnDisplayBC.Text = "Display BlockChain";
            this.BtnDisplayBC.UseVisualStyleBackColor = true;
            this.BtnDisplayBC.Click += new System.EventHandler(this.BtnDisplayBC_Click);
            // 
            // LstDispBC
            // 
            this.LstDispBC.FormattingEnabled = true;
            this.LstDispBC.Location = new System.Drawing.Point(26, 183);
            this.LstDispBC.Name = "LstDispBC";
            this.LstDispBC.Size = new System.Drawing.Size(762, 212);
            this.LstDispBC.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(194, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coffee Tracker";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Display BlockChain";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 33);
            this.button3.TabIndex = 1;
            this.button3.Text = "Validate BlockChain";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 33);
            this.button4.TabIndex = 0;
            this.button4.Text = "Create BlockChain";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Location = new System.Drawing.Point(375, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 151);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coffee Tracker";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 33);
            this.button5.TabIndex = 2;
            this.button5.Text = "Display BlockChain";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 58);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 33);
            this.button6.TabIndex = 1;
            this.button6.Text = "Validate BlockChain";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 33);
            this.button7.TabIndex = 0;
            this.button7.Text = "Create BlockChain";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // frmBlockChain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LstDispBC);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBlockChain";
            this.Text = "BlockChain Examples";
            this.Load += new System.EventHandler(this.frmBlockChain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateBC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDisplayBC;
        private System.Windows.Forms.Button BtnValidateBC;
        private System.Windows.Forms.ListBox LstDispBC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}