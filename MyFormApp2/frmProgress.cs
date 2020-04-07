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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
           
        }

        private void btnShowProgress_Click(object sender, EventArgs e)
        {
            int i;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;

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
            progressBar2.Maximum = progressBar2.Minimum + 200;

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
    }
}
