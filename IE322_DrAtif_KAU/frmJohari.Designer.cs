namespace IE322_App_KAU
{
    partial class frmJohari
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
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMeByYou = new System.Windows.Forms.ComboBox();
            this.cmbMeNotByYou = new System.Windows.Forms.ComboBox();
            this.cmbMeNotByMe = new System.Windows.Forms.ComboBox();
            this.cmbMeByMe = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMystery = new System.Windows.Forms.Label();
            this.lblFacade = new System.Windows.Forms.Label();
            this.lblBlind = new System.Windows.Forms.Label();
            this.lblArena = new System.Windows.Forms.Label();
            this.cmbMystery = new System.Windows.Forms.ComboBox();
            this.cmbFacade = new System.Windows.Forms.ComboBox();
            this.cmbBlind = new System.Windows.Forms.ComboBox();
            this.cmbArena = new System.Windows.Forms.ComboBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblYou = new System.Windows.Forms.Label();
            this.lblMe = new System.Windows.Forms.Label();
            this.rdoYou = new System.Windows.Forms.RadioButton();
            this.rdoMe = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpControl
            // 
            this.grpControl.Location = new System.Drawing.Point(307, 35);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(481, 394);
            this.grpControl.TabIndex = 0;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "Attributes";
            this.grpControl.Enter += new System.EventHandler(this.grpControl_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMeByYou);
            this.groupBox1.Controls.Add(this.cmbMeNotByYou);
            this.groupBox1.Controls.Add(this.cmbMeNotByMe);
            this.groupBox1.Controls.Add(this.cmbMeByMe);
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // cmbMeByYou
            // 
            this.cmbMeByYou.BackColor = System.Drawing.Color.Violet;
            this.cmbMeByYou.ForeColor = System.Drawing.Color.Yellow;
            this.cmbMeByYou.FormattingEnabled = true;
            this.cmbMeByYou.Location = new System.Drawing.Point(6, 69);
            this.cmbMeByYou.Name = "cmbMeByYou";
            this.cmbMeByYou.Size = new System.Drawing.Size(103, 21);
            this.cmbMeByYou.TabIndex = 3;
            // 
            // cmbMeNotByYou
            // 
            this.cmbMeNotByYou.FormattingEnabled = true;
            this.cmbMeNotByYou.Location = new System.Drawing.Point(132, 69);
            this.cmbMeNotByYou.Name = "cmbMeNotByYou";
            this.cmbMeNotByYou.Size = new System.Drawing.Size(103, 21);
            this.cmbMeNotByYou.TabIndex = 2;
            // 
            // cmbMeNotByMe
            // 
            this.cmbMeNotByMe.FormattingEnabled = true;
            this.cmbMeNotByMe.Location = new System.Drawing.Point(132, 22);
            this.cmbMeNotByMe.Name = "cmbMeNotByMe";
            this.cmbMeNotByMe.Size = new System.Drawing.Size(103, 21);
            this.cmbMeNotByMe.TabIndex = 1;
            // 
            // cmbMeByMe
            // 
            this.cmbMeByMe.BackColor = System.Drawing.Color.Coral;
            this.cmbMeByMe.ForeColor = System.Drawing.Color.Yellow;
            this.cmbMeByMe.FormattingEnabled = true;
            this.cmbMeByMe.Location = new System.Drawing.Point(6, 22);
            this.cmbMeByMe.Name = "cmbMeByMe";
            this.cmbMeByMe.Size = new System.Drawing.Size(103, 21);
            this.cmbMeByMe.TabIndex = 0;
            this.cmbMeByMe.SelectedIndexChanged += new System.EventHandler(this.cmbMeByMe_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMystery);
            this.groupBox2.Controls.Add(this.lblFacade);
            this.groupBox2.Controls.Add(this.lblBlind);
            this.groupBox2.Controls.Add(this.lblArena);
            this.groupBox2.Controls.Add(this.cmbMystery);
            this.groupBox2.Controls.Add(this.cmbFacade);
            this.groupBox2.Controls.Add(this.cmbBlind);
            this.groupBox2.Controls.Add(this.cmbArena);
            this.groupBox2.Location = new System.Drawing.Point(22, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 110);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // lblMystery
            // 
            this.lblMystery.AutoSize = true;
            this.lblMystery.Location = new System.Drawing.Point(129, 89);
            this.lblMystery.Name = "lblMystery";
            this.lblMystery.Size = new System.Drawing.Size(79, 13);
            this.lblMystery.TabIndex = 12;
            this.lblMystery.Text = "0 in MYSTERY";
            // 
            // lblFacade
            // 
            this.lblFacade.AutoSize = true;
            this.lblFacade.Location = new System.Drawing.Point(6, 89);
            this.lblFacade.Name = "lblFacade";
            this.lblFacade.Size = new System.Drawing.Size(69, 13);
            this.lblFacade.TabIndex = 11;
            this.lblFacade.Text = "0 in FACADE";
            // 
            // lblBlind
            // 
            this.lblBlind.AutoSize = true;
            this.lblBlind.Location = new System.Drawing.Point(129, 46);
            this.lblBlind.Name = "lblBlind";
            this.lblBlind.Size = new System.Drawing.Size(59, 13);
            this.lblBlind.TabIndex = 10;
            this.lblBlind.Text = "0 in BLIND";
            // 
            // lblArena
            // 
            this.lblArena.AutoSize = true;
            this.lblArena.Location = new System.Drawing.Point(6, 46);
            this.lblArena.Name = "lblArena";
            this.lblArena.Size = new System.Drawing.Size(64, 13);
            this.lblArena.TabIndex = 9;
            this.lblArena.Text = "0 in ARENA";
            // 
            // cmbMystery
            // 
            this.cmbMystery.FormattingEnabled = true;
            this.cmbMystery.Location = new System.Drawing.Point(132, 65);
            this.cmbMystery.Name = "cmbMystery";
            this.cmbMystery.Size = new System.Drawing.Size(103, 21);
            this.cmbMystery.TabIndex = 3;
            // 
            // cmbFacade
            // 
            this.cmbFacade.FormattingEnabled = true;
            this.cmbFacade.Location = new System.Drawing.Point(6, 65);
            this.cmbFacade.Name = "cmbFacade";
            this.cmbFacade.Size = new System.Drawing.Size(103, 21);
            this.cmbFacade.TabIndex = 2;
            // 
            // cmbBlind
            // 
            this.cmbBlind.FormattingEnabled = true;
            this.cmbBlind.Location = new System.Drawing.Point(132, 22);
            this.cmbBlind.Name = "cmbBlind";
            this.cmbBlind.Size = new System.Drawing.Size(103, 21);
            this.cmbBlind.TabIndex = 1;
            // 
            // cmbArena
            // 
            this.cmbArena.FormattingEnabled = true;
            this.cmbArena.Location = new System.Drawing.Point(6, 22);
            this.cmbArena.Name = "cmbArena";
            this.cmbArena.Size = new System.Drawing.Size(103, 21);
            this.cmbArena.TabIndex = 0;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.Beige;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.ForeColor = System.Drawing.Color.Red;
            this.btnAnalyze.Location = new System.Drawing.Point(22, 215);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(259, 38);
            this.btnAnalyze.TabIndex = 5;
            this.btnAnalyze.Text = "ANALYZE";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblYou);
            this.panel1.Controls.Add(this.lblMe);
            this.panel1.Controls.Add(this.rdoYou);
            this.panel1.Controls.Add(this.rdoMe);
            this.panel1.Location = new System.Drawing.Point(22, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 58);
            this.panel1.TabIndex = 6;
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Location = new System.Drawing.Point(159, 39);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(97, 13);
            this.lblYou.TabIndex = 8;
            this.lblYou.Text = "0 attribute selected";
            // 
            // lblMe
            // 
            this.lblMe.AutoSize = true;
            this.lblMe.Location = new System.Drawing.Point(3, 39);
            this.lblMe.Name = "lblMe";
            this.lblMe.Size = new System.Drawing.Size(97, 13);
            this.lblMe.TabIndex = 7;
            this.lblMe.Text = "0 attribute selected";
            // 
            // rdoYou
            // 
            this.rdoYou.AutoSize = true;
            this.rdoYou.Location = new System.Drawing.Point(179, 19);
            this.rdoYou.Name = "rdoYou";
            this.rdoYou.Size = new System.Drawing.Size(44, 17);
            this.rdoYou.TabIndex = 1;
            this.rdoYou.Text = "You";
            this.rdoYou.UseVisualStyleBackColor = true;
            this.rdoYou.CheckedChanged += new System.EventHandler(this.rdoYou_CheckedChanged);
            // 
            // rdoMe
            // 
            this.rdoMe.AutoSize = true;
            this.rdoMe.Checked = true;
            this.rdoMe.Location = new System.Drawing.Point(21, 19);
            this.rdoMe.Name = "rdoMe";
            this.rdoMe.Size = new System.Drawing.Size(40, 17);
            this.rdoMe.TabIndex = 0;
            this.rdoMe.TabStop = true;
            this.rdoMe.Text = "Me";
            this.rdoMe.UseVisualStyleBackColor = true;
            this.rdoMe.CheckedChanged += new System.EventHandler(this.rdoMe_CheckedChanged);
            // 
            // frmJohari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpControl);
            this.Name = "frmJohari";
            this.Text = "Johari Window";
            this.Load += new System.EventHandler(this.frmJohari_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMeByYou;
        private System.Windows.Forms.ComboBox cmbMeNotByYou;
        private System.Windows.Forms.ComboBox cmbMeNotByMe;
        private System.Windows.Forms.ComboBox cmbMeByMe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbMystery;
        private System.Windows.Forms.ComboBox cmbFacade;
        private System.Windows.Forms.ComboBox cmbBlind;
        private System.Windows.Forms.ComboBox cmbArena;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoYou;
        private System.Windows.Forms.RadioButton rdoMe;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Label lblMe;
        private System.Windows.Forms.Label lblMystery;
        private System.Windows.Forms.Label lblFacade;
        private System.Windows.Forms.Label lblBlind;
        private System.Windows.Forms.Label lblArena;
    }
}