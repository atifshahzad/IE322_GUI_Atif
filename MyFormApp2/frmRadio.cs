using System;
using System.Drawing;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    

    public partial class frmRadio : Form
    {

        
        public frmRadio()
        {
            InitializeComponent();
          
        }
        

        public frmRadio(string title, string txt)
        {
            InitializeComponent();          
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // rdoBlue.Checked = true;
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoRed.Checked = false;
            rdoGreen.Checked = false;
            rdoBlue.Checked = false;
            rdoYellow.Checked = false;

            rdoRed.ForeColor = Color.FromName("black");
            rdoGreen.ForeColor = Color.FromName("black");
            rdoBlue.ForeColor = Color.FromName("black");
            rdoYellow.ForeColor = Color.FromName("black");

            RdoRed2.Checked = false;
            RdoGreen2.Checked = false;
            RdoBlue2.Checked = false;
            RdoYellow2.Checked = false;

            RdoRed2.ForeColor = Color.FromName("black");
            RdoGreen2.ForeColor = Color.FromName("black");
            RdoBlue2.ForeColor = Color.FromName("black");
            RdoYellow2.ForeColor = Color.FromName("black");
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdoRed.Checked == true)
                rdoRed.ForeColor = Color.FromArgb(255, 0, 0); // http://www.flounder.com/csharp_color_table.htm
            else
                rdoRed.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGreen.Checked == true)
                rdoGreen.ForeColor = Color.FromName("green");
            else
                rdoGreen.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
           if (rdoBlue.Checked == true)
                rdoBlue.ForeColor = Color.FromName("blue");
            else
                rdoBlue.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void rdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYellow.Checked == true)
                rdoYellow.ForeColor = Color.FromName("yellow");
            else
                rdoYellow.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            RdoGreen2.ForeColor = Color.FromName("green");
        }

        private void RdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            RdoRed2.ForeColor = Color.FromName("red");
        }

        private void RdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            RdoBlue2.ForeColor = Color.FromName("blue");
        }

        private void RdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
            RdoYellow2.ForeColor = Color.FromName("yellow");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

