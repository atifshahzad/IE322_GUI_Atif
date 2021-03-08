using System;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmProgress : Form
    {
        public frmProgress()
        {
            InitializeComponent();
            ResetValues();

        }

        private void btnShowProgress_Click(object sender, EventArgs e)
        {

            Pgb1.Minimum = TrkMin.Value;
            Pgb1.Maximum = TrkMax.Value;

            int i;            

            for (i = Pgb1.Minimum; i <= Pgb1.Maximum; i++)
            {
                Pgb1.Value = i;
                lblVal1.Text = "Val:" + Pgb1.Value.ToString();
                //Task.Delay(100).Wait();
                //await System.Windows.Threading.Dispatcher.Yield();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            int i;

            Pgb2.Minimum = Pgb1.Value;
            Pgb2.Maximum = Pgb2.Minimum + 2000;

            for (i = Pgb2.Minimum; i <= Pgb2.Maximum; i++)
            {
                Pgb2.Value = i;

            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetValues();
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
