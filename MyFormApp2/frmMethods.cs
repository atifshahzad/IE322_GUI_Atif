using System;
using System.Drawing;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmMethods : Form
    {
        double a, b;

        double Balance = 1000; // not a local variable to a method


        public frmMethods()
        {
            InitializeComponent();
        }

        private void frmMethods_Load(object sender, EventArgs e)
        {
            TxtBalance.BackColor = Color.Yellow;
            TxtBalance.Text = Balance.ToString();
        }


    // *****************  For Calcultor Operations **************************
        private void BtnCalculate_Click(object sender, EventArgs e)
        {         
            try
            {
                a = Convert.ToDouble(TxtA.Text);
                b = Convert.ToDouble(TxtB.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Enter valid numbers");
                return;
            }
            

            MessageBox.Show("Sum of a and b is " + Add(a, b) +
               "" + "\nDifference of a and b is " + Subtract(a, b) +
               "" + "\nProduct of a and b is " + Multiply(a, b) +
               "" + "\nDividing  a by b is " + Divide(a, b) +
               "" + "\nRemainder of a and b is " + Rem(a, b)
              ,"Result" );               
        }

       // Following are different calculation Methods
       // Add has two input parameters named as a and b.

        private double Add(double a, double b)
        {                 // body of the method Add starts here
            return a + b;
        }                 //body of the method Add ends here
        
        private double Subtract(double a, double b)
        {
            return a - b;
        }
        private double Multiply(double a, double b)
        {
            double c;
            c = a * b;
            return c;
        }
        private double Divide(double a, double b)
        {
            return a / b;
        }
        private double Rem(double a, double b)
        {
            return a % b;
        }

    // ****************** Following are Methods related to ATM operations  **************

        private void Deposit(double n)
        {
            Balance += n;
        }
        private void Withdraw(double n)
        {
            if (Balance>=n)
            {
                Balance -= n;
            }            
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {          
            try
            {                
                Deposit(Convert.ToDouble(TxtAmount.Text));// Now deposit some amount
                MessageBox.Show("Amount to be deposited is: " + TxtAmount.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid amount, please");
                return;
            }
            TxtBalance.Text = Balance.ToString();
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
           try
            {
               
                Withdraw(Convert.ToDouble(TxtAmount.Text));//Now Withdraw some amount
                MessageBox.Show("Amount to be withdrawn is: " + TxtAmount.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Enter valid amount, please");
                return;
            }
           
            TxtBalance.Text = Balance.ToString();
        }

        private void BtnCheckBalance_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Your current Balance is: " + CheckBalance());
        }

        private double CheckBalance()
        {
            return (Balance);
        }

//******************************************************************
//**********************************************************************


        private void BtnPrintSign_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TxtNumber.Text);
                
            }
            catch (Exception)
            {

                MessageBox.Show("Enter valid number");
                return;
            }
            MessageBox.Show(PrintSign(a));
        }
        private string PrintSign(double number)
        {
            if (number > 0)
            {
                return "Positive";
            }
            else if (number < 0)
            {
                return "Negative";
            }
            else
            {
                return "Zero";
            }
        }

        private void BtnPrintMax_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TxtA.Text);
                b = Convert.ToDouble(TxtB.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Enter valid numbers");
                return;
            }

            MessageBox.Show(PrintMax(a,b));
        }
        string PrintMax(double number1, double number2)
        {
            double max = number1;

            if (number2 > max)
            {
                max = number2;
            }
            return "Larger number is: " + max;
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
