using System;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();

            TrkMin.Minimum = 0;
            TrkMin.Maximum = 10000;


            TrkMax.Minimum = TrkMin.Value+200;
            TrkMax.Maximum = TrkMin.Value+TrkMin.Maximum;

            progressBar1.Step = 5;

        }

        private void btnShowProgress_Click(object sender, EventArgs e)
        {

            progressBar1.Minimum = TrkMin.Value;
            progressBar1.Maximum = TrkMax.Value;

            int i;            

            for (i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            int i;

            progressBar2.Minimum = progressBar1.Value;
            progressBar2.Maximum = progressBar2.Minimum + 2000;

            for (i = progressBar2.Minimum; i <= progressBar2.Maximum; i++)
            {
                progressBar2.Value = i;

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
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            progressBar1.Step = 1;
        }
    }
}
