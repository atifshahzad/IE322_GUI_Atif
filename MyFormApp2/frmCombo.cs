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

        private void BtnShowSelected1_Click(object sender, EventArgs e)
        {   //Using Method1
            
            MessageBox.Show(CmbDays.Text);      

        }

        private void BtnShowSelected2_Click(object sender, EventArgs e)
        {
            //Method2
            string itemText = CmbDays.GetItemText(CmbDays.SelectedItem);
            MessageBox.Show(itemText);            
        }

        private void BtnShowSelected3_Click(object sender, EventArgs e)
        {
            //Method3

            var item= CmbDays.SelectedItem;
            if(item !=null)
            MessageBox.Show(item.ToString()); // if item is Null, an error will occour 
        }

        private void btnRemoveByIndex_Click(object sender, EventArgs e)
        {
            //remove item at a the specified index or giving a specified item by name.
            CmbDays.Items.RemoveAt(1);
            // The above code will remove the second item from the combobox. 
        }

        private void btnRemoveByName_Click(object sender, EventArgs e)
        {
           //remove item by giving a specified item by name.
            CmbDays.Items.Remove("Friday");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void BtnRemoveLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Cant remove last item"); 
            }
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnRemove2ndLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Cant remove 2nd last item");
            }

        }
    }
}
