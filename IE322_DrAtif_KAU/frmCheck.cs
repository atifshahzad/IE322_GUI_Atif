using System;
using System.Drawing;
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

            this.DialogResult = DialogResult.OK;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowSelected_Click(object sender, EventArgs e)
        {

        }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffee.Checked == true)
                chkCoffee.ForeColor = Color.Blue;
            else
                chkCoffee.ForeColor = Color.Black;
        }

        private void chkDonut_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDonut.Checked == true)
                chkDonut.ForeColor = Color.Blue;
            else
                chkDonut.ForeColor = Color.Black;
        }

        private void chkBrownie_CheckedChanged(object sender, EventArgs e)
        {

            if (chkBrownie.Checked == true)
                chkBrownie.ForeColor = Color.Blue;
            else
                chkBrownie.ForeColor = Color.Black;
        }
    }
}
