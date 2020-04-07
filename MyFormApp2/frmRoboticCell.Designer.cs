namespace IE322_App_KAU
{
    partial class frmRoboticCell
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
            this.PnlPlayArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PnlPlayArea
            // 
            this.PnlPlayArea.Location = new System.Drawing.Point(104, 12);
            this.PnlPlayArea.Name = "PnlPlayArea";
            this.PnlPlayArea.Size = new System.Drawing.Size(665, 417);
            this.PnlPlayArea.TabIndex = 0;
            this.PnlPlayArea.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlPlayArea_Paint);
            this.PnlPlayArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlPlayArea_Click);
            // 
            // frmRoboticCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlPlayArea);
            this.Name = "frmRoboticCell";
            this.Text = "Robotic Cell";
            this.Load += new System.EventHandler(this.frmRoboticCell_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPlayArea;
    }
}