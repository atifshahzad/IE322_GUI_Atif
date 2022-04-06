namespace IE322_App_KAU
{
    class BankAccount
    {
        double Balance = 0;

        //Default Constructor
        public BankAccount()
        { 
            Balance += 100; 
        }

        //An Overloaded Constructor
        public BankAccount(string ID)
        {
            Balance += 200;
        }

        //Another Overloaded Constructor
        public BankAccount(int CouponCode)
        {
            if (CouponCode == 1234)    
                Balance += 150;
        }


        public bool Deposit(double n)
        {
            if (n > 0)
            {
                Balance += n;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Withdraw(double n)
        {
            if (Balance >= n && n > 0)
            {
                Balance -= n;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CheckBalance()
        {
            return (Balance);
        }
        public bool Transfer(BankAccount ToAccount, double Amount)
        {
            if (this.Withdraw(Amount))
            {
                ToAccount.Deposit(Amount);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}