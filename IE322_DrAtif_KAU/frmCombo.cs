using System;
using System.Drawing;
using System.Windows.Forms;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace IE322_App_KAU
{
    public partial class frmCombo : Form
    {
        // Create a Graphics object to draw on the PictureBox        
            Graphics g;

        public frmCombo()
        {
            InitializeComponent();

            // Adding items to the Combobox for Example 1
            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wednesday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Saturday");
            CmbDays.Items.Add("Funday");
            CmbDays.Items.Add("Examday");
            LblCount.Text = "Current Number of Items:" + Convert.ToString(CmbDays.Items.Count);

            // Populate the ComboBox with color options for Example 2
            CmbColors.Items.Add("Red");
            CmbColors.Items.Add("Green");
            CmbColors.Items.Add("Blue");

            // Set the default selected color
            CmbColors.SelectedIndex = 0;

            
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

            var Myitem = CmbDays.SelectedItem;
            if (Myitem != null)
                MessageBox.Show(Myitem.ToString()); // if item is Null, an error will occour 
        }

        private void btnRemoveByIndex_Click(object sender, EventArgs e)
        {
            //remove item at a the specified index or giving a specified item by name.
            CmbDays.Items.RemoveAt(1);
            // The above code will remove the second item from the combobox.
            LblCount.Text = "Current Number of Items:" + Convert.ToString(CmbDays.Items.Count);
        }

        private void btnRemoveByName_Click(object sender, EventArgs e)
        {
            //remove item by giving a specified item by name.
            CmbDays.Items.Remove("Friday");
            LblCount.Text = "Current Number of Items:" + Convert.ToString(CmbDays.Items.Count);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void frmCombo_Load(object sender, EventArgs e)
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
                MessageBox.Show("Can't remove last item");
            }
            LblCount.Text = "Current Number of Items:" + Convert.ToString(CmbDays.Items.Count);
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblSelected.Text = "Currently Selected:" + CmbDays.SelectedItem.ToString();
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
            LblCount.Text = "Current Number of Items:" + Convert.ToString(CmbDays.Items.Count);
        }

        private void BtnRemoveSelectedItem_Click(object sender, EventArgs e)
        {
            //remove item by giving a specified item by name.
            CmbDays.Items.Remove(CmbDays.SelectedItem);
            LblCount.Text = "Current Number of Items:" + Convert.ToString(CmbDays.Items.Count);
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            // Get the selected color from the ComboBox
            string selectedColor = CmbColors.SelectedItem.ToString();
            Color color = Color.Black;

            // Set the color based on the selected color name
            switch (selectedColor)
            {
                case "Red":
                    color = Color.Red;
                    break;
                case "Green":
                    color = Color.Green;
                    break;
                case "Blue":
                    color = Color.Blue;
                    break;
            }
            g = PicDraw.CreateGraphics();
            // Clear any previous drawings
            g.Clear(Color.White);

            // Draw shapes of the selected color
            for (int i = 0; i < 5; i++)
            {
                int x = 5 + i * 50;
                int y = 50;
                int width = 40;
                int height = 40;

                // Draw an ellipse
                g.FillEllipse(new SolidBrush(color), x, y, width, height);
            }

            // Dispose of the Graphics object
            g.Dispose();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
           g = PicDraw.CreateGraphics();
            // Clear any previous drawings
            g.Clear(Color.White);
            // Dispose of the Graphics object
            g.Dispose();
        }
    }
}

