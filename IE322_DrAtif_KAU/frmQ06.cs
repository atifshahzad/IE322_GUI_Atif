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
    public partial class frmQ06 : Form
    {
        private int[] randomNumbers;

        public frmQ06()
        {
            InitializeComponent();
            InitializeRandomNumbers();
        }

        private void RtbQ01_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmQ06_Load(object sender, EventArgs e)
        {

        }

        private void InitializeRandomNumbers()
        {
            Random random = new Random();
            randomNumbers = new int[20];

            for (int i = 0; i < 20; i++)
            {
                randomNumbers[i] = random.Next(1, 101);
            }

            CmbRandom.Items.AddRange(randomNumbers.Select(n => n.ToString()).ToArray());
        }

       
           
            

        
       

        private void BtnEcenCount_Click(object sender, EventArgs e)
        {
            int evenCount = randomNumbers.Count(n => n % 2 == 0);
            LblResult.Text = "Even Count: " + evenCount.ToString();

        }

        private void BtnLowest_Click(object sender, EventArgs e)
        {
            int lowest = randomNumbers.Min();
            LblResult.Text = "Lowest: " + lowest.ToString();

        }

        private void BtnHighest_Click(object sender, EventArgs e)
        {
            int highest = randomNumbers.Max();
            LblResult.Text = "Highest: " + highest.ToString();
        }

        private void BtnAvg_Click(object sender, EventArgs e)
        {
            double average = randomNumbers.Average();
            LblResult.Text = "Average: " + average.ToString("0.00");
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            int sum = randomNumbers.Sum();
            LblResult.Text = "Sum: " + sum.ToString();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
