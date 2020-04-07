using System;

using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmCheck : Form
    {
        
        public frmCheck()
        {
            InitializeComponent();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

      
        

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (chkCoffee.Checked == true)
            {
                msg = chkCoffee.Text;
            }

            if (chkDonut.Checked == true)
            {
                msg = msg + " " + chkDonut.Text;
            }

            if (chkBrownie.Checked == true)
            {
                msg = msg + " " + chkBrownie.Text;
            }

            if (msg.Length > 0)
            {
                MessageBox.Show(msg + " selected ");
            }
            else //length is zero
            {
                MessageBox.Show("Nothing selected");
            }
           
        }



        private void btnBack_Click(object sender, EventArgs e)
        {

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}