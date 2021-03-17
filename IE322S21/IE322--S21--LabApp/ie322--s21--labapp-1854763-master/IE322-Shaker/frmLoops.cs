using System;
using System.Windows.Forms;

namespace IE322_Shaker
{
    public partial class frmLoops : Form
    {
        public frmLoops()
        {
            InitializeComponent();
        }

        private void BtnNestedForLoop_Click(object sender, EventArgs e)
        {
            LblDisplay.Text = "Using nested for Loop:\n";
            for (int i = 0; i < 5; i++) //Outer loop
            {
                LblDisplay.Text += ("\n");
                for (int j = 0; j < 4; j++)  //Inner loop
                {
                    LblDisplay.Text = LblDisplay.Text + "    " + Convert.ToString(i) + Convert.ToString(j);

                }  //end Inner loop             
            } //end Outer loop
            /*
             * Will display like this...
            00 01 02 03
            10 11 12 13
            20 21 22 23
            30 31 32 33
            40 41 42 43
            */
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnBreak1_Click(object sender, EventArgs e)
        {
            LblDisplay.Text = "Using break statement:\n";
            for (int i = 0; i < 4; i++)
            {

                if (i == 2)
                {
                    break;  // it will break the loop 
                }// end if
                LblDisplay.Text = LblDisplay.Text + "    " + Convert.ToString(i);

            }//end for loop
        }

        private void BtnContinue1_Click(object sender, EventArgs e)
        {
            LblDisplay.Text = "Using continue statement:\n";
            for (int i = 0; i < 4; i++)
            {

                if (i == 2)
                {
                    continue;  // it will skip the iteration 
                } // end if
                LblDisplay.Text = LblDisplay.Text + "    " + Convert.ToString(i);

            }//end for loop
        }

        private void frmLoops_Load(object sender, EventArgs e)
        {

        }

        private void BtnBreakNested_Click(object sender, EventArgs e)
        {
            LblDisplay.Text = "Using break in nested for Loop:\n";
            for (int i = 0; i < 5; i++)
            {
                LblDisplay.Text += ("\n");
                for (int j = 0; j < 4; j++)
                {
                    if (j == 2)
                    {
                        break;  // Every time it will break the inner loop only
                    } // end if
                    LblDisplay.Text = LblDisplay.Text + "    " + Convert.ToString(i) + Convert.ToString(j);

                }//end Inner loop 
            }//end Outer loop 
        }

        private void BtnContinueNested_Click(object sender, EventArgs e)
        {
            LblDisplay.Text = "Using continue in nested for Loop:\n";
            for (int i = 0; i < 5; i++)
            {
                LblDisplay.Text += ("\n");
                for (int j = 0; j < 4; j++)
                {
                    if (j == 2)
                    {
                        continue;  // Every time it will skip the iteration from  inner loop only
                    } // end if
                    LblDisplay.Text = LblDisplay.Text + "    " + Convert.ToString(i) + Convert.ToString(j);

                } //end Inner loop 
            }//end Outer loop 
        }

        private void BtnWhile1_Click(object sender, EventArgs e)
        {
            LblDisplay.Text = "Using while loop:\n";
            int num = 1;
            while (num < 6)
            {
                LblDisplay.Text = LblDisplay.Text + "    " + Convert.ToString(num);
                num++;
            }

        }

        private void BtnWhile2_Click(object sender, EventArgs e)
        {
            LblDisplay.Text = "Using while loop in short form \n(not recommended for new programmers):\n";
            int num = 1;
            while (++num < 6)
                LblDisplay.Text = LblDisplay.Text + "    " + Convert.ToString(num);

        }

        private void BtnDoWhile1_Click(object sender, EventArgs e)
        {
            LblDisplay.Text = "Using do while loop \n";
            int num = 0;
            do
            {
                LblDisplay.Text = LblDisplay.Text + "    " + Convert.ToString(num);
                num++;
            } while (num < 5);

        }

        private void BtnForLoop1_Click(object sender, EventArgs e)
        {
            LblDisplay.Text = "Using for loop \n";
            for (int x = 0; x < 5; x++)
            {
                LblDisplay.Text = LblDisplay.Text + "    " + Convert.ToString(x);
            }

        }
    }
}
