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
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using System.IO;

    public partial class FrmCheckedList : System.Windows.Forms.Form
    {
        private System.Windows.Forms.CheckedListBox ChlFruitsList;
        private System.Windows.Forms.TextBox TxtFruitToAdd;
        private System.Windows.Forms.Button BtnAddFruit;
        private System.Windows.Forms.Button BtnShowOrder;
        private System.Windows.Forms.ListBox LstFruitsOrdered;
        private System.Windows.Forms.Button BtnSaveOrder;
       // private System.ComponentModel.Container components;

        public FrmCheckedList()
        {
            InitializeComponent();

            // Sets up the initial objects in the CheckedListBox.
            string[] myFruit = { "Apples", "Oranges", "Tomato" };
            ChlFruitsList.Items.AddRange(myFruit);

            // Changes the selection mode from double-click to single click.
            ChlFruitsList.CheckOnClick = true;
        }

       

        private void InitializeComponent()
        {
            this.TxtFruitToAdd = new System.Windows.Forms.TextBox();
            this.ChlFruitsList = new System.Windows.Forms.CheckedListBox();
            this.LstFruitsOrdered = new System.Windows.Forms.ListBox();
            this.BtnAddFruit = new System.Windows.Forms.Button();
            this.BtnShowOrder = new System.Windows.Forms.Button();
            this.BtnSaveOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtFruitToAdd
            // 
            this.TxtFruitToAdd.Location = new System.Drawing.Point(144, 64);
            this.TxtFruitToAdd.Name = "TxtFruitToAdd";
            this.TxtFruitToAdd.Size = new System.Drawing.Size(128, 20);
            this.TxtFruitToAdd.TabIndex = 1;
            this.TxtFruitToAdd.TextChanged += new System.EventHandler(this.TxtFruitToAdd_TextChanged);
            // 
            // ChlFruitsList
            // 
            this.ChlFruitsList.Location = new System.Drawing.Point(16, 64);
            this.ChlFruitsList.Name = "ChlFruitsList";
            this.ChlFruitsList.Size = new System.Drawing.Size(120, 184);
            this.ChlFruitsList.TabIndex = 0;
            this.ChlFruitsList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // LstFruitsOrdered
            // 
            this.LstFruitsOrdered.Location = new System.Drawing.Point(408, 64);
            this.LstFruitsOrdered.Name = "LstFruitsOrdered";
            this.LstFruitsOrdered.Size = new System.Drawing.Size(128, 186);
            this.LstFruitsOrdered.TabIndex = 3;
            // 
            // BtnAddFruit
            // 
            this.BtnAddFruit.Enabled = false;
            this.BtnAddFruit.Location = new System.Drawing.Point(144, 104);
            this.BtnAddFruit.Name = "BtnAddFruit";
            this.BtnAddFruit.Size = new System.Drawing.Size(104, 32);
            this.BtnAddFruit.TabIndex = 2;
            this.BtnAddFruit.Text = "Add Fruit";
            this.BtnAddFruit.Click += new System.EventHandler(this.BtnAddFruit_Click);
            // 
            // BtnShowOrder
            // 
            this.BtnShowOrder.Enabled = false;
            this.BtnShowOrder.Location = new System.Drawing.Point(288, 64);
            this.BtnShowOrder.Name = "BtnShowOrder";
            this.BtnShowOrder.Size = new System.Drawing.Size(104, 32);
            this.BtnShowOrder.TabIndex = 2;
            this.BtnShowOrder.Text = "Show Order";
            this.BtnShowOrder.Click += new System.EventHandler(this.BtnShowOrder_Click);
            // 
            // BtnSaveOrder
            // 
            this.BtnSaveOrder.Enabled = false;
            this.BtnSaveOrder.Location = new System.Drawing.Point(288, 104);
            this.BtnSaveOrder.Name = "BtnSaveOrder";
            this.BtnSaveOrder.Size = new System.Drawing.Size(104, 32);
            this.BtnSaveOrder.TabIndex = 2;
            this.BtnSaveOrder.Text = "Save Order";
            this.BtnSaveOrder.Click += new System.EventHandler(this.BtnSaveOrder_Click);
            // 
            // FrmCheckedList
            // 
            this.ClientSize = new System.Drawing.Size(563, 273);
            this.Controls.Add(this.LstFruitsOrdered);
            this.Controls.Add(this.BtnSaveOrder);
            this.Controls.Add(this.BtnShowOrder);
            this.Controls.Add(this.BtnAddFruit);
            this.Controls.Add(this.TxtFruitToAdd);
            this.Controls.Add(this.ChlFruitsList);
            this.Name = "FrmCheckedList";
            this.Text = "Fruit Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        // Adds the string if the text box has data in it.
        private void BtnAddFruit_Click(object sender, System.EventArgs e)
        {
            if (TxtFruitToAdd.Text != "")
            {
                if (ChlFruitsList.CheckedItems.Contains(TxtFruitToAdd.Text) == false)
                    ChlFruitsList.Items.Add(TxtFruitToAdd.Text, CheckState.Checked);
                TxtFruitToAdd.Text = "";
            }
        }
        // Activates or deactivates the Add button.
        private void TxtFruitToAdd_TextChanged(object sender, System.EventArgs e)
        {
            if (TxtFruitToAdd.Text == "")
            {
                BtnAddFruit.Enabled = false;
            }
            else
            {
                BtnAddFruit.Enabled = true;
            }
        }

        // Moves the checked items from the CheckedListBox to the listBox.
        private void BtnShowOrder_Click(object sender, System.EventArgs e)
        {
            LstFruitsOrdered.Items.Clear();
            BtnSaveOrder.Enabled = false;
            for (int i = 0; i < ChlFruitsList.CheckedItems.Count; i++)
            {
                LstFruitsOrdered.Items.Add(ChlFruitsList.CheckedItems[i]);
            }
            if (LstFruitsOrdered.Items.Count > 0)
                BtnSaveOrder.Enabled = true;
        }
        // Activates the move button if there are checked items.
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                if (ChlFruitsList.CheckedItems.Count == 1)
                {
                    BtnShowOrder.Enabled = false;
                }
            }
            else
            {
                BtnShowOrder.Enabled = true;
            }
        }

        // Saves the items to a file.
        private void BtnSaveOrder_Click(object sender, System.EventArgs e)
        {
            // Insert code to save a file.
            LstFruitsOrdered.Items.Clear();
            IEnumerator myEnumerator;
            myEnumerator = ChlFruitsList.CheckedIndices.GetEnumerator();
            int y;
            while (myEnumerator.MoveNext() != false)
            {
                y = (int)myEnumerator.Current;
                ChlFruitsList.SetItemChecked(y, false);
            }
            BtnSaveOrder.Enabled = false;
        }
    }
}
