namespace IE322_App_KAU
{
    partial class frmEvents
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnClickEvents = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkDrag = new System.Windows.Forms.CheckBox();
            this.BtnDrag = new System.Windows.Forms.Button();
            this.LblDrag = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(454, 370);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnClickEvents
            // 
            this.BtnClickEvents.Location = new System.Drawing.Point(12, 12);
            this.BtnClickEvents.Name = "BtnClickEvents";
            this.BtnClickEvents.Size = new System.Drawing.Size(165, 116);
            this.BtnClickEvents.TabIndex = 1;
            this.BtnClickEvents.Text = "Click Events";
            this.BtnClickEvents.UseVisualStyleBackColor = true;
            this.BtnClickEvents.Click += new System.EventHandler(this.BtnClickEvents_Click);
            this.BtnClickEvents.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnClickEvents_MouseDown);
            this.BtnClickEvents.MouseEnter += new System.EventHandler(this.BtnClickEvents_MouseEnter);
            this.BtnClickEvents.MouseHover += new System.EventHandler(this.BtnClickEvents_MouseHover);
            this.BtnClickEvents.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnClickEvents_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblDrag);
            this.groupBox1.Controls.Add(this.ChkDrag);
            this.groupBox1.Controls.Add(this.BtnDrag);
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 253);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draggable";
            // 
            // ChkDrag
            // 
            this.ChkDrag.AutoSize = true;
            this.ChkDrag.Location = new System.Drawing.Point(153, 33);
            this.ChkDrag.Name = "ChkDrag";
            this.ChkDrag.Size = new System.Drawing.Size(85, 17);
            this.ChkDrag.TabIndex = 1;
            this.ChkDrag.Text = "Enable Drag";
            this.ChkDrag.UseVisualStyleBackColor = true;
            this.ChkDrag.CheckedChanged += new System.EventHandler(this.ChkDrag_CheckedChanged);
            // 
            // BtnDrag
            // 
            this.BtnDrag.Location = new System.Drawing.Point(18, 29);
            this.BtnDrag.Name = "BtnDrag";
            this.BtnDrag.Size = new System.Drawing.Size(75, 23);
            this.BtnDrag.TabIndex = 0;
            this.BtnDrag.Text = " Drag Me";
            this.BtnDrag.UseVisualStyleBackColor = true;
            // 
            // LblDrag
            // 
            this.LblDrag.AutoSize = true;
            this.LblDrag.Location = new System.Drawing.Point(6, 213);
            this.LblDrag.Name = "LblDrag";
            this.LblDrag.Size = new System.Drawing.Size(174, 13);
            this.LblDrag.TabIndex = 2;
            this.LblDrag.Text = "To make these controls draggable, ";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(357, 370);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "Reset Form";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // frmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnClickEvents);
            this.Controls.Add(this.BtnBack);
            this.Name = "frmEvents";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.frmEvents_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnClickEvents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkDrag;
        private System.Windows.Forms.Button BtnDrag;
        private System.Windows.Forms.Label LblDrag;
        private System.Windows.Forms.Button BtnReset;
    }
}