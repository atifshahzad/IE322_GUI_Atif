﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmRandomCombo : Form
    {
        public frmRandomCombo()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            cmbRandom.ResetText();      //Resets the Text 
            cmbRandom.Items.Clear();    //Removes all items from Combo
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 51); i++)
            {
                cmbRandom.Items.Add(r.Next(100, 999));
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            cmbRandom.ResetText();
            cmbRandom.Items.Clear();
            rdoLess.Checked = false;
            rdoGreater.Checked = false;
        }

        private void cmbRandom_dialog(object sender, EventArgs e)
        {

            if (Convert.ToInt32(cmbRandom.Text) > 499)
            {
                rdoGreater.Checked = true;
            }
            else
            {
                rdoLess.Checked = true;
            }

        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void BtnGenerate2_Click(object sender, EventArgs e)
        {
            cmbRandom2.ResetText();
            cmbRandom2.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                cmbRandom2.Items.Add(r.Next(10, 99));
            }
            LblCount2.Text = Convert.ToString(cmbRandom2.Items.Count);
        }

        private void cmbRandom2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(cmbRandom2.Text) > 49)
            {
                rdoGreater2.Checked = true;
            }
            else
            {
                rdoLess2.Checked = true;
            }

        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            cmbRandom2.ResetText();
            cmbRandom2.Items.Clear();
            rdoLess2.Checked = false;
            rdoGreater2.Checked = false;
            LblCount2.Text = Convert.ToString(cmbRandom2.Items.Count);

        }

        private void rdoLess_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRandomCombo_Load(object sender, EventArgs e)
        {
            rdoGreater.Enabled = false;
            rdoGreater2.Enabled = false;
            rdoLess.Enabled = false;
            rdoLess2.Enabled = false;
        }

        private void Problem1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\IE322_ALL\_IE322_S20\20180404\MyFormApp2\MyFormApp2\Resources\S2018_QUIZ03--EA.pdf";
                System.Diagnostics.Process.Start("IExplore.exe", path);
            }
            catch
            {

            }
        }

        private void cmbRandom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbRandom.Text) > 499)
            {
                rdoGreater.Checked = true;
            }
            else
            {
                rdoLess.Checked = true;
            }
        }

        private void BtnGenerateColor_Click(object sender, EventArgs e)
        {
            Random y=new Random();
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            
            BtnGenerateColor.BackColor = Color.FromArgb(r, g, b);
            
           string s = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
            CmbColor.Items.Add(s);  
        }

        private void BtnReset3_Click(object sender, EventArgs e)
        {
            CmbColor.ResetText();
            CmbColor.Items.Clear();
            BtnGenerateColor.BackColor = Color.Beige;
        }

        private void CmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s=CmbColor.GetItemText(CmbColor.SelectedItem);
            string[] c=s.Split('-');             
            BtnGenerateColor.BackColor = Color.FromArgb(Convert.ToInt32(c[0]), Convert.ToInt32(c[1]), Convert.ToInt32(c[2]));
        }
    }
}

