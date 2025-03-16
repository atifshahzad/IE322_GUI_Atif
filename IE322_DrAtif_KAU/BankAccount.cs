namespace IE322_App_KAU
{
    public class BankAccount
    {
        // Properties
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }
        public int AccountNumber { get; private set; }

        // Static field to track total accounts created
        private static int totalAccounts = 0;
        private static int accountNumberCounter = 1;
                       

        //Default Constructor
        public BankAccount()
        { 
            Balance += 100;
            AccountNumber = accountNumberCounter++;  // Unique account number
            totalAccounts++;
        }

        //An Overloaded Constructor
        public BankAccount(string accountHolder)
        {
            AccountHolder = accountHolder;
            Balance = 0;
            AccountNumber = accountNumberCounter++;  // Unique account number
            totalAccounts++;
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

        // Static method to get total accounts created
        public static int GetTotalAccounts()
        {
            return totalAccounts;
        }

    }
}
