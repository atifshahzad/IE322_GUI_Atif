using System;
using System.Drawing;
using System.IO; //for stream object
using System.Reflection; // for assembly
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmSelfie : Form
    {
        Assembly _assembly;
        Stream _imageStream;

        public frmSelfie()
        {
            InitializeComponent();
            //controls the clipping and positioning of the image in the display area.
            PicSelfie.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CmbSelfie.Items.Add(TxtID.Text);


        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CmbSelfie_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CmbSelfie.Text == "1234567")
            {
                PicSelfie.Image = Image.FromStream(_imageStream);
            }
            else
            {
                PicSelfie.Image = null;
            }




        }

        private void frmSelfie_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("IE322_App_KAU.res.foot_ball.png");
        }
    }
}
