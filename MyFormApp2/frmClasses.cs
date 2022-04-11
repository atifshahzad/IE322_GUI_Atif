using System;
using System.Windows.Forms;

namespace IE322_App_KAU
{
    public partial class frmClasses : Form
    {
        Car MyCar = new Car();
        Car HisCar = new Car();

        Truck MyTruck = new Truck();

        BankAccount AliAccount = new BankAccount();
        BankAccount MariaAccount = new BankAccount();



        public frmClasses()
        {
            InitializeComponent();
        }

        private void BtnStartMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Start(); // calling the start method for MyCar
        }

        private void BtnStartHisCar_Click(object sender, EventArgs e)
        {
            HisCar.Start();
        }

        private void BtnAccMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Accelerate(30);
            MessageBox.Show(Convert.ToString(MyCar.speed));
        
        }

        private void BtnStopHisCar_Click(object sender, EventArgs e)
        {
            HisCar.Stop();
        }

        private void BtnStopMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Stop();
        }

        private void BtnStartMyTruck_Click(object sender, EventArgs e)
        {
            //  BtnStartMyTruck.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmClasses_Load(object sender, EventArgs e)
        {
            TxtBalance.Text = AliAccount.CheckBalance().ToString();
            TxtBalanceMaria.Text = MariaAccount.CheckBalance().ToString();
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                AliAccount.Deposit(Convert.ToDouble(TxtAmount.Text));// Now deposit some amount                
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid amount, please");
                return;
            }
            TxtBalance.Text = AliAccount.CheckBalance().ToString();
        }

        private void BtnWithdraw_Click_1(object sender, EventArgs e)
        {
            try
            {
                AliAccount.Withdraw(Convert.ToDouble(TxtAmount.Text));// Now deposit some amount                
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid amount, please");
                return;
            }
            TxtBalance.Text = AliAccount.CheckBalance().ToString();
        }

        private void BtnCheckBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your current Balance is: " + AliAccount.CheckBalance());
        }

        private void BtnDepositMaria_Click(object sender, EventArgs e)
        {
            try
            {
                MariaAccount.Deposit(Convert.ToDouble(TxtAmountMaria.Text));// Now deposit some amount                
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid amount, please");
                return;
            }
            TxtBalanceMaria.Text = MariaAccount.CheckBalance().ToString();
        }

        private void BtnWithdrawMaria_Click(object sender, EventArgs e)
        {
            try
            {
                MariaAccount.Withdraw(Convert.ToDouble(TxtAmountMaria.Text));// Now deposit some amount                
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid amount, please");
                return;
            }
            TxtBalanceMaria.Text = MariaAccount.CheckBalance().ToString();
        }

        private void BtnCheckBalanceMaria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your current Balance is: " + MariaAccount.CheckBalance());
        }

        private void BtnTransferToMaria_Click(object sender, EventArgs e)
        {
            try
            {
                if (AliAccount.Transfer(MariaAccount, Convert.ToDouble(TxtAmount.Text)))
                {
                    TxtBalance.Text = AliAccount.CheckBalance().ToString();
                    TxtBalanceMaria.Text = MariaAccount.CheckBalance().ToString();
                }
                else
                {
                    MessageBox.Show("Transfer failed.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid amount, please");
                return;
            }
            
        }

        private void BtnTransferToAli_Click(object sender, EventArgs e)
        {
            try
            {
                if (MariaAccount.Transfer(AliAccount, Convert.ToDouble(TxtAmountMaria.Text)))
                {
                    TxtBalance.Text = AliAccount.CheckBalance().ToString();
                    TxtBalanceMaria.Text = MariaAccount.CheckBalance().ToString();
                }
                else
                {
                    MessageBox.Show("Transfer failed.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid amount, please");
                return;
            }        



        }
    }
}
