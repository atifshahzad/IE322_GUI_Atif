namespace IE322_App_KAU
{
    partial class frmManufSys
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPause = new System.Windows.Forms.Button();
            this.GrpStatus = new System.Windows.Forms.GroupBox();
            this.TxTPartsArrived = new System.Windows.Forms.TextBox();
            this.TxTPartsDelivered = new System.Windows.Forms.TextBox();
            this.TxTPartsInCombo = new System.Windows.Forms.TextBox();
            this.RdoStatusCNC01 = new System.Windows.Forms.RadioButton();
            this.BtnStop = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.BtnSimulate = new System.Windows.Forms.Button();
            this.PicCNC01 = new System.Windows.Forms.PictureBox();
            this.CmbWaitingArea01 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TrkMaxST = new System.Windows.Forms.TrackBar();
            this.TrkTBA = new System.Windows.Forms.TrackBar();
            this.TrkMinST = new System.Windows.Forms.TrackBar();
            this.TmrArrival = new System.Windows.Forms.Timer(this.components);
            this.TmrCNC01 = new System.Windows.Forms.Timer(this.components);
            this.PnlStatus = new System.Windows.Forms.Panel();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.GrpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCNC01)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrkMaxST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkTBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkMinST)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.BtnAbout);
            this.panel1.Controls.Add(this.BtnPause);
            this.panel1.Controls.Add(this.GrpStatus);
            this.panel1.Controls.Add(this.BtnStop);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.BtnSimulate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 374);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(36, 278);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(117, 23);
            this.BtnPause.TabIndex = 12;
            this.BtnPause.Text = "Pause Simulation";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // GrpStatus
            // 
            this.GrpStatus.Controls.Add(this.label3);
            this.GrpStatus.Controls.Add(this.label2);
            this.GrpStatus.Controls.Add(this.label1);
            this.GrpStatus.Controls.Add(this.TxTPartsArrived);
            this.GrpStatus.Controls.Add(this.TxTPartsDelivered);
            this.GrpStatus.Controls.Add(this.TxTPartsInCombo);
            this.GrpStatus.Location = new System.Drawing.Point(465, 219);
            this.GrpStatus.Name = "GrpStatus";
            this.GrpStatus.Size = new System.Drawing.Size(239, 137);
            this.GrpStatus.TabIndex = 11;
            this.GrpStatus.TabStop = false;
            this.GrpStatus.Text = "Statistics";
            // 
            // TxTPartsArrived
            // 
            this.TxTPartsArrived.Location = new System.Drawing.Point(149, 32);
            this.TxTPartsArrived.Name = "TxTPartsArrived";
            this.TxTPartsArrived.Size = new System.Drawing.Size(70, 20);
            this.TxTPartsArrived.TabIndex = 5;
            // 
            // TxTPartsDelivered
            // 
            this.TxTPartsDelivered.Location = new System.Drawing.Point(149, 84);
            this.TxTPartsDelivered.Name = "TxTPartsDelivered";
            this.TxTPartsDelivered.Size = new System.Drawing.Size(70, 20);
            this.TxTPartsDelivered.TabIndex = 4;
            // 
            // TxTPartsInCombo
            // 
            this.TxTPartsInCombo.Location = new System.Drawing.Point(149, 58);
            this.TxTPartsInCombo.Name = "TxTPartsInCombo";
            this.TxTPartsInCombo.Size = new System.Drawing.Size(70, 20);
            this.TxTPartsInCombo.TabIndex = 3;
            // 
            // RdoStatusCNC01
            // 
            this.RdoStatusCNC01.AutoSize = true;
            this.RdoStatusCNC01.Location = new System.Drawing.Point(14, 19);
            this.RdoStatusCNC01.Name = "RdoStatusCNC01";
            this.RdoStatusCNC01.Size = new System.Drawing.Size(14, 13);
            this.RdoStatusCNC01.TabIndex = 10;
            this.RdoStatusCNC01.TabStop = true;
            this.RdoStatusCNC01.UseVisualStyleBackColor = true;
            this.RdoStatusCNC01.CheckedChanged += new System.EventHandler(this.RdoStatusCNC01_CheckedChanged);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(36, 322);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(117, 23);
            this.BtnStop.TabIndex = 9;
            this.BtnStop.Text = "Stop Simulation";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(183, 292);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 53);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "E X I T";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BtnSimulate
            // 
            this.BtnSimulate.Location = new System.Drawing.Point(36, 236);
            this.BtnSimulate.Name = "BtnSimulate";
            this.BtnSimulate.Size = new System.Drawing.Size(117, 23);
            this.BtnSimulate.TabIndex = 5;
            this.BtnSimulate.Text = "Start Simulation";
            this.BtnSimulate.UseVisualStyleBackColor = true;
            this.BtnSimulate.Click += new System.EventHandler(this.BtnSimulate_Click);
            // 
            // PicCNC01
            // 
            this.PicCNC01.Image = global::IE322_App_KAU.Properties.Resources.Machine;
            this.PicCNC01.Location = new System.Drawing.Point(90, 19);
            this.PicCNC01.Name = "PicCNC01";
            this.PicCNC01.Size = new System.Drawing.Size(255, 175);
            this.PicCNC01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCNC01.TabIndex = 2;
            this.PicCNC01.TabStop = false;
            this.PicCNC01.Click += new System.EventHandler(this.PicCNC01_Click);
            // 
            // CmbWaitingArea01
            // 
            this.CmbWaitingArea01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbWaitingArea01.FormattingEnabled = true;
            this.CmbWaitingArea01.Location = new System.Drawing.Point(6, 20);
            this.CmbWaitingArea01.MaxDropDownItems = 15;
            this.CmbWaitingArea01.Name = "CmbWaitingArea01";
            this.CmbWaitingArea01.Size = new System.Drawing.Size(99, 21);
            this.CmbWaitingArea01.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TrkMaxST);
            this.groupBox1.Controls.Add(this.TrkTBA);
            this.groupBox1.Controls.Add(this.TrkMinST);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Part Data";
            // 
            // TrkMaxST
            // 
            this.TrkMaxST.Location = new System.Drawing.Point(94, 121);
            this.TrkMaxST.Minimum = 1;
            this.TrkMaxST.Name = "TrkMaxST";
            this.TrkMaxST.Size = new System.Drawing.Size(213, 45);
            this.TrkMaxST.TabIndex = 13;
            this.TrkMaxST.Value = 1;
            this.TrkMaxST.Scroll += new System.EventHandler(this.TrkMaxST_Scroll);
            // 
            // TrkTBA
            // 
            this.TrkTBA.Location = new System.Drawing.Point(94, 19);
            this.TrkTBA.Minimum = 1;
            this.TrkTBA.Name = "TrkTBA";
            this.TrkTBA.Size = new System.Drawing.Size(213, 45);
            this.TrkTBA.TabIndex = 3;
            this.TrkTBA.Value = 1;
            this.TrkTBA.Scroll += new System.EventHandler(this.TrkTBA_Scroll);
            // 
            // TrkMinST
            // 
            this.TrkMinST.Location = new System.Drawing.Point(94, 70);
            this.TrkMinST.Minimum = 1;
            this.TrkMinST.Name = "TrkMinST";
            this.TrkMinST.Size = new System.Drawing.Size(213, 45);
            this.TrkMinST.TabIndex = 12;
            this.TrkMinST.Value = 1;
            this.TrkMinST.Scroll += new System.EventHandler(this.TrkMinST_Scroll);
            // 
            // TmrArrival
            // 
            this.TmrArrival.Tick += new System.EventHandler(this.TmrArrival_Tick);
            // 
            // TmrCNC01
            // 
            this.TmrCNC01.Interval = 1000;
            this.TmrCNC01.Tick += new System.EventHandler(this.TmrCNC01_Tick);
            // 
            // PnlStatus
            // 
            this.PnlStatus.Location = new System.Drawing.Point(6, 38);
            this.PnlStatus.Name = "PnlStatus";
            this.PnlStatus.Size = new System.Drawing.Size(78, 156);
            this.PnlStatus.TabIndex = 13;
            this.PnlStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlStatus_Paint);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Location = new System.Drawing.Point(183, 240);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(117, 31);
            this.BtnAbout.TabIndex = 14;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PnlStatus);
            this.groupBox2.Controls.Add(this.RdoStatusCNC01);
            this.groupBox2.Controls.Add(this.PicCNC01);
            this.groupBox2.Location = new System.Drawing.Point(353, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 200);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Machining Center";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbWaitingArea01);
            this.groupBox3.Location = new System.Drawing.Point(335, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 126);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Waiting Line";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Parts Entered";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parts Waiting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Parts Delivered";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "InterArrival";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Min Service Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Max Service Time";
            // 
            // frmManufSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 387);
            this.Controls.Add(this.panel1);
            this.Name = "frmManufSys";
            this.Text = "Manufacturing Cell @ IE-KAU";
            this.Load += new System.EventHandler(this.frmManufSys_Load);
            this.panel1.ResumeLayout(false);
            this.GrpStatus.ResumeLayout(false);
            this.GrpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCNC01)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrkMaxST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkTBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkMinST)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSimulate;
        private System.Windows.Forms.TrackBar TrkTBA;
        private System.Windows.Forms.PictureBox PicCNC01;
        private System.Windows.Forms.ComboBox CmbWaitingArea01;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer TmrArrival;
        private System.Windows.Forms.Timer TmrCNC01;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.RadioButton RdoStatusCNC01;
        private System.Windows.Forms.GroupBox GrpStatus;
        private System.Windows.Forms.TextBox TxTPartsDelivered;
        private System.Windows.Forms.TextBox TxTPartsInCombo;
        private System.Windows.Forms.TrackBar TrkMaxST;
        private System.Windows.Forms.TrackBar TrkMinST;
        private System.Windows.Forms.TextBox TxTPartsArrived;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Panel PnlStatus;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}