namespace IE322_App_KAU
{
    partial class frmTalk
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
            this.BtnAli = new System.Windows.Forms.Button();
            this.BtnJulia = new System.Windows.Forms.Button();
            this.BtnTalk = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAli
            // 
            this.BtnAli.Location = new System.Drawing.Point(52, 42);
            this.BtnAli.Name = "BtnAli";
            this.BtnAli.Size = new System.Drawing.Size(120, 46);
            this.BtnAli.TabIndex = 0;
            this.BtnAli.Text = "Ali";
            this.BtnAli.UseVisualStyleBackColor = true;
            this.BtnAli.Click += new System.EventHandler(this.BtnAli_Click);
            // 
            // BtnJulia
            // 
            this.BtnJulia.Location = new System.Drawing.Point(195, 42);
            this.BtnJulia.Name = "BtnJulia";
            this.BtnJulia.Size = new System.Drawing.Size(120, 46);
            this.BtnJulia.TabIndex = 0;
            this.BtnJulia.Text = "Julia";
            this.BtnJulia.UseVisualStyleBackColor = true;
            this.BtnJulia.Click += new System.EventHandler(this.BtnJulia_Click);
            // 
            // BtnTalk
            // 
            this.BtnTalk.Location = new System.Drawing.Point(116, 123);
            this.BtnTalk.Name = "BtnTalk";
            this.BtnTalk.Size = new System.Drawing.Size(120, 46);
            this.BtnTalk.TabIndex = 0;
            this.BtnTalk.Text = "Talk";
            this.BtnTalk.UseVisualStyleBackColor = true;
            this.BtnTalk.Click += new System.EventHandler(this.BtnTalk_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(602, 181);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmTalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 232);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.BtnTalk);
            this.Controls.Add(this.BtnJulia);
            this.Controls.Add(this.BtnAli);
            this.Name = "frmTalk";
            this.Text = "frmTalk";
            this.Load += new System.EventHandler(this.frmTalk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAli;
        private System.Windows.Forms.Button BtnJulia;
        private System.Windows.Forms.Button BtnTalk;
        private System.Windows.Forms.Button btnBack;
    }
}