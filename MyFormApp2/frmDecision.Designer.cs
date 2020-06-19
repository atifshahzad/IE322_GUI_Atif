namespace IE322_App_KAU
{
    partial class frmDecision
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
            this.BtnIfElseifElse = new System.Windows.Forms.Button();
            this.BtnSolveSwitch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.RdoRemainder = new System.Windows.Forms.RadioButton();
            this.RdoDivide = new System.Windows.Forms.RadioButton();
            this.RdoMultiply = new System.Windows.Forms.RadioButton();
            this.RdoSubtract = new System.Windows.Forms.RadioButton();
            this.RdoAdd = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmbAnimal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAnimalType = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnIfElseifElse
            // 
            this.BtnIfElseifElse.Location = new System.Drawing.Point(6, 132);
            this.BtnIfElseifElse.Name = "BtnIfElseifElse";
            this.BtnIfElseifElse.Size = new System.Drawing.Size(101, 44);
            this.BtnIfElseifElse.TabIndex = 0;
            this.BtnIfElseifElse.Text = "if..elseif..else Compare a and b";
            this.BtnIfElseifElse.UseVisualStyleBackColor = true;
            this.BtnIfElseifElse.Click += new System.EventHandler(this.BtnIfElseifElse_Click);
            // 
            // BtnSolveSwitch
            // 
            this.BtnSolveSwitch.Location = new System.Drawing.Point(138, 134);
            this.BtnSolveSwitch.Name = "BtnSolveSwitch";
            this.BtnSolveSwitch.Size = new System.Drawing.Size(101, 44);
            this.BtnSolveSwitch.TabIndex = 1;
            this.BtnSolveSwitch.Text = "Solve";
            this.BtnSolveSwitch.UseVisualStyleBackColor = true;
            this.BtnSolveSwitch.Click += new System.EventHandler(this.BtnAnimalType_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnIfElseifElse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtB);
            this.groupBox1.Controls.Add(this.BtnSolveSwitch);
            this.groupBox1.Controls.Add(this.TxtA);
            this.groupBox1.Controls.Add(this.RdoRemainder);
            this.groupBox1.Controls.Add(this.RdoDivide);
            this.groupBox1.Controls.Add(this.RdoMultiply);
            this.groupBox1.Controls.Add(this.RdoSubtract);
            this.groupBox1.Controls.Add(this.RdoAdd);
            this.groupBox1.Location = new System.Drawing.Point(32, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "switch_Math Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "a";
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(41, 62);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(100, 20);
            this.TxtB.TabIndex = 1;
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(41, 36);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(100, 20);
            this.TxtA.TabIndex = 1;
            // 
            // RdoRemainder
            // 
            this.RdoRemainder.AutoSize = true;
            this.RdoRemainder.Location = new System.Drawing.Point(163, 111);
            this.RdoRemainder.Name = "RdoRemainder";
            this.RdoRemainder.Size = new System.Drawing.Size(76, 17);
            this.RdoRemainder.TabIndex = 0;
            this.RdoRemainder.TabStop = true;
            this.RdoRemainder.Text = "Remainder";
            this.RdoRemainder.UseVisualStyleBackColor = true;
            // 
            // RdoDivide
            // 
            this.RdoDivide.AutoSize = true;
            this.RdoDivide.Location = new System.Drawing.Point(163, 88);
            this.RdoDivide.Name = "RdoDivide";
            this.RdoDivide.Size = new System.Drawing.Size(55, 17);
            this.RdoDivide.TabIndex = 0;
            this.RdoDivide.TabStop = true;
            this.RdoDivide.Text = "Divide";
            this.RdoDivide.UseVisualStyleBackColor = true;
            // 
            // RdoMultiply
            // 
            this.RdoMultiply.AutoSize = true;
            this.RdoMultiply.Location = new System.Drawing.Point(163, 65);
            this.RdoMultiply.Name = "RdoMultiply";
            this.RdoMultiply.Size = new System.Drawing.Size(60, 17);
            this.RdoMultiply.TabIndex = 0;
            this.RdoMultiply.TabStop = true;
            this.RdoMultiply.Text = "Multiply";
            this.RdoMultiply.UseVisualStyleBackColor = true;
            // 
            // RdoSubtract
            // 
            this.RdoSubtract.AutoSize = true;
            this.RdoSubtract.Location = new System.Drawing.Point(163, 42);
            this.RdoSubtract.Name = "RdoSubtract";
            this.RdoSubtract.Size = new System.Drawing.Size(65, 17);
            this.RdoSubtract.TabIndex = 0;
            this.RdoSubtract.TabStop = true;
            this.RdoSubtract.Text = "Subtract";
            this.RdoSubtract.UseVisualStyleBackColor = true;
            // 
            // RdoAdd
            // 
            this.RdoAdd.AutoSize = true;
            this.RdoAdd.Location = new System.Drawing.Point(163, 19);
            this.RdoAdd.Name = "RdoAdd";
            this.RdoAdd.Size = new System.Drawing.Size(44, 17);
            this.RdoAdd.TabIndex = 0;
            this.RdoAdd.TabStop = true;
            this.RdoAdd.Text = "Add";
            this.RdoAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmbAnimal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BtnAnimalType);
            this.groupBox2.Location = new System.Drawing.Point(32, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "switch example";
            // 
            // CmbAnimal
            // 
            this.CmbAnimal.FormattingEnabled = true;
            this.CmbAnimal.Items.AddRange(new object[] {
            "dog",
            "crocodile",
            "tortoise",
            "snake"});
            this.CmbAnimal.Location = new System.Drawing.Point(131, 19);
            this.CmbAnimal.Name = "CmbAnimal";
            this.CmbAnimal.Size = new System.Drawing.Size(121, 21);
            this.CmbAnimal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select an animal:";
            // 
            // BtnAnimalType
            // 
            this.BtnAnimalType.Location = new System.Drawing.Point(13, 50);
            this.BtnAnimalType.Name = "BtnAnimalType";
            this.BtnAnimalType.Size = new System.Drawing.Size(101, 44);
            this.BtnAnimalType.TabIndex = 1;
            this.BtnAnimalType.Text = "Animal type";
            this.BtnAnimalType.UseVisualStyleBackColor = true;
            this.BtnAnimalType.Click += new System.EventHandler(this.BtnAnimalType_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(693, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmDecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDecision";
            this.Text = "frmDecision";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnIfElseifElse;
        private System.Windows.Forms.Button BtnSolveSwitch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.RadioButton RdoRemainder;
        private System.Windows.Forms.RadioButton RdoDivide;
        private System.Windows.Forms.RadioButton RdoMultiply;
        private System.Windows.Forms.RadioButton RdoSubtract;
        private System.Windows.Forms.RadioButton RdoAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAnimalType;
        private System.Windows.Forms.ComboBox CmbAnimal;
        private System.Windows.Forms.Button btnBack;
    }
}