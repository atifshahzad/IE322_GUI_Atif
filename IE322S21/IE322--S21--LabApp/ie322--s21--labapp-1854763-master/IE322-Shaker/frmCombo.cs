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
    public partial class frmCombo : Form
    {
        public frmCombo()
        {
            InitializeComponent();
            // Adding items to the Combobox

            CmbDays.Items.Add("Sunday");

            CmbDays.Items.Add("Monday");

            CmbDays.Items.Add("Tuesday");

            CmbDays.Items.Add("Wednesday");

            CmbDays.Items.Add("Thursday");

            CmbDays.Items.Add("Friday");

            CmbDays.Items.Add("Saturday");

            CmbDays.Items.Add("Funday");

            CmbDays.Items.Add("Examday");
        }

        private void frmCombo_Load(object sender, EventArgs e)
        {

        }

        private void BtnShowSelected1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);
        }

        private void BtnShowSelected2_Click(object sender, EventArgs e)
        {
            //Method2

            string itemText = CmbDays.GetItemText(CmbDays.SelectedItem);

            MessageBox.Show(itemText);
        }

        private void BtnRemoveByName_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("Friday");
        }

        private void BtnRemoveByIndex_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnShowSelected3_Click(object sender, EventArgs e)
        {
            //Method3



            var item = CmbDays.SelectedItem;

            if (item != null)

                MessageBox.Show(item.ToString()); // if item is Null, an error will occour
        }

        private void BtnRemoveLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)

            {

                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);

            }

            else

            {

                MessageBox.Show("Can't remove last item");

            }
        }

        private void BtnRemove2ndLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)

            {

                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);

            }

            else

            {

                MessageBox.Show("Can't remove 2nd item");

            }
        }
    }
}
