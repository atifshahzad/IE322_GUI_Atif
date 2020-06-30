namespace IE322_App_KAU
{
    class BankAccount
    {
        double Balance = 2000;

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
