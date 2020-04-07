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
    public partial class frmClasses : Form
    {
        Car MyCar = new Car();
        Car HisCar = new Car();

       Truck MyTruck = new Truck();


        public frmClasses()
        {
            InitializeComponent();
        }

        private void BtnStartMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Start(); // calling the start method for MyCar
        }

        private void BtnStartHisCar_Click(object sender, EventArgs e)
        {        
          
            HisCar.Start();  
           

           

        }

        private void BtnAccMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Accelerate(30);
           MessageBox.Show(Convert.ToString(MyCar.speed));
        }

        private void BtnStopHisCar_Click(object sender, EventArgs e)
        {
            HisCar.Stop();
        }

        private void BtnStopMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Stop();
        }

        private void BtnStartMyTruck_Click(object sender, EventArgs e)
        {
          //  BtnStartMyTruck.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
