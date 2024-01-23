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
            this.BtnRemoveSelectedItem = new System.Windows.Forms.Button();
            this.GrpComboExp1 = new System.Windows.Forms.GroupBox();
            this.LblSelected = new System.Windows.Forms.Label();
            this.LblCount = new System.Windows.Forms.Label();
            this.GrpComboExp2 = new System.Windows.Forms.GroupBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.PicDraw = new System.Windows.Forms.PictureBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.CmbColors = new System.Windows.Forms.ComboBox();
            this.GrpComboExp1.SuspendLayout();
            this.GrpComboExp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(125, 200);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(166, 21);
            this.CmbDays.TabIndex = 0;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.cmbDays_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(672, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BtnShowSelected1
            // 
            this.BtnShowSelected1.Location = new System.Drawing.Point(0, 19);
            this.BtnShowSelected1.Name = "BtnShowSelected1";
            this.BtnShowSelected1.Size = new System.Drawing.Size(95, 38);
            this.BtnShowSelected1.TabIndex = 3;
            this.BtnShowSelected1.Text = "Show Selected Method1";
            this.BtnShowSelected1.UseVisualStyleBackColor = true;
            this.BtnShowSelected1.Click += new System.EventHandler(this.BtnShowSelected1_Click);
            // 
            // BtnShowSelected2
            // 
            this.BtnShowSelected2.Location = new System.Drawing.Point(107, 19);
            this.BtnShowSelected2.Name = "BtnShowSelected2";
            this.BtnShowSelected2.Size = new System.Drawing.Size(89, 38);
            this.BtnShowSelected2.TabIndex = 5;
            this.BtnShowSelected2.Text = "Show Selected Method2";
            this.BtnShowSelected2.UseVisualStyleBackColor = true;
            this.BtnShowSelected2.Click += new System.EventHandler(this.BtnShowSelected2_Click);
            // 
            // BtnRemoveByIndex
            // 
            this.BtnRemoveByIndex.Location = new System.Drawing.Point(0, 66);
            this.BtnRemoveByIndex.Name = "BtnRemoveByIndex";
            this.BtnRemoveByIndex.Size = new System.Drawing.Size(95, 40);
            this.BtnRemoveByIndex.TabIndex = 6;
            this.BtnRemoveByIndex.Text = "Remove by Index";
            this.BtnRemoveByIndex.UseVisualStyleBackColor = true;
            this.BtnRemoveByIndex.Click += new System.EventHandler(this.btnRemoveByIndex_Click);
            // 
            // BtnRemoveByName
            // 
            this.BtnRemoveByName.Location = new System.Drawing.Point(107, 66);
            this.BtnRemoveByName.Name = "BtnRemoveByName";
            this.BtnRemoveByName.Size = new System.Drawing.Size(89, 40);
            this.BtnRemoveByName.TabIndex = 7;
            this.BtnRemoveByName.Text = "Remove by Name";
            this.BtnRemoveByName.UseVisualStyleBackColor = true;
            this.BtnRemoveByName.Click += new System.EventHandler(this.btnRemoveByName_Click);
            // 
            // BtnRemoveLast
            // 
            this.BtnRemoveLast.Location = new System.Drawing.Point(0, 112);
            this.BtnRemoveLast.Name = "BtnRemoveLast";
            this.BtnRemoveLast.Size = new System.Drawing.Size(132, 53);
            this.BtnRemoveLast.TabIndex = 8;
            this.BtnRemoveLast.Text = "Remove last item";
            this.BtnRemoveLast.UseVisualStyleBackColor = true;
            this.BtnRemoveLast.Click += new System.EventHandler(this.BtnRemoveLast_Click);
            // 
            // BtnRemove2ndLast
            // 
            this.BtnRemove2ndLast.Location = new System.Drawing.Point(160, 112);
            this.BtnRemove2ndLast.Name = "BtnRemove2ndLast";
            this.BtnRemove2ndLast.Size = new System.Drawing.Size(131, 53);
            this.BtnRemove2ndLast.TabIndex = 9;
            this.BtnRemove2ndLast.Text = "Remove 2nd last item";
            this.BtnRemove2ndLast.UseVisualStyleBackColor = true;
            this.BtnRemove2ndLast.Click += new System.EventHandler(this.BtnRemove2ndLast_Click);
            // 
            // BtnShowSelected3
            // 
            this.BtnShowSelected3.Location = new System.Drawing.Point(202, 19);
            this.BtnShowSelected3.Name = "BtnShowSelected3";
            this.BtnShowSelected3.Size = new System.Drawing.Size(89, 38);
            this.BtnShowSelected3.TabIndex = 5;
            this.BtnShowSelected3.Text = "Show Selected Method3";
            this.BtnShowSelected3.UseVisualStyleBackColor = true;
            this.BtnShowSelected3.Click += new System.EventHandler(this.BtnShowSelected3_Click);
            // 
            // BtnRemoveSelectedItem
            // 
            this.BtnRemoveSelectedItem.Location = new System.Drawing.Point(202, 66);
            this.BtnRemoveSelectedItem.Name = "BtnRemoveSelectedItem";
            this.BtnRemoveSelectedItem.Size = new System.Drawing.Size(89, 40);
            this.BtnRemoveSelectedItem.TabIndex = 10;
            this.BtnRemoveSelectedItem.Text = "Remove Selected Item";
            this.BtnRemoveSelectedItem.UseVisualStyleBackColor = true;
            this.BtnRemoveSelectedItem.Click += new System.EventHandler(this.BtnRemoveSelectedItem_Click);
            // 
            // GrpComboExp1
            // 
            this.GrpComboExp1.Controls.Add(this.LblSelected);
            this.GrpComboExp1.Controls.Add(this.LblCount);
            this.GrpComboExp1.Controls.Add(this.BtnShowSelected3);
            this.GrpComboExp1.Controls.Add(this.BtnRemove2ndLast);
            this.GrpComboExp1.Controls.Add(this.CmbDays);
            this.GrpComboExp1.Controls.Add(this.BtnRemoveSelectedItem);
            this.GrpComboExp1.Controls.Add(this.BtnRemoveLast);
            this.GrpComboExp1.Controls.Add(this.BtnShowSelected2);
            this.GrpComboExp1.Controls.Add(this.BtnRemoveByIndex);
            this.GrpComboExp1.Controls.Add(this.BtnRemoveByName);
            this.GrpComboExp1.Controls.Add(this.BtnShowSelected1);
            this.GrpComboExp1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GrpComboExp1.Location = new System.Drawing.Point(12, 12);
            this.GrpComboExp1.Name = "GrpComboExp1";
            this.GrpComboExp1.Size = new System.Drawing.Size(297, 236);
            this.GrpComboExp1.TabIndex = 11;
            this.GrpComboExp1.TabStop = false;
            this.GrpComboExp1.Text = "Example1:";
            // 
            // LblSelected
            // 
            this.LblSelected.AutoSize = true;
            this.LblSelected.Location = new System.Drawing.Point(6, 168);
            this.LblSelected.Name = "LblSelected";
            this.LblSelected.Size = new System.Drawing.Size(100, 13);
            this.LblSelected.TabIndex = 12;
            this.LblSelected.Text = "Currently Selected:";
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(157, 168);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(131, 13);
            this.LblCount.TabIndex = 11;
            this.LblCount.Text = "Current Number of Items:";
            // 
            // GrpComboExp2
            // 
            this.GrpComboExp2.Controls.Add(this.BtnClear);
            this.GrpComboExp2.Controls.Add(this.PicDraw);
            this.GrpComboExp2.Controls.Add(this.BtnDraw);
            this.GrpComboExp2.Controls.Add(this.CmbColors);
            this.GrpComboExp2.ForeColor = System.Drawing.Color.Brown;
            this.GrpComboExp2.Location = new System.Drawing.Point(357, 12);
            this.GrpComboExp2.Name = "GrpComboExp2";
            this.GrpComboExp2.Size = new System.Drawing.Size(273, 236);
            this.GrpComboExp2.TabIndex = 12;
            this.GrpComboExp2.TabStop = false;
            this.GrpComboExp2.Text = "Eample 2:";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(216, 19);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(51, 22);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // PicDraw
            // 
            this.PicDraw.Location = new System.Drawing.Point(6, 47);
            this.PicDraw.Name = "PicDraw";
            this.PicDraw.Size = new System.Drawing.Size(261, 134);
            this.PicDraw.TabIndex = 2;
            this.PicDraw.TabStop = false;
            // 
            // BtnDraw
            // 
            this.BtnDraw.Location = new System.Drawing.Point(6, 19);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(47, 22);
            this.BtnDraw.TabIndex = 1;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // CmbColors
            // 
            this.CmbColors.FormattingEnabled = true;
            this.CmbColors.Location = new System.Drawing.Point(101, 200);
            this.CmbColors.Name = "CmbColors";
            this.CmbColors.Size = new System.Drawing.Size(166, 21);
            this.CmbColors.TabIndex = 0;
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 351);
            this.Controls.Add(this.GrpComboExp2);
            this.Controls.Add(this.GrpComboExp1);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCombo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.frmCombo_Load);
            this.GrpComboExp1.ResumeLayout(false);
            this.GrpComboExp1.PerformLayout();
            this.GrpComboExp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button BtnShowSelected1;
        private System.Windows.Forms.Button BtnShowSelected2;
        private System.Windows.Forms.Button BtnShowSelected3;
        private System.Windows.Forms.Button BtnRemoveByIndex;
        private System.Windows.Forms.Button BtnRemoveByName;
        private System.Windows.Forms.Button BtnRemoveLast;
        private System.Windows.Forms.Button BtnRemove2ndLast;
        private System.Windows.Forms.Button BtnRemoveSelectedItem;
        private System.Windows.Forms.GroupBox GrpComboExp1;
        private System.Windows.Forms.GroupBox GrpComboExp2;
        private System.Windows.Forms.ComboBox CmbColors;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.PictureBox PicDraw;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Label LblSelected;
    }
}
