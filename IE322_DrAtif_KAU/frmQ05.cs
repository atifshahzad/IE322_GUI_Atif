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
    public partial class frmQ05 : Form
    {
        /*
         In this solution, the code generates six unique random lottery numbers when the "Play" button is clicked. The user can enter their lottery numbers in the combo box (separated by commas), and the code checks if they match the generated lottery numbers. If there's a match, a jackpot winner message is displayed. The user's attempts are counted and displayed. 
         */

        private Random random = new Random();
        private int[] lotteryNumbers = new int[6];
        private int attempts = 0;



        public frmQ05()
        {
            InitializeComponent();
        }

        private void frmQ01_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateLotteryNumbers()
        {
            for (int i = 0; i < 6; i++)
            {
                int number;
                do
                {
                    number = random.Next(1, 50);
                } while (Array.Exists(lotteryNumbers, element => element == number));


                lotteryNumbers[i] = number;
            }
            Array.Sort(lotteryNumbers);
            CmbLotteryNumbers.Items.Clear();
            CmbLotteryNumbers.Items.AddRange(Array.ConvertAll(lotteryNumbers, x => x.ToString()));
        }

        

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {

            attempts++;
            GenerateLotteryNumbers();

            string[] userNumbers = TxtUserNumbers.Text.Split(',');
            Array.Sort(userNumbers);

            if (lotteryNumbers.SequenceEqual(Array.ConvertAll(userNumbers, int.Parse)))
            {
                MessageBox.Show($"Congratulations! You've won the jackpot!", "Jackpot Winner");
            }
            else
            {
                MessageBox.Show($"Sorry, you didn't win this time. Try again!", "No Jackpot");
            }

            LblAttempts.Text = $"Attempts: {attempts}";
        }
    }
}

