namespace IE322_App_KAU
{
    partial class frmSystem
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
            this.BtnSystemInfo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LstDisplay = new System.Windows.Forms.ListBox();
            this.LblCapacity = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(683, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BtnSystemInfo
            // 
            this.BtnSystemInfo.Location = new System.Drawing.Point(35, 34);
            this.BtnSystemInfo.Name = "BtnSystemInfo";
            this.BtnSystemInfo.Size = new System.Drawing.Size(98, 55);
            this.BtnSystemInfo.TabIndex = 7;
            this.BtnSystemInfo.Text = "System Info";
            this.BtnSystemInfo.UseVisualStyleBackColor = true;
            this.BtnSystemInfo.Click += new System.EventHandler(this.BtnSystemInfo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.LstDisplay);
            this.groupBox2.Controls.Add(this.LblCapacity);
            this.groupBox2.Controls.Add(this.LblInfo);
            this.groupBox2.Location = new System.Drawing.Point(169, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 305);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display";
            // 
            // LstDisplay
            // 
            this.LstDisplay.FormattingEnabled = true;
            this.LstDisplay.Location = new System.Drawing.Point(21, 19);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(122, 264);
            this.LstDisplay.TabIndex = 0;
            // 
            // LblCapacity
            // 
            this.LblCapacity.AutoSize = true;
            this.LblCapacity.Location = new System.Drawing.Point(149, 278);
            this.LblCapacity.Name = "LblCapacity";
            this.LblCapacity.Size = new System.Drawing.Size(51, 13);
            this.LblCapacity.TabIndex = 2;
            this.LblCapacity.Text = "Capacity:";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(149, 19);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(38, 13);
            this.LblInfo.TabIndex = 2;
            this.LblInfo.Text = "Count:";
            // 
            // frmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnSystemInfo);
            this.Controls.Add(this.btnBack);
            this.Name = "frmSystem";
            this.Text = "frmSystem";
            this.Load += new System.EventHandler(this.frmSystem_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button BtnSystemInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox LstDisplay;
        private System.Windows.Forms.Label LblCapacity;
        private System.Windows.Forms.Label LblInfo;
    }
}