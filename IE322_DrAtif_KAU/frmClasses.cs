using System;
using System.Windows.Forms;
using System.Xml;

namespace IE322_App_KAU
{
    public partial class frmClasses : Form
    {
        Car MyCar = new Car();
        Car HisCar = new Car();

        Truck MyTruck = new Truck();






        BankAccount AliAccount = new BankAccount();
        BankAccount MariaAccount = new BankAccount(1234);// Coupon code constructor is called



        public frmClasses()
        {
            InitializeComponent();
            PgbMyCar.Minimum = 0;
            PgbMyCar.Maximum = 260;

            PgbHisCar.Minimum = 0;
            PgbHisCar.Maximum = 220;
        }

        private void BtnStartMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Start(); // calling the start method for MyCar
            PgbMyCar.Value = MyCar.speed;
            this.BtnStartMyCar.Enabled = false;
            
        }

        private void BtnStartHisCar_Click(object sender, EventArgs e)
        {
            HisCar.Start();
            PgbHisCar.Value = HisCar.speed;
            this.BtnStartHisCar.Enabled = false;

        }

        private void BtnAccMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Accelerate(30);
            PgbMyCar.Value = MyCar.speed;
            //MessageBox.Show(Convert.ToString(MyCar.speed));
        
        }

        private void BtnStopHisCar_Click(object sender, EventArgs e)
        {
            HisCar.Stop();
            PgbHisCar.Value = HisCar.speed;
            this.BtnStartHisCar.Enabled = true;

        }

        private void BtnStopMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Stop();
            PgbMyCar.Value = MyCar.speed;
            this.BtnStartMyCar.Enabled = true;
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
            TxtBalanceAli.Text = AliAccount.CheckBalance().ToString();
            TxtBalanceMaria.Text = MariaAccount.CheckBalance().ToString();
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                AliAccount.Deposit(Convert.ToDouble(TxtAmountAli.Text));// Now deposit some amount                
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid amount, please");
                return;
            }
            
            TxtBalanceAli.Text=$"{AliAccount.CheckBalance():C}";
        }

        private void BtnWithdraw_Click_1(object sender, EventArgs e)
        {
            try
            {
                AliAccount.Withdraw(Convert.ToDouble(TxtAmountAli.Text));// Now deposit some amount                
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid amount, please");
                return;
            }
            TxtBalanceAli.Text = AliAccount.CheckBalance().ToString();
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
                if (AliAccount.Transfer(MariaAccount, Convert.ToDouble(TxtAmountAli.Text)))
                {
                    TxtBalanceAli.Text = AliAccount.CheckBalance().ToString();
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
                    TxtBalanceAli.Text = AliAccount.CheckBalance().ToString();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
