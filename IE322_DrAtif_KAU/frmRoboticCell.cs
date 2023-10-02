using System;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmRoboticCell : Form
    {

        // Graphics G;
        //Pen myPen = new Pen(System.Drawing.Color.Red, 5);

        public frmRoboticCell()
        {
            InitializeComponent();


        }

        private void frmRoboticCell_Load(object sender, EventArgs e)
        {

        }

        private void PnlPlayArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlPlayArea_Click(object sender, MouseEventArgs e)
        {
            // Point coordinates = Cursor.Position;// Relative to screen
            // Point coordinates = PnlPlayArea.PointToClient(Cursor.Position); //relative to Panel control
            // G.DrawLine(myPen, 0, 0, coordinates.X, coordinates.Y);

        }
    }
}
