﻿namespace IE322_App_KAU
{
    partial class frmMain
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
            this.btnRadio = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnProg = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.lblPW = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPic2 = new System.Windows.Forms.Button();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.LnkForgot = new System.Windows.Forms.LinkLabel();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBlockChain = new System.Windows.Forms.GroupBox();
            this.BtnBlockChain = new System.Windows.Forms.Button();
            this.BtnExams = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.BtnArray = new System.Windows.Forms.Button();
            this.BtnCollections = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.BtnDecision = new System.Windows.Forms.Button();
            this.BtnIteration = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnArduino = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnDataTypes = new System.Windows.Forms.Button();
            this.BtnStrings = new System.Windows.Forms.Button();
            this.BtnOperators = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.BtnFSM = new System.Windows.Forms.Button();
            this.BtnEvents = new System.Windows.Forms.Button();
            this.BtnClasses = new System.Windows.Forms.Button();
            this.BtnMethods = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnSystem = new System.Windows.Forms.Button();
            this.BtnTalk = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnTree = new System.Windows.Forms.Button();
            this.BtnDate = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSelfieApp = new System.Windows.Forms.Button();
            this.btnGroupieApp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCheckList = new System.Windows.Forms.Button();
            this.StsMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.picLogo_IE = new System.Windows.Forms.PictureBox();
            this.grpLogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBlockChain.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.StsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo_IE)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRadio
            // 
            this.btnRadio.Location = new System.Drawing.Point(9, 18);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(75, 23);
            this.btnRadio.TabIndex = 0;
            this.btnRadio.Text = "Radio";
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(8, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(71, 28);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.MouseLeave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(71, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPW_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPW_Leave);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(90, 18);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(83, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "CheckBox";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(9, 47);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(75, 23);
            this.btnCombo.TabIndex = 5;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(9, 14);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(75, 23);
            this.btnPic.TabIndex = 6;
            this.btnPic.Text = "PictureBox";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // btnProg
            // 
            this.btnProg.Location = new System.Drawing.Point(5, 18);
            this.btnProg.Name = "btnProg";
            this.btnProg.Size = new System.Drawing.Size(90, 24);
            this.btnProg.TabIndex = 7;
            this.btnProg.Text = "Progress";
            this.btnProg.UseVisualStyleBackColor = true;
            this.btnProg.Click += new System.EventHandler(this.btnProg_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.BackColor = System.Drawing.Color.Orange;
            this.btnEXIT.Location = new System.Drawing.Point(2, 329);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(193, 83);
            this.btnEXIT.TabIndex = 8;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = false;
            this.btnEXIT.Click += new System.EventHandler(this.BtnEXIT_Click);
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(8, 71);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(53, 13);
            this.lblPW.TabIndex = 9;
            this.lblPW.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(91, 98);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPic2
            // 
            this.btnPic2.Location = new System.Drawing.Point(9, 42);
            this.btnPic2.Name = "btnPic2";
            this.btnPic2.Size = new System.Drawing.Size(75, 23);
            this.btnPic2.TabIndex = 11;
            this.btnPic2.Text = "PictureBox2";
            this.btnPic2.UseVisualStyleBackColor = true;
            this.btnPic2.Click += new System.EventHandler(this.btnPic2_Click);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.LnkForgot);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.lblPW);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.txtUser);
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Controls.Add(this.BtnAbout);
            this.grpLogin.Location = new System.Drawing.Point(2, 13);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(193, 144);
            this.grpLogin.TabIndex = 12;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login to IE322";
            // 
            // LnkForgot
            // 
            this.LnkForgot.AutoSize = true;
            this.LnkForgot.Location = new System.Drawing.Point(8, 124);
            this.LnkForgot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LnkForgot.Name = "LnkForgot";
            this.LnkForgot.Size = new System.Drawing.Size(91, 13);
            this.LnkForgot.TabIndex = 11;
            this.LnkForgot.TabStop = true;
            this.LnkForgot.Text = "Forgot password?";
            this.LnkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkForgot_LinkClicked);
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnAbout.Location = new System.Drawing.Point(10, 98);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(75, 23);
            this.BtnAbout.TabIndex = 11;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(107, 18);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(90, 24);
            this.btnTimer.TabIndex = 13;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(9, 20);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 14;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpBlockChain);
            this.groupBox1.Controls.Add(this.BtnExams);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(201, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 399);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpBlockChain
            // 
            this.grpBlockChain.Controls.Add(this.BtnBlockChain);
            this.grpBlockChain.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBlockChain.Location = new System.Drawing.Point(287, 202);
            this.grpBlockChain.Margin = new System.Windows.Forms.Padding(2);
            this.grpBlockChain.Name = "grpBlockChain";
            this.grpBlockChain.Padding = new System.Windows.Forms.Padding(2);
            this.grpBlockChain.Size = new System.Drawing.Size(177, 48);
            this.grpBlockChain.TabIndex = 29;
            this.grpBlockChain.TabStop = false;
            this.grpBlockChain.Text = "BlockChain";
            // 
            // BtnBlockChain
            // 
            this.BtnBlockChain.Location = new System.Drawing.Point(6, 17);
            this.BtnBlockChain.Name = "BtnBlockChain";
            this.BtnBlockChain.Size = new System.Drawing.Size(147, 23);
            this.BtnBlockChain.TabIndex = 19;
            this.BtnBlockChain.Text = "Block Chain";
            this.BtnBlockChain.UseVisualStyleBackColor = true;
            this.BtnBlockChain.Click += new System.EventHandler(this.BtnBlockChain_Click);
            // 
            // BtnExams
            // 
            this.BtnExams.Location = new System.Drawing.Point(293, 23);
            this.BtnExams.Name = "BtnExams";
            this.BtnExams.Size = new System.Drawing.Size(149, 163);
            this.BtnExams.TabIndex = 35;
            this.BtnExams.Tag = "";
            this.BtnExams.Text = "Exam Questions";
            this.BtnExams.UseVisualStyleBackColor = true;
            this.BtnExams.Click += new System.EventHandler(this.BtnExams_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.BtnArray);
            this.groupBox9.Controls.Add(this.BtnCollections);
            this.groupBox9.Location = new System.Drawing.Point(492, 96);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(167, 75);
            this.groupBox9.TabIndex = 34;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Data Structures";
            // 
            // BtnArray
            // 
            this.BtnArray.Location = new System.Drawing.Point(6, 18);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(147, 23);
            this.BtnArray.TabIndex = 29;
            this.BtnArray.Text = "Arrays";
            this.BtnArray.UseVisualStyleBackColor = true;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // BtnCollections
            // 
            this.BtnCollections.Location = new System.Drawing.Point(6, 46);
            this.BtnCollections.Name = "BtnCollections";
            this.BtnCollections.Size = new System.Drawing.Size(147, 23);
            this.BtnCollections.TabIndex = 33;
            this.BtnCollections.Text = "Collections";
            this.BtnCollections.UseVisualStyleBackColor = true;
            this.BtnCollections.Click += new System.EventHandler(this.BtnCollections_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.BtnDecision);
            this.groupBox8.Controls.Add(this.BtnIteration);
            this.groupBox8.Location = new System.Drawing.Point(491, 18);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(167, 73);
            this.groupBox8.TabIndex = 29;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Decision & Iteration";
            // 
            // BtnDecision
            // 
            this.BtnDecision.Location = new System.Drawing.Point(6, 19);
            this.BtnDecision.Name = "BtnDecision";
            this.BtnDecision.Size = new System.Drawing.Size(147, 23);
            this.BtnDecision.TabIndex = 0;
            this.BtnDecision.Text = "Decision";
            this.BtnDecision.UseVisualStyleBackColor = true;
            this.BtnDecision.Click += new System.EventHandler(this.BtnDecision_Click);
            // 
            // BtnIteration
            // 
            this.BtnIteration.Location = new System.Drawing.Point(6, 43);
            this.BtnIteration.Name = "BtnIteration";
            this.BtnIteration.Size = new System.Drawing.Size(147, 23);
            this.BtnIteration.TabIndex = 0;
            this.BtnIteration.Text = "Iteration";
            this.BtnIteration.UseVisualStyleBackColor = true;
            this.BtnIteration.Click += new System.EventHandler(this.BtnIteration_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnArduino);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox7.Location = new System.Drawing.Point(497, 311);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(167, 76);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Micro Controller";
            // 
            // btnArduino
            // 
            this.btnArduino.Location = new System.Drawing.Point(6, 17);
            this.btnArduino.Name = "btnArduino";
            this.btnArduino.Size = new System.Drawing.Size(147, 23);
            this.btnArduino.TabIndex = 19;
            this.btnArduino.Text = "Arduino";
            this.btnArduino.UseVisualStyleBackColor = true;
            this.btnArduino.Click += new System.EventHandler(this.btnArduino_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnDataTypes);
            this.groupBox6.Controls.Add(this.BtnStrings);
            this.groupBox6.Controls.Add(this.BtnOperators);
            this.groupBox6.Location = new System.Drawing.Point(287, 276);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(177, 117);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Operators";
            // 
            // BtnDataTypes
            // 
            this.BtnDataTypes.Location = new System.Drawing.Point(10, 15);
            this.BtnDataTypes.Name = "BtnDataTypes";
            this.BtnDataTypes.Size = new System.Drawing.Size(145, 27);
            this.BtnDataTypes.TabIndex = 34;
            this.BtnDataTypes.Text = "Data Types";
            this.BtnDataTypes.UseVisualStyleBackColor = true;
            this.BtnDataTypes.Click += new System.EventHandler(this.BtnDataTypes_Click);
            // 
            // BtnStrings
            // 
            this.BtnStrings.Location = new System.Drawing.Point(10, 84);
            this.BtnStrings.Name = "BtnStrings";
            this.BtnStrings.Size = new System.Drawing.Size(145, 27);
            this.BtnStrings.TabIndex = 33;
            this.BtnStrings.Text = "Strings";
            this.BtnStrings.UseVisualStyleBackColor = true;
            this.BtnStrings.Click += new System.EventHandler(this.BtnStrings_Click);
            // 
            // BtnOperators
            // 
            this.BtnOperators.Location = new System.Drawing.Point(10, 48);
            this.BtnOperators.Name = "BtnOperators";
            this.BtnOperators.Size = new System.Drawing.Size(145, 27);
            this.BtnOperators.TabIndex = 0;
            this.BtnOperators.Text = "Operators";
            this.BtnOperators.UseVisualStyleBackColor = true;
            this.BtnOperators.Click += new System.EventHandler(this.BtnOperators_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.BtnFSM);
            this.groupBox10.Controls.Add(this.BtnEvents);
            this.groupBox10.Controls.Add(this.BtnClasses);
            this.groupBox10.Controls.Add(this.BtnMethods);
            this.groupBox10.Location = new System.Drawing.Point(497, 177);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(162, 129);
            this.groupBox10.TabIndex = 32;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Object Oriented";
            // 
            // BtnFSM
            // 
            this.BtnFSM.Location = new System.Drawing.Point(7, 98);
            this.BtnFSM.Name = "BtnFSM";
            this.BtnFSM.Size = new System.Drawing.Size(146, 23);
            this.BtnFSM.TabIndex = 35;
            this.BtnFSM.Text = "FSM";
            this.BtnFSM.UseVisualStyleBackColor = true;
            this.BtnFSM.Click += new System.EventHandler(this.BtnFSM_Click);
            // 
            // BtnEvents
            // 
            this.BtnEvents.Location = new System.Drawing.Point(6, 69);
            this.BtnEvents.Name = "BtnEvents";
            this.BtnEvents.Size = new System.Drawing.Size(147, 23);
            this.BtnEvents.TabIndex = 34;
            this.BtnEvents.Text = "Events";
            this.BtnEvents.UseVisualStyleBackColor = true;
            this.BtnEvents.Click += new System.EventHandler(this.BtnEvents_Click);
            // 
            // BtnClasses
            // 
            this.BtnClasses.Location = new System.Drawing.Point(6, 43);
            this.BtnClasses.Name = "BtnClasses";
            this.BtnClasses.Size = new System.Drawing.Size(147, 23);
            this.BtnClasses.TabIndex = 31;
            this.BtnClasses.Text = "Classes";
            this.BtnClasses.UseVisualStyleBackColor = true;
            this.BtnClasses.Click += new System.EventHandler(this.BtnClasses_Click);
            // 
            // BtnMethods
            // 
            this.BtnMethods.Location = new System.Drawing.Point(6, 17);
            this.BtnMethods.Name = "BtnMethods";
            this.BtnMethods.Size = new System.Drawing.Size(147, 23);
            this.BtnMethods.TabIndex = 30;
            this.BtnMethods.Text = "Methods";
            this.BtnMethods.UseVisualStyleBackColor = true;
            this.BtnMethods.Click += new System.EventHandler(this.BtnMethods_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnSystem);
            this.groupBox5.Controls.Add(this.btnDraw);
            this.groupBox5.Controls.Add(this.BtnTalk);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Location = new System.Drawing.Point(47, 301);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(202, 92);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Draw and Talk";
            // 
            // BtnSystem
            // 
            this.BtnSystem.Location = new System.Drawing.Point(54, 48);
            this.BtnSystem.Name = "BtnSystem";
            this.BtnSystem.Size = new System.Drawing.Size(75, 23);
            this.BtnSystem.TabIndex = 23;
            this.BtnSystem.Text = "System";
            this.BtnSystem.UseVisualStyleBackColor = true;
            this.BtnSystem.Click += new System.EventHandler(this.BtnSystem_Click);
            // 
            // BtnTalk
            // 
            this.BtnTalk.Location = new System.Drawing.Point(98, 20);
            this.BtnTalk.Name = "BtnTalk";
            this.BtnTalk.Size = new System.Drawing.Size(75, 23);
            this.BtnTalk.TabIndex = 22;
            this.BtnTalk.Text = "Talk";
            this.BtnTalk.UseVisualStyleBackColor = true;
            this.BtnTalk.Click += new System.EventHandler(this.BtnTalk_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnTree);
            this.groupBox4.Controls.Add(this.BtnDate);
            this.groupBox4.Controls.Add(this.btnProg);
            this.groupBox4.Controls.Add(this.btnTimer);
            this.groupBox4.Controls.Add(this.btnRandom);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Location = new System.Drawing.Point(47, 178);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(202, 116);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "More Controls";
            // 
            // BtnTree
            // 
            this.BtnTree.Location = new System.Drawing.Point(107, 78);
            this.BtnTree.Name = "BtnTree";
            this.BtnTree.Size = new System.Drawing.Size(90, 24);
            this.BtnTree.TabIndex = 23;
            this.BtnTree.Text = "TreeView";
            this.BtnTree.UseVisualStyleBackColor = true;
            // 
            // BtnDate
            // 
            this.BtnDate.Location = new System.Drawing.Point(5, 78);
            this.BtnDate.Name = "BtnDate";
            this.BtnDate.Size = new System.Drawing.Size(90, 24);
            this.BtnDate.TabIndex = 22;
            this.BtnDate.Text = "Date Related";
            this.BtnDate.UseVisualStyleBackColor = true;
            this.BtnDate.Click += new System.EventHandler(this.BtnDate_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(5, 48);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(90, 24);
            this.btnRandom.TabIndex = 15;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(107, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 24);
            this.button1.TabIndex = 21;
            this.button1.Text = "RandomCombo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnRandomCombo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPic);
            this.groupBox3.Controls.Add(this.btnPic2);
            this.groupBox3.Controls.Add(this.btnSelfieApp);
            this.groupBox3.Controls.Add(this.btnGroupieApp);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(47, 98);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(202, 76);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphical";
            // 
            // btnSelfieApp
            // 
            this.btnSelfieApp.Location = new System.Drawing.Point(90, 14);
            this.btnSelfieApp.Name = "btnSelfieApp";
            this.btnSelfieApp.Size = new System.Drawing.Size(75, 23);
            this.btnSelfieApp.TabIndex = 16;
            this.btnSelfieApp.Text = "SelfieApp";
            this.btnSelfieApp.UseVisualStyleBackColor = true;
            this.btnSelfieApp.Click += new System.EventHandler(this.btnSelfieApp_Click);
            // 
            // btnGroupieApp
            // 
            this.btnGroupieApp.Location = new System.Drawing.Point(90, 42);
            this.btnGroupieApp.Name = "btnGroupieApp";
            this.btnGroupieApp.Size = new System.Drawing.Size(75, 23);
            this.btnGroupieApp.TabIndex = 17;
            this.btnGroupieApp.Text = "Groupie App";
            this.btnGroupieApp.UseVisualStyleBackColor = true;
            this.btnGroupieApp.Click += new System.EventHandler(this.btnGroupieApp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCheckList);
            this.groupBox2.Controls.Add(this.btnRadio);
            this.groupBox2.Controls.Add(this.btnCheck);
            this.groupBox2.Controls.Add(this.btnCombo);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(47, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(202, 76);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Controls";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BtnCheckList
            // 
            this.BtnCheckList.Location = new System.Drawing.Point(90, 47);
            this.BtnCheckList.Name = "BtnCheckList";
            this.BtnCheckList.Size = new System.Drawing.Size(83, 23);
            this.BtnCheckList.TabIndex = 6;
            this.BtnCheckList.Text = "Checked List";
            this.BtnCheckList.UseVisualStyleBackColor = true;
            this.BtnCheckList.Click += new System.EventHandler(this.BtnCheckList_Click);
            // 
            // StsMain
            // 
            this.StsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.StsMain.Location = new System.Drawing.Point(0, 415);
            this.StsMain.Name = "StsMain";
            this.StsMain.Size = new System.Drawing.Size(871, 22);
            this.StsMain.TabIndex = 16;
            this.StsMain.Text = "Dr. Atif Shahzad";
            this.StsMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StsMain_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(166, 17);
            this.toolStripStatusLabel1.Text = "Computer Applications in IE-1";
            // 
            // picLogo_IE
            // 
            this.picLogo_IE.Image = global::IE322_App_KAU.Properties.Resources.IE_LOGO4_19112019;
            this.picLogo_IE.Location = new System.Drawing.Point(2, 161);
            this.picLogo_IE.Name = "picLogo_IE";
            this.picLogo_IE.Size = new System.Drawing.Size(193, 146);
            this.picLogo_IE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo_IE.TabIndex = 17;
            this.picLogo_IE.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 437);
            this.Controls.Add(this.picLogo_IE);
            this.Controls.Add(this.StsMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.btnEXIT);
            this.Name = "frmMain";
            this.Text = "IE322_Dr. Atif Shahzad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpBlockChain.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.StsMain.ResumeLayout(false);
            this.StsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo_IE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Button btnProg;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPic2;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnSelfieApp;
        private System.Windows.Forms.Button btnGroupieApp;
        private System.Windows.Forms.Button btnArduino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnTalk;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.StatusStrip StsMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.LinkLabel LnkForgot;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button BtnOperators;
        private System.Windows.Forms.Button BtnDecision;
        private System.Windows.Forms.Button BtnIteration;
        private System.Windows.Forms.Button BtnMethods;
        private System.Windows.Forms.Button BtnClasses;
        private System.Windows.Forms.Button BtnArray;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button BtnStrings;
        private System.Windows.Forms.PictureBox picLogo_IE;
        private System.Windows.Forms.Button BtnCollections;
        private System.Windows.Forms.Button BtnSystem;
        private System.Windows.Forms.Button BtnEvents;
        private System.Windows.Forms.Button BtnDataTypes;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button BtnFSM;
        private System.Windows.Forms.Button BtnDate;
        private System.Windows.Forms.Button BtnTree;
        private System.Windows.Forms.Button BtnCheckList;
        private System.Windows.Forms.Button BtnExams;
        private System.Windows.Forms.GroupBox grpBlockChain;
        private System.Windows.Forms.Button BtnBlockChain;
    }
}
