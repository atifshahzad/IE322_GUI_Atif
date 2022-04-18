namespace IE322_App_KAU
{
    partial class frmFSM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCurrentState = new System.Windows.Forms.Button();
            this.BtnPlugIn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCurrentState);
            this.groupBox1.Location = new System.Drawing.Point(34, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnCurrentState
            // 
            this.BtnCurrentState.Location = new System.Drawing.Point(18, 30);
            this.BtnCurrentState.Name = "BtnCurrentState";
            this.BtnCurrentState.Size = new System.Drawing.Size(112, 33);
            this.BtnCurrentState.TabIndex = 0;
            this.BtnCurrentState.Text = "Current State";
            this.BtnCurrentState.UseVisualStyleBackColor = true;
            this.BtnCurrentState.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPlugIn
            // 
            this.BtnPlugIn.Location = new System.Drawing.Point(32, 19);
            this.BtnPlugIn.Name = "BtnPlugIn";
            this.BtnPlugIn.Size = new System.Drawing.Size(75, 23);
            this.BtnPlugIn.TabIndex = 1;
            this.BtnPlugIn.Text = "BtnPlugin";
            this.BtnPlugIn.UseVisualStyleBackColor = true;
            this.BtnPlugIn.Click += new System.EventHandler(this.BtnPlugIn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnPlugIn);
            this.groupBox2.Location = new System.Drawing.Point(34, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // frmFSM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFSM";
            this.Text = "Finite State Machines";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCurrentState;
        private System.Windows.Forms.Button BtnPlugIn;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}