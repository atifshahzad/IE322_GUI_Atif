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
    public partial class frmDate : Form
    {
        public frmDate()
        {
            InitializeComponent();
         
        }

        private void BtnAddAppointment_Click(object sender, EventArgs e)
        {
            if (TxtName.Text != "")
            {
                DateTime DteAppt = DteAppointment.Value;
                CmbAppointments.Items.Add(DteAppt + " by " + TxtName.Text);
             //CldBirth.
            }
            else
            { 
            
            }
        }
    }
}
