using System;


using System.Windows.Forms;

using System.IO; //for stream object
using System.Reflection; // for assembly
using System.Drawing;

namespace IE322_App_KAU
{
    public partial class frmGroupie : Form
    {
        Assembly _assembly;

        Stream _imageStreamMe;
        Stream _imageStreamLeft;
        Stream _imageStreamRight;
        Stream _imageStreamBack;
        Stream _imageStreamFront;

        public frmGroupie()
        {
            InitializeComponent();
        }

        private void frmGroupie_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imageStreamMe = _assembly.GetManifestResourceStream("IE322_App_KAU.res.me.png");
            _imageStreamLeft = _assembly.GetManifestResourceStream("IE322_App_KAU.res.left.jpg");
            _imageStreamRight = _assembly.GetManifestResourceStream("IE322_App_KAU.res.right.jpg");
            _imageStreamBack = _assembly.GetManifestResourceStream("IE322_App_KAU.res.back.jpg");
            _imageStreamFront = _assembly.GetManifestResourceStream("IE322_App_KAU.res.front.png");

        }

        private void CmbGroupie_SelectedIndexChanged(object sender, EventArgs e)
        {




            if (CmbGroupie.Text == "1234567")
            {
                PicMe.Image = Image.FromStream(_imageStreamMe);
            }
            else
            {
                PicMe.Image = null;
            }

        }

        private void PicMe_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("Please enter your ID"); 
            }
            else
            {
                CmbGroupie.Items.Add(TxtID.Text);
                PicMe.Image = Image.FromStream(_imageStreamMe);
                
            }
               
        }

       

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PicLeft_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("None on my Left");
                CmbGroupie.Items.Add("None on my Left");
            }
            else if (TxtID.Text == "1234567")
            {
                MessageBox.Show("Can't be Me again");
            }
            else
            {
                CmbGroupie.Items.Add(TxtID.Text);
                PicLeft.Image = Image.FromStream(_imageStreamLeft);

            }

        }

        private void PicRight_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("None on my Right");
                CmbGroupie.Items.Add("None on my Right");
            }
            else if (TxtID.Text == "1234567")
            {
                MessageBox.Show("Can't be Me again");
            }
            else
            {
                CmbGroupie.Items.Add(TxtID.Text);
                PicRight.Image = Image.FromStream(_imageStreamRight);
              
            }
        }

        private void PicFront_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("No one in my Front");
                CmbGroupie.Items.Add("No one in my Front");
            }
            else if (TxtID.Text == "1234567")
            {
                MessageBox.Show("Can't be Me again");
            }
            else
            {
                CmbGroupie.Items.Add(TxtID.Text);
                PicFront.Image = Image.FromStream(_imageStreamFront);

            }
        }

        private void PicBack_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("No one on my Back");
                CmbGroupie.Items.Add("No one on my Back");
            }
            else if (TxtID.Text == "1234567")
            {
                MessageBox.Show("Can't be Me again");
            }           
            else
            {
                CmbGroupie.Items.Add(TxtID.Text);
                PicBack.Image = Image.FromStream(_imageStreamBack);

            }
        }
    }
}
