using IE322_App_KAU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE322_Shaker
{
    public partial class Form1 : Form
    {
        string username = "shaker";   //"Atif"; //username

        string myPassword = "123";  //"1234"; //password



        bool loggedIn = false;



        int ThisAttempt = 1;

        int MaxAttempts = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!loggedIn)

            {

                while (ThisAttempt <= MaxAttempts)

                {

                    if (txtuser.Text != username)

                    {

                        // username is incorrect

                        MessageBox.Show("Invalid username, " + (MaxAttempts - ThisAttempt) + " attempts remaining");

                        ThisAttempt++; //

                        return;

                    }

                    else

                    {  // username is correct

                        // so check password			

                        if (txtpassword.Text != myPassword)

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



                            BtnLogin.Text = "Logout";

                            

                            // this.Width = 1600;

                            break; // come out of while loop

                        }//endif



                    }//endif

                }//end while

            }

            else

            {

                BtnLogin.Text = "Login";

              

                loggedIn = false;



                txtuser.Clear();

                txtpassword.Clear();



                foreach (var grp in groupBox1.Controls.OfType<GroupBox>())

                {

                    foreach (var btn in grp.Controls.OfType<Button>())

                    {

                        btn.Enabled = false;

                    }

                }

            }
            MessageBox.Show("Login Successful");
        }

        private void FrmRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();

            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmOperators frm = new frmOperators();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
              
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            frmDecision frm = new frmDecision();
            frm.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmOperators frm = new frmOperators();
                frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmLoops frm = new frmLoops();
                frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMethods frm = new frmMethods();
            frm.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frmMethods frm = new frmMethods();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmProgress frm = new frmProgress();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }
    }
}
