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
    public partial class frmDraw : Form
    {
        System.Drawing.Graphics graphicsObj;
        System.Drawing.Graphics graphicsObj2;
        Pen myPen = new Pen(System.Drawing.Color.Red, 5);

        public frmDraw()
        {
            InitializeComponent();

            //myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            //myPen.Color = System.Drawing.Color.RoyalBlue;
            //myPen.Width = 3;


        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {

            
            
            graphicsObj.DrawLine(myPen, 20, 20, 200, 210);

            


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            graphicsObj = this.CreateGraphics(); // on form
            graphicsObj2 = this.pnlTry.CreateGraphics(); // on panel
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Rectangle myRectangle = new Rectangle(20, 20, 250, 200);

            graphicsObj.DrawRectangle(myPen, myRectangle);
        }

        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            
            myPen.Color = System.Drawing.Color.RoyalBlue;
            Rectangle myRectangle = new Rectangle(40, 40, 250, 200);
            graphicsObj.DrawEllipse(myPen, myRectangle);
        }

        private void Form10_Paint(object sender, PaintEventArgs e)
        {
           
            
            Rectangle myRectangle = new Rectangle(20, 20, 250, 200);
            graphicsObj.DrawEllipse(myPen, myRectangle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Point coordinates = Cursor.Position;
            MessageBox.Show("Coordinates are: " + coordinates);
            
        }

        private void pnlTry_Click(object sender, EventArgs e)
        {
           
            
            
          // Point coordinates = Cursor.Position;// Relative to screen
            Point coordinates = pnlTry.PointToClient(Cursor.Position); //relative to Panel control
            graphicsObj2.DrawLine(myPen, 0, 0, coordinates.X, coordinates.Y);
            
        }

        private void pnlTry_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
