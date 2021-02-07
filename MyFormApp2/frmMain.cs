using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace IE322_App_KAU
{
    public partial class frmMain : Form
    {
        string username = "";      //"Atif"; //username
        string myPassword = "";    //"1234"; //password

        bool loggedIn = false;

        int ThisAttempt = 1;
        int MaxAttempts = 3;


        public frmMain()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
            {
                while (ThisAttempt <= MaxAttempts)
                {
                    if (txtUser.Text != username)
                    {
                        // username is incorrect
                        MessageBox.Show("Invalid username, " + (MaxAttempts - ThisAttempt) + " attempts remaining");
                        ThisAttempt++; //
                        return;
                    }
                    else
                    {   // username is correct
                        // so check password			
                        if (txtPassword.Text != myPassword)
                        {
                            // Incorrect password                            
                            MessageBox.Show("Incorrect password," + (MaxAttempts - ThisAttempt) + " attempts remaining");
                            ThisAttempt++;
                            return;
                        }
                        else
                        {
                            //Both are correct
                            ThisAttempt = 1; // reset the number of attempts
                            loggedIn = true;
                            // MessageBox.Show("Hi " + username + ", your login successful", "Welcome!!");                          


                            foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
                            {
                                foreach (var btn in grp.Controls.OfType<Button>())
                                {
                                    btn.Enabled = true;
                                    btn.ForeColor = Color.Black;
                                }
                            }

                            btnLogin.Text = "Logout";
                            toolStripStatusLabel1.Text = "Hi " + username + ", you are logged in.";
                            // this.Width = 1600;
                            break; // come out of while loop
                        }//endif

                    }//endif
                }//end while
            }
            else
            {
                btnLogin.Text = "Login";
                toolStripStatusLabel1.Text = "You are logged out.";
                loggedIn = false;

                txtUser.Clear();
                txtPassword.Clear();

                foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
                {
                    foreach (var btn in grp.Controls.OfType<Button>())
                    {
                        btn.Enabled = false;
                    }
                }
            }
        } //end login Button



        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
            {
                foreach (var btn in grp.Controls.OfType<Button>())
                {
                    btn.Enabled = false;
                }
            }

            toolStripStatusLabel1.Text = "Login please...";

        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();

        }

        private void BtnEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            frmPic01 frm = new frmPic01();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void btnPic2_Click(object sender, EventArgs e)
        {
            frmPic02 frm = new frmPic02();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void btnProg_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            frmTimer frm = new frmTimer();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            frmDraw frm = new frmDraw();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }



        private void btnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSelfieApp_Click(object sender, EventArgs e)
        {
            frmSelfie frm = new frmSelfie();
            frm.ShowDialog();
        }

        private void btnGroupieApp_Click(object sender, EventArgs e)
        {
            frmGroupie frm = new frmGroupie();
            frm.ShowDialog();
        }

        private void BtnManufCell_Click(object sender, EventArgs e)
        {
            try
            {
                frmManufSys frm = new frmManufSys();
                frm.ShowDialog();
                //to close the form
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void BtnRoboticCell_Click(object sender, EventArgs e)
        {

        }

        private void btnArduino_Click(object sender, EventArgs e)
        {
            frmArduino frm = new frmArduino();
            frm.ShowDialog();
        }

        private void btnJohari_Click(object sender, EventArgs e)
        {
            frmJohari frm = new frmJohari();
            frm.ShowDialog();
        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnTalk_Click(object sender, EventArgs e)
        {
            frmTalk frm = new frmTalk();
            frm.ShowDialog();
        }

        private void txtUser_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            this.txtUser.BackColor = Color.FromName("yellow");
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            this.txtUser.BackColor = Color.FromName("white");
        }


        private void txtPW_Enter(object sender, EventArgs e)
        {
            this.txtPassword.BackColor = Color.FromName("yellow");
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            this.txtPassword.BackColor = Color.FromName("white");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void LnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please try to remember your passwords");
        }

        private void BtnIteration_Click(object sender, EventArgs e)
        {
            frmLoops frm = new frmLoops();
            frm.ShowDialog();
        }

        private void BtnOperators_Click(object sender, EventArgs e)
        {
            frmOperators frm = new frmOperators();
            frm.ShowDialog();

        }

        private void BtnDecision_Click(object sender, EventArgs e)
        {
            frmDecision frm = new frmDecision();
            frm.ShowDialog();

        }

        private void BtnMethods_Click(object sender, EventArgs e)
        {
            frmMethods frm = new frmMethods();
            frm.ShowDialog();
        }

        private void BtnClasses_Click(object sender, EventArgs e)
        {
            frmClasses frm = new frmClasses();
            frm.ShowDialog();
        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            frmArray frm = new frmArray();
            frm.Show();
        }

        private void BtnMongoDB_Click(object sender, EventArgs e)
        {
            frmMongoDB frm = new frmMongoDB();
            frm.Show();
        }

        private void BtnStrings_Click(object sender, EventArgs e)
        {
            frmStrings frm = new frmStrings();
            frm.ShowDialog();
        }

        private void BtnCollections_Click(object sender, EventArgs e)
        {
            frmCollections frm = new frmCollections();
            frm.ShowDialog();
        }

        private void BtnSystem_Click(object sender, EventArgs e)
        {
            frmSystem frm = new frmSystem();
            frm.ShowDialog();

        }

        private void BtnEvents_Click(object sender, EventArgs e)
        {
            frmEvents frm = new frmEvents();
            frm.Show();
        }

        private void BtnDataTypes_Click(object sender, EventArgs e)
        {

        }

        private void StsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
