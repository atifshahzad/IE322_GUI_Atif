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
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmCheck_Load(object sender, EventArgs e)
        {

        }

        private void BtnShow_Click(object sender, EventArgs e)
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
