namespace IE322_App_KAU
{
    partial class frmABC
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
            this.BtnSolve = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.grpABC = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbQty = new System.Windows.Forms.ComboBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.cmbCost = new System.Windows.Forms.ComboBox();
            this.cmbValue = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.grpABC.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSolve
            // 
            this.BtnSolve.Location = new System.Drawing.Point(713, 52);
            this.BtnSolve.Name = "BtnSolve";
            this.BtnSolve.Size = new System.Drawing.Size(75, 23);
            this.BtnSolve.TabIndex = 0;
            this.BtnSolve.Text = "Solve";
            this.BtnSolve.UseVisualStyleBackColor = true;
            this.BtnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(713, 96);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 0;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // grpABC
            // 
            this.grpABC.Controls.Add(this.lblTotalValue);
            this.grpABC.Controls.Add(this.lblTotalQty);
            this.grpABC.Controls.Add(this.lblCount);
            this.grpABC.Controls.Add(this.label7);
            this.grpABC.Controls.Add(this.label4);
            this.grpABC.Controls.Add(this.label5);
            this.grpABC.Controls.Add(this.label6);
            this.grpABC.Controls.Add(this.cmbValue);
            this.grpABC.Controls.Add(this.cmbQty);
            this.grpABC.Controls.Add(this.cmbItem);
            this.grpABC.Controls.Add(this.cmbCost);
            this.grpABC.Location = new System.Drawing.Point(27, 52);
            this.grpABC.Name = "grpABC";
            this.grpABC.Size = new System.Drawing.Size(643, 183);
            this.grpABC.TabIndex = 4;
            this.grpABC.TabStop = false;
            this.grpABC.Text = "ABC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Consumption Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Item";
            // 
            // cmbQty
            // 
            this.cmbQty.FormattingEnabled = true;
            this.cmbQty.Location = new System.Drawing.Point(330, 55);
            this.cmbQty.Name = "cmbQty";
            this.cmbQty.Size = new System.Drawing.Size(121, 21);
            this.cmbQty.TabIndex = 2;
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(29, 55);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(121, 21);
            this.cmbItem.TabIndex = 3;
            // 
            // cmbCost
            // 
            this.cmbCost.FormattingEnabled = true;
            this.cmbCost.Location = new System.Drawing.Point(178, 55);
            this.cmbCost.Name = "cmbCost";
            this.cmbCost.Size = new System.Drawing.Size(121, 21);
            this.cmbCost.TabIndex = 1;
            // 
            // cmbValue
            // 
            this.cmbValue.FormattingEnabled = true;
            this.cmbValue.Location = new System.Drawing.Point(472, 55);
            this.cmbValue.Name = "cmbValue";
            this.cmbValue.Size = new System.Drawing.Size(121, 21);
            this.cmbValue.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Consumption Value";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(713, 212);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(29, 102);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "0";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Location = new System.Drawing.Point(327, 102);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(13, 13);
            this.lblTotalQty.TabIndex = 5;
            this.lblTotalQty.Text = "0";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(469, 102);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(13, 13);
            this.lblTotalValue.TabIndex = 5;
            this.lblTotalValue.Text = "0";
            // 
            // frmABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 253);
            this.Controls.Add(this.grpABC);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSolve);
            this.Name = "frmABC";
            this.Text = "ABC Analysis";
            this.grpABC.ResumeLayout(false);
            this.grpABC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSolve;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.GroupBox grpABC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbValue;
        private System.Windows.Forms.ComboBox cmbQty;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.ComboBox cmbCost;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label lblCount;
    }
}