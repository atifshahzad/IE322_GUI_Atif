
namespace IE322_Shaker
{
    partial class frmCombo
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
            this.BtnShowSelected1 = new System.Windows.Forms.Button();
            this.BtnShowSelected2 = new System.Windows.Forms.Button();
            this.BtnShowSelected3 = new System.Windows.Forms.Button();
            this.BtnRemoveLast = new System.Windows.Forms.Button();
            this.BtnRemove2ndLast = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.BtnRemoveByName = new System.Windows.Forms.Button();
            this.BtnRemoveByIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShowSelected1
            // 
            this.BtnShowSelected1.Location = new System.Drawing.Point(12, 12);
            this.BtnShowSelected1.Name = "BtnShowSelected1";
            this.BtnShowSelected1.Size = new System.Drawing.Size(133, 61);
            this.BtnShowSelected1.TabIndex = 0;
            this.BtnShowSelected1.Text = "Show Selected Method1";
            this.BtnShowSelected1.UseVisualStyleBackColor = true;
            this.BtnShowSelected1.Click += new System.EventHandler(this.BtnShowSelected1_Click);
            // 
            // BtnShowSelected2
            // 
            this.BtnShowSelected2.Location = new System.Drawing.Point(151, 12);
            this.BtnShowSelected2.Name = "BtnShowSelected2";
            this.BtnShowSelected2.Size = new System.Drawing.Size(135, 61);
            this.BtnShowSelected2.TabIndex = 1;
            this.BtnShowSelected2.Text = "Show Selected Method2";
            this.BtnShowSelected2.UseVisualStyleBackColor = true;
            this.BtnShowSelected2.Click += new System.EventHandler(this.BtnShowSelected2_Click);
            // 
            // BtnShowSelected3
            // 
            this.BtnShowSelected3.Location = new System.Drawing.Point(292, 12);
            this.BtnShowSelected3.Name = "BtnShowSelected3";
            this.BtnShowSelected3.Size = new System.Drawing.Size(155, 61);
            this.BtnShowSelected3.TabIndex = 2;
            this.BtnShowSelected3.Text = "Show Selected Method3";
            this.BtnShowSelected3.UseVisualStyleBackColor = true;
            this.BtnShowSelected3.Click += new System.EventHandler(this.BtnShowSelected3_Click);
            // 
            // BtnRemoveLast
            // 
            this.BtnRemoveLast.Location = new System.Drawing.Point(599, 162);
            this.BtnRemoveLast.Name = "BtnRemoveLast";
            this.BtnRemoveLast.Size = new System.Drawing.Size(133, 33);
            this.BtnRemoveLast.TabIndex = 3;
            this.BtnRemoveLast.Text = "Remove last item ";
            this.BtnRemoveLast.UseVisualStyleBackColor = true;
            this.BtnRemoveLast.Click += new System.EventHandler(this.BtnRemoveLast_Click);
            // 
            // BtnRemove2ndLast
            // 
            this.BtnRemove2ndLast.Location = new System.Drawing.Point(599, 232);
            this.BtnRemove2ndLast.Name = "BtnRemove2ndLast";
            this.BtnRemove2ndLast.Size = new System.Drawing.Size(133, 31);
            this.BtnRemove2ndLast.TabIndex = 4;
            this.BtnRemove2ndLast.Text = "Remove 2nd last item ";
            this.BtnRemove2ndLast.UseVisualStyleBackColor = true;
            this.BtnRemove2ndLast.Click += new System.EventHandler(this.BtnRemove2ndLast_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(622, 378);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(43, 137);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(121, 24);
            this.CmbDays.TabIndex = 6;
            // 
            // BtnRemoveByName
            // 
            this.BtnRemoveByName.Location = new System.Drawing.Point(160, 299);
            this.BtnRemoveByName.Name = "BtnRemoveByName";
            this.BtnRemoveByName.Size = new System.Drawing.Size(136, 39);
            this.BtnRemoveByName.TabIndex = 7;
            this.BtnRemoveByName.Text = "Remove by Name ";
            this.BtnRemoveByName.UseVisualStyleBackColor = true;
            this.BtnRemoveByName.Click += new System.EventHandler(this.BtnRemoveByName_Click);
            // 
            // BtnRemoveByIndex
            // 
            this.BtnRemoveByIndex.Location = new System.Drawing.Point(12, 299);
            this.BtnRemoveByIndex.Name = "BtnRemoveByIndex";
            this.BtnRemoveByIndex.Size = new System.Drawing.Size(133, 39);
            this.BtnRemoveByIndex.TabIndex = 8;
            this.BtnRemoveByIndex.Text = "Remove by index ";
            this.BtnRemoveByIndex.UseVisualStyleBackColor = true;
            this.BtnRemoveByIndex.Click += new System.EventHandler(this.BtnRemoveByIndex_Click);
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRemoveByIndex);
            this.Controls.Add(this.BtnRemoveByName);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRemove2ndLast);
            this.Controls.Add(this.BtnRemoveLast);
            this.Controls.Add(this.BtnShowSelected3);
            this.Controls.Add(this.BtnShowSelected2);
            this.Controls.Add(this.BtnShowSelected1);
            this.Name = "frmCombo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.frmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShowSelected1;
        private System.Windows.Forms.Button BtnShowSelected2;
        private System.Windows.Forms.Button BtnShowSelected3;
        private System.Windows.Forms.Button BtnRemoveLast;
        private System.Windows.Forms.Button BtnRemove2ndLast;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button BtnRemoveByName;
        private System.Windows.Forms.Button BtnRemoveByIndex;
    }
}