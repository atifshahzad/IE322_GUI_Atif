using System;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmArduino : Form
    {
        public frmArduino()
        {
            InitializeComponent();

        }

        private void PortWrite(string message)
        {
            if (srpArduino != null && srpArduino.IsOpen)
            {
                srpArduino.Write(message);
            }
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            try
            {

                srpArduino.Write("1");
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            try
            {
                srpArduino.Write("0");
                btnOFF.Enabled = !btnOFF.Enabled;
                btnON.Enabled = !btnON.Enabled;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmArduino_Load(object sender, EventArgs e)
        {
            btnCloseConnection.Enabled = false;
            btnON.Enabled = false;
        }

        private void btnOpenConnection_Click(object sender, EventArgs e)
        {


            /*if (srpArduino == null)
            {
                //Change the portname according to your computer
                srpArduino = new SerialPort("COM5", 9600);
                srpArduino.Open();
            }
            */

            if (!srpArduino.IsOpen) // if not already open
            {
                try
                {

                    srpArduino.Open();
                    btnCloseConnection.Enabled = !btnCloseConnection.Enabled;
                    btnOpenConnection.Enabled = !btnOpenConnection.Enabled;

                }
                catch (Exception)
                {

                    MessageBox.Show("Could not connect, some error");
                }
            }
        }

        private void btnCloseConnection_Click(object sender, EventArgs e)
        {


            try
            {
                if (srpArduino != null && srpArduino.IsOpen)
                {
                    srpArduino.Close();
                    btnCloseConnection.Enabled = !btnCloseConnection.Enabled;
                    btnOpenConnection.Enabled = !btnOpenConnection.Enabled;
                }

            }
            catch (Exception)
            {


            }
        }
    }
}