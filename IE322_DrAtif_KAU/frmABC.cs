using System;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmABC : Form
    {
        public frmABC()
        {
            InitializeComponent();
            cmbItem.Sorted = false;
            cmbCost.Sorted = false;
            cmbQty.Sorted = false;
            cmbValue.Sorted = false;

        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            cmbItem.ResetText();
            cmbItem.Items.Clear();

            cmbCost.ResetText();
            cmbCost.Items.Clear();

            cmbQty.ResetText();
            cmbQty.Items.Clear();

            cmbValue.ResetText();
            cmbValue.Items.Clear();

            int sumQty = 0, sumVal = 0;

            Random r = new Random();
            for (int i = 0; i < r.Next(10, 50); i++)
            {
                cmbItem.Items.Add("Item" + (i + 1));// Adding an item to Combobox
                cmbCost.Items.Add(r.Next(1, 50));
                cmbQty.Items.Add(r.Next(100, 1000));
                cmbValue.Items.Add(Convert.ToInt32(cmbCost.Items[i]) * Convert.ToInt32(cmbQty.Items[i]));
                //cmbSorted.Items.Add(cmbValue.Items[i]);
                sumQty = sumQty + Convert.ToInt32(cmbQty.Items[i]);
                sumVal = sumVal + Convert.ToInt32(cmbValue.Items[i]);
            }

            lblCount.Text = cmbItem.Items.Count.ToString();
            lblTotalQty.Text = sumQty.ToString();
            lblTotalValue.Text = sumVal.ToString();
            // label1.Text = Convert.ToString(cmbValue.Items.Count);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            cmbItem.ResetText();
            cmbItem.Items.Clear();

            cmbCost.ResetText();
            cmbCost.Items.Clear();

            cmbQty.ResetText();
            cmbQty.Items.Clear();

            cmbValue.ResetText();
            cmbValue.Items.Clear();

            lblCount.Text = Convert.ToString(0);
            lblTotalQty.Text = Convert.ToString(0);
            lblTotalValue.Text = Convert.ToString(0);
        }
    }
}
