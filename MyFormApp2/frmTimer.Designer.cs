namespace IE322_App_KAU
{
    partial class frmTimer
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
            this.btnBack = new System.Windows.Forms.Button();
            this.prgTry = new System.Windows.Forms.ProgressBar();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.tmrTry = new System.Windows.Forms.Timer(this.components);
            this.TmrShowMsg = new System.Windows.Forms.Timer(this.components);
            this.BtnTimerShowMsgStart = new System.Windows.Forms.Button();
            this.BtnTimerShowMsgStop = new System.Windows.Forms.Button();
            this.RdoTry = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnToggleTimer3 = new System.Windows.Forms.Button();
            this.Timer3 = new System.Windows.Forms.Timer(this.components);
            this.TrkTBA = new System.Windows.Forms.TrackBar();
            this.Timer4 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnStartTimer4 = new System.Windows.Forms.Button();
            this.TxtForTimer4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrkTBA)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(656, 351);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // prgTry
            // 
            this.prgTry.Location = new System.Drawing.Point(8, 86);
            this.prgTry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prgTry.Name = "prgTry";
            this.prgTry.Size = new System.Drawing.Size(513, 60);
            this.prgTry.TabIndex = 9;
            this.prgTry.Click += new System.EventHandler(this.prgTry_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(51, 23);
            this.btnStartTimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(87, 55);
            this.btnStartTimer.TabIndex = 8;
            this.btnStartTimer.Text = "Start Timer 1";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // tmrTry
            // 
            this.tmrTry.Tick += new System.EventHandler(this.tmrTry_Tick);
            // 
            // TmrShowMsg
            // 
            this.TmrShowMsg.Tick += new System.EventHandler(this.TmrShowMsg_Tick);
            // 
            // BtnTimerShowMsgStart
            // 
            this.BtnTimerShowMsgStart.Location = new System.Drawing.Point(40, 23);
            this.BtnTimerShowMsgStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnTimerShowMsgStart.Name = "BtnTimerShowMsgStart";
            this.BtnTimerShowMsgStart.Size = new System.Drawing.Size(102, 55);
            this.BtnTimerShowMsgStart.TabIndex = 10;
            this.BtnTimerShowMsgStart.Text = "Start Timer 2";
            this.BtnTimerShowMsgStart.UseVisualStyleBackColor = true;
            this.BtnTimerShowMsgStart.Click += new System.EventHandler(this.BtnTimerShowMsgStart_Click);
            // 
            // BtnTimerShowMsgStop
            // 
            this.BtnTimerShowMsgStop.Location = new System.Drawing.Point(149, 23);
            this.BtnTimerShowMsgStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnTimerShowMsgStop.Name = "BtnTimerShowMsgStop";
            this.BtnTimerShowMsgStop.Size = new System.Drawing.Size(102, 55);
            this.BtnTimerShowMsgStop.TabIndex = 11;
            this.BtnTimerShowMsgStop.Text = "Stop Timer 2";
            this.BtnTimerShowMsgStop.UseVisualStyleBackColor = true;
            this.BtnTimerShowMsgStop.Click += new System.EventHandler(this.BtnTimerShowMsgStop_Click);
            // 
            // RdoTry
            // 
            this.RdoTry.AutoSize = true;
            this.RdoTry.Location = new System.Drawing.Point(51, 110);
            this.RdoTry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdoTry.Name = "RdoTry";
            this.RdoTry.Size = new System.Drawing.Size(251, 21);
            this.RdoTry.TabIndex = 12;
            this.RdoTry.TabStop = true;
            this.RdoTry.Text = "See Me, I am Attached with Timer 2";
            this.RdoTry.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartTimer);
            this.groupBox1.Controls.Add(this.prgTry);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(529, 161);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnTimerShowMsgStart);
            this.groupBox2.Controls.Add(this.BtnTimerShowMsgStop);
            this.groupBox2.Controls.Add(this.RdoTry);
            this.groupBox2.Location = new System.Drawing.Point(16, 214);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(340, 138);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnToggleTimer3);
            this.groupBox3.Location = new System.Drawing.Point(560, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(221, 149);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // BtnToggleTimer3
            // 
            this.BtnToggleTimer3.Location = new System.Drawing.Point(35, 23);
            this.BtnToggleTimer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnToggleTimer3.Name = "BtnToggleTimer3";
            this.BtnToggleTimer3.Size = new System.Drawing.Size(161, 111);
            this.BtnToggleTimer3.TabIndex = 10;
            this.BtnToggleTimer3.Text = "Toggle Timer 3";
            this.BtnToggleTimer3.UseVisualStyleBackColor = true;
            this.BtnToggleTimer3.Click += new System.EventHandler(this.BtnToggleTimer3_Click);
            // 
            // Timer3
            // 
            this.Timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // TrkTBA
            // 
            this.TrkTBA.Location = new System.Drawing.Point(8, 70);
            this.TrkTBA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrkTBA.Minimum = 1;
            this.TrkTBA.Name = "TrkTBA";
            this.TrkTBA.Size = new System.Drawing.Size(356, 56);
            this.TrkTBA.TabIndex = 16;
            this.TrkTBA.Value = 1;
            this.TrkTBA.Scroll += new System.EventHandler(this.TrkTBA_Scroll);
            // 
            // Timer4
            // 
            this.Timer4.Tick += new System.EventHandler(this.Timer4_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnStartTimer4);
            this.groupBox4.Controls.Add(this.TxtForTimer4);
            this.groupBox4.Controls.Add(this.TrkTBA);
            this.groupBox4.Location = new System.Drawing.Point(384, 222);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(372, 130);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // BtnStartTimer4
            // 
            this.BtnStartTimer4.Location = new System.Drawing.Point(111, 16);
            this.BtnStartTimer4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnStartTimer4.Name = "BtnStartTimer4";
            this.BtnStartTimer4.Size = new System.Drawing.Size(87, 55);
            this.BtnStartTimer4.TabIndex = 10;
            this.BtnStartTimer4.Text = "ON/OFF Timer 4";
            this.BtnStartTimer4.UseVisualStyleBackColor = true;
            this.BtnStartTimer4.Click += new System.EventHandler(this.BtnStartTimer4_Click);
            // 
            // TxtForTimer4
            // 
            this.TxtForTimer4.Location = new System.Drawing.Point(231, 23);
            this.TxtForTimer4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtForTimer4.Name = "TxtForTimer4";
            this.TxtForTimer4.Size = new System.Drawing.Size(132, 22);
            this.TxtForTimer4.TabIndex = 17;
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 394);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTimer";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrkTBA)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ProgressBar prgTry;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Timer tmrTry;
        private System.Windows.Forms.Timer TmrShowMsg;
        private System.Windows.Forms.Button BtnTimerShowMsgStart;
        private System.Windows.Forms.Button BtnTimerShowMsgStop;
        private System.Windows.Forms.RadioButton RdoTry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnToggleTimer3;
        private System.Windows.Forms.Timer Timer3;
        private System.Windows.Forms.TrackBar TrkTBA;
        private System.Windows.Forms.Timer Timer4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtForTimer4;
        private System.Windows.Forms.Button BtnStartTimer4;
    }
}