using System;
using System.Drawing;
using System.Windows.Forms;
using MongoDB.Driver.Core.Misc;

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

        private void btnGenerateRandomIneger_Click(object sender, EventArgs e)
        {
             Random rnd = new Random();
            int num = rnd.Next(); // Returns a positive random integer within the default range - 2,147,483,648 to 2,147,483, 647.


            num = rnd.Next(97); // Returns a positive random integer that is less than the specified maximum value.

            num = rnd.Next(71,97);  //Returns a positive random integer within the specified minimum and maximum range(includes min and excludes max).

            
            
           double  num2 = rnd.NextDouble(); //Generates random floating-point number that is greater than or equal to 0.0 and less than 1.0.



        }

        private void btnSeed_Click(object sender, EventArgs e)
        {

            
            // Two different instances of the Random class having the same seed value will generate the same random numbers
            // By default, the seed value is time-dependent.

            Random rnd1 = new Random(10); //seed value 10
            for (int j = 0; j < 4; j++)
            {
                cmbRnd1.Items.Add(rnd1.Next());
            }
                       

            Random rnd2 = new Random(10);//seed value 10
            for (int j = 0; j < 4; j++)
            {
                cmbRnd2.Items.Add(rnd2.Next());
            }
        }
    }
}
