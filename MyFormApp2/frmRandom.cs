using System;
using System.Drawing;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmRandom : Form
    {
        Random y = new Random();

        public frmRandom()
        {
            InitializeComponent();
            //controls the clipping and positioning of the image in the display area.
        }

        private void btnGenerateRandom_Click(object sender, EventArgs e)
        {
            int r= y.Next(0, 255);
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

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void BtnRandomNum_Click(object sender, EventArgs e)
        {

            BtnRandomNum.Text = Convert.ToString(y.Next(1, 10));

        }
    }
}
