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
    public partial class frmRandom : Form
    {
        Random y = new Random();
        public frmRandom()
        {
            InitializeComponent();
        }

        private void BtnRandomNum_Click(object sender, EventArgs e)
        {

            BtnRandomNum.Text = Convert.ToString(y.Next(1, 10));
        
        }

        private void btnGeneraterandom_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);

            int g = y.Next(0, 255);

            int b = y.Next(0, 255);



            LblRGB.ForeColor = Color.FromArgb(r, g, b);

            btnGenerateRandom.BackColor = Color.FromArgb(r, g, b);

            btnGenerateRandom.ForeColor = Color.FromArgb(255 - r, 255 - g, 255 - b);

            this.BackColor = Color.FromArgb(255 - r, 255 - g, 255 - b);

            LblRGB.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
