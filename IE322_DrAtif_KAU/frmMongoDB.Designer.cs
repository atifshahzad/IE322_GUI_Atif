namespace IE322_App_KAU
{
    partial class frmMongoDB
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.LblDispaly = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(65, 74);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // LblDispaly
            // 
            this.LblDispaly.AutoSize = true;
            this.LblDispaly.Location = new System.Drawing.Point(189, 74);
            this.LblDispaly.Name = "LblDispaly";
            this.LblDispaly.Size = new System.Drawing.Size(35, 13);
            this.LblDispaly.TabIndex = 1;
            this.LblDispaly.Text = "label1";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(702, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmMongoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.LblDispaly);
            this.Controls.Add(this.BtnConnect);
            this.Name = "frmMongoDB";
            this.Text = "frmMongoDB";
            this.Load += new System.EventHandler(this.frmMongoDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label LblDispaly;
        private System.Windows.Forms.Button btnBack;
    }
}