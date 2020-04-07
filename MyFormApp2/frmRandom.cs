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

            label1.Text = Convert.ToString(r)+"-"+ Convert.ToString(g) +"-" + Convert.ToString(b); 
            btnGenerateRandom.BackColor= Color.FromArgb(r, g, b);
            this.BackColor = Color.FromArgb(255-r, 255-g, 255-b);
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void BtnRandomNum_Click(object sender, EventArgs e)
        {
           
            BtnRandomNum.Text=Convert.ToString(y.Next(1, 10));
            
        }
    }
}
