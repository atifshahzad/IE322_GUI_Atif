﻿using System;
using System.Drawing;
using System.IO;            //for stream object
using System.Reflection;    // for assembly
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmPic01 : Form
    {
        Assembly _assembly; // creating an assembly object
        Stream _imageStream;// creating an imagestream object



        System.Drawing.Graphics graphicsObj3;
        Pen myPen = new Pen(System.Drawing.Color.Blue, 1);



        public frmPic01()
        {
            InitializeComponent();
            //controls the clipping and positioning of the image in the display area.
            picTry.SizeMode = PictureBoxSizeMode.StretchImage;
            picTry2.SizeMode = PictureBoxSizeMode.StretchImage;

            graphicsObj3 = this.picTry.CreateGraphics();//



        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                // picTry.Image = Image.FromFile("I:\\DrAtif_IE_KAU\\20180322\\IE322_S18_KAU\\IE322_S18_KAU\\res\\A.jpg");
                // picTry.Image = Image.FromFile("C: \\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"); // This may not work if you change the computer, Then you have to change this line
                // picTry.Image = Image.FromFile("G:\\IE322_ALL\\_IE322_S20\\20180404\\tiny_cc_jaixjz.png"); //absolute path

                picTry.Image = Image.FromFile("..\\..\\tiny_cc_jaixjz.png"); // relative path from the debug folder to two levels up
            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void picTry_Click(object sender, EventArgs e)
        {

            Point coordinates = picTry.PointToClient(Cursor.Position); //relative to Panel control

            //MessageBox.Show("Coordinates are: " + coordinates);

            graphicsObj3.DrawLine(myPen, coordinates.X - 1, coordinates.Y - 1, coordinates.X, coordinates.Y);


        }

        private void frmPic01_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly(); //set the assembly object
            _imageStream = _assembly.GetManifestResourceStream("IE322_App_KAU.res.B.jpg");
        }

        private void BtnImageFromRes_Click(object sender, EventArgs e)
        {
            try
            {
                picTry2.Image = Image.FromStream(_imageStream);
            }
            catch
            {

                MessageBox.Show("Error creating image from resource!");
            } 
        }

        private void RdoNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoNormal.Checked)
            {
                picTry.SizeMode = PictureBoxSizeMode.Normal;
                picTry2.SizeMode = PictureBoxSizeMode.Normal;
            }

        }

        private void RdoStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoStretch.Checked)
            { 
            picTry.SizeMode = PictureBoxSizeMode.StretchImage;
            picTry2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void RdoAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoAuto.Checked)
            {
                picTry.SizeMode = PictureBoxSizeMode.AutoSize;
                picTry2.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void RdoCentre_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoCentre.Checked)
            {
                picTry.SizeMode = PictureBoxSizeMode.CenterImage;
                picTry2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void RdoZoom_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoZoom.Checked)
            {
                picTry.SizeMode = PictureBoxSizeMode.Zoom;
                picTry2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
