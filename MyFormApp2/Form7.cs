using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            //controls the clipping and positioning of the image in the display area.
            picTry.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            picTry.Image = Image.FromFile("I:\\DrAtif_IE_KAU\\20180322\\IE322_S18_KAU\\IE322_S18_KAU\\A.jpg");


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
