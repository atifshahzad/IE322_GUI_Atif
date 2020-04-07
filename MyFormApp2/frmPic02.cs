using System;

using System.Drawing;

using System.Windows.Forms;

using System.IO;             //for stream object
using System.Reflection;     // for assembly

namespace IE322_App_KAU
{
    public partial class frmPic02 : Form
    {
        Assembly _assembly;
        Stream _imageStream;        


        public frmPic02()
        {
            InitializeComponent();
            //controls the clipping and positioning of the image in the display area.
            picTry.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
               
                picTry.Image = Image.FromStream(_imageStream);

            }
            catch
            {
                MessageBox.Show("Error creating image!");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("IE322_App_KAU.res.A.jpg");

           
            
        }

        private void picTry_Click(object sender, EventArgs e)
        {

        }
    }
}
