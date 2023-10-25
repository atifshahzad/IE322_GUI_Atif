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
    public partial class FrmExamQuestions : Form
    {
        public FrmExamQuestions()
        {
            InitializeComponent();
        }

        private void BtnQ05_Click(object sender, EventArgs e)
        {
            frmQ05 frm = new frmQ05();  
            frm.ShowDialog();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void BtnQ06_Click(object sender, EventArgs e)
        {
            frmQ06 frm = new frmQ06();
            frm.ShowDialog();
        }
    }
}

