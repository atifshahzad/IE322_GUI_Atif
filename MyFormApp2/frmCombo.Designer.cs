namespace IE322_App_KAU
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
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.BtnShowSelected1 = new System.Windows.Forms.Button();
            this.BtnShowSelected2 = new System.Windows.Forms.Button();
            this.BtnRemoveByIndex = new System.Windows.Forms.Button();
            this.BtnRemoveByName = new System.Windows.Forms.Button();
            this.BtnRemoveLast = new System.Windows.Forms.Button();
            this.BtnRemove2ndLast = new System.Windows.Forms.Button();
            this.BtnShowSelected3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(16, 93);
            this.CmbDays.Margin = new System.Windows.Forms.Padding(4);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(163, 24);
            this.CmbDays.TabIndex = 0;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.cmbDays_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(335, 276);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BtnShowSelected1
            // 
            this.BtnShowSelected1.Location = new System.Drawing.Point(16, 15);
            this.BtnShowSelected1.Margin = new System.Windows.Forms.Padding(4);
            this.BtnShowSelected1.Name = "BtnShowSelected1";
            this.BtnShowSelected1.Size = new System.Drawing.Size(127, 47);
            this.BtnShowSelected1.TabIndex = 3;
            this.BtnShowSelected1.Text = "Show Selected Method1";
            this.BtnShowSelected1.UseVisualStyleBackColor = true;
            this.BtnShowSelected1.Click += new System.EventHandler(this.BtnShowSelected1_Click);
            // 
            // BtnShowSelected2
            // 
            this.BtnShowSelected2.Location = new System.Drawing.Point(137, 15);
            this.BtnShowSelected2.Margin = new System.Windows.Forms.Padding(4);
            this.BtnShowSelected2.Name = "BtnShowSelected2";
            this.BtnShowSelected2.Size = new System.Drawing.Size(119, 47);
            this.BtnShowSelected2.TabIndex = 5;
            this.BtnShowSelected2.Text = "Show Selected Method2";
            this.BtnShowSelected2.UseVisualStyleBackColor = true;
            this.BtnShowSelected2.Click += new System.EventHandler(this.BtnShowSelected2_Click);
            // 
            // BtnRemoveByIndex
            // 
            this.BtnRemoveByIndex.Location = new System.Drawing.Point(16, 206);
            this.BtnRemoveByIndex.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRemoveByIndex.Name = "BtnRemoveByIndex";
            this.BtnRemoveByIndex.Size = new System.Drawing.Size(100, 49);
            this.BtnRemoveByIndex.TabIndex = 6;
            this.BtnRemoveByIndex.Text = "Remove by Index";
            this.BtnRemoveByIndex.UseVisualStyleBackColor = true;
            this.BtnRemoveByIndex.Click += new System.EventHandler(this.btnRemoveByIndex_Click);
            // 
            // BtnRemoveByName
            // 
            this.BtnRemoveByName.Location = new System.Drawing.Point(137, 206);
            this.BtnRemoveByName.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRemoveByName.Name = "BtnRemoveByName";
            this.BtnRemoveByName.Size = new System.Drawing.Size(100, 49);
            this.BtnRemoveByName.TabIndex = 7;
            this.BtnRemoveByName.Text = "Remove by Name";
            this.BtnRemoveByName.UseVisualStyleBackColor = true;
            this.BtnRemoveByName.Click += new System.EventHandler(this.btnRemoveByName_Click);
            // 
            // BtnRemoveLast
            // 
            this.BtnRemoveLast.Location = new System.Drawing.Point(349, 73);
            this.BtnRemoveLast.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRemoveLast.Name = "BtnRemoveLast";
            this.BtnRemoveLast.Size = new System.Drawing.Size(103, 80);
            this.BtnRemoveLast.TabIndex = 8;
            this.BtnRemoveLast.Text = "Remove last item";
            this.BtnRemoveLast.UseVisualStyleBackColor = true;
            this.BtnRemoveLast.Click += new System.EventHandler(this.BtnRemoveLast_Click);
            // 
            // BtnRemove2ndLast
            // 
            this.BtnRemove2ndLast.Location = new System.Drawing.Point(349, 161);
            this.BtnRemove2ndLast.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRemove2ndLast.Name = "BtnRemove2ndLast";
            this.BtnRemove2ndLast.Size = new System.Drawing.Size(103, 80);
            this.BtnRemove2ndLast.TabIndex = 9;
            this.BtnRemove2ndLast.Text = "Remove 2nd last item";
            this.BtnRemove2ndLast.UseVisualStyleBackColor = true;
            this.BtnRemove2ndLast.Click += new System.EventHandler(this.BtnRemove2ndLast_Click);
            // 
            // BtnShowSelected3
            // 
            this.BtnShowSelected3.Location = new System.Drawing.Point(255, 15);
            this.BtnShowSelected3.Margin = new System.Windows.Forms.Padding(4);
            this.BtnShowSelected3.Name = "BtnShowSelected3";
            this.BtnShowSelected3.Size = new System.Drawing.Size(119, 47);
            this.BtnShowSelected3.TabIndex = 5;
            this.BtnShowSelected3.Text = "Show Selected Method3";
            this.BtnShowSelected3.UseVisualStyleBackColor = true;
            this.BtnShowSelected3.Click += new System.EventHandler(this.BtnShowSelected3_Click);
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 319);
            this.Controls.Add(this.BtnRemove2ndLast);
            this.Controls.Add(this.BtnRemoveLast);
            this.Controls.Add(this.BtnRemoveByName);
            this.Controls.Add(this.BtnRemoveByIndex);
            this.Controls.Add(this.BtnShowSelected3);
            this.Controls.Add(this.BtnShowSelected2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.BtnShowSelected1);
            this.Controls.Add(this.CmbDays);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCombo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button BtnShowSelected1;
        private System.Windows.Forms.Button BtnShowSelected2;
        private System.Windows.Forms.Button BtnRemoveByIndex;
        private System.Windows.Forms.Button BtnRemoveByName;
        private System.Windows.Forms.Button BtnRemoveLast;
        private System.Windows.Forms.Button BtnRemove2ndLast;
        private System.Windows.Forms.Button BtnShowSelected3;
    }
}