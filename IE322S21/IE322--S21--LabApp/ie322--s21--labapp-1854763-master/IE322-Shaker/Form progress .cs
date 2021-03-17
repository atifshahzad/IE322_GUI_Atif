using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE322_Shaker
{
    public partial class frmProgress : Form
    {
        public frmProgress()
        {
            InitializeComponent();
            TrkMin.Minimum = 0;

            TrkMin.Maximum = 10000;





            TrkMax.Minimum = TrkMin.Value + 200;

            TrkMax.Maximum = TrkMin.Value + TrkMin.Maximum;



            Pgb1.Step = 5;
        }

        private void TrkMin_Scroll(object sender, EventArgs e)
        {
           
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            Pgb1.Minimum = TrkMin.Value;

            Pgb1.Maximum = TrkMax.Value;



            int i;



            for (i = Pgb1.Minimum; i <= Pgb1.Maximum; i++)

            {

                Pgb1.Value = i;



            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void ResetValues()

        {

            TrkMin.Minimum = 0;

            TrkMin.Maximum = 10000;

            TrkMin.Value = 100;



            TrkMax.Minimum = TrkMin.Value + 200;

            TrkMax.Maximum = TrkMin.Value + TrkMin.Maximum;

            TrkMax.Value = TrkMin.Value + 2000;



            Pgb1.Step = 5;



            lblMin.Text = "Min:" + Pgb1.Minimum.ToString();

            lblMax.Text = "Max:" + Pgb1.Maximum.ToString();

            lblVal1.Text = "Val:" + Pgb1.Value.ToString();

        }
    }


}
