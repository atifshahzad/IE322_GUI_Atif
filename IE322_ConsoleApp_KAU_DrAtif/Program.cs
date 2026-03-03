using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IE322_App_KAU;

namespace IE322_ConsoleApp_KAU_DrAtif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to IE322");

            //Creating an object of the class BankAccount

            
          BankAccount myAccount = new BankAccount();
          BankAccount yourAccount = new BankAccount("123456789");
          BankAccount hisAccount = new BankAccount(1234);
            BankAccount herAccount = new BankAccount(1233);

            Console.WriteLine($"Total Accounts are:{BankAccount.GetTotalAccounts()}");

            //Calling the methods of the class BankAccount
            myAccount.Deposit(100);
           yourAccount.Deposit(200);
           hisAccount.Deposit(300);
           hisAccount.Deposit(100);
           herAccount.Deposit(200); 
            hisAccount.Withdraw(100);

            // Console.WriteLine(myAccount.CheckBalance().ToString());
            Console.WriteLine($"My account with account number {myAccount.AccountNumber} has {myAccount.CheckBalance():C}");
            Console.WriteLine($"Your account with account number {yourAccount.AccountNumber} has {yourAccount.CheckBalance():C}");
            Console.WriteLine($"His account with account number {hisAccount.AccountNumber} has {hisAccount.CheckBalance():C}");
            Console.WriteLine($"Her account with account number {herAccount.AccountNumber} has {herAccount.CheckBalance():C}");

            Console.ReadKey();


            Random rnd = new Random();

            
            Console.WriteLine(rnd.Next(1,10));//Returns a positive random integer within the specified minimum and maximum range(includes min and excludes max).

            Console.WriteLine($"{rnd.Next(60,100):C}");

            Console.WriteLine(rnd.Next()); // Returns a positive random integer within the default range - 2,147,483,648 to 2,147,483, 647.

            Console.WriteLine(rnd.Next(40));// Returns a positive random integer that is less than the specified maximum value.

            Console.WriteLine(rnd.NextDouble());

            Console.WriteLine("Generating another set of random numbers");
            
            Random rnd2 = new Random();

            Console.WriteLine(rnd2.Next(30, 90));
            Console.WriteLine(rnd2.Next(30, 90)); 
            Console.WriteLine(rnd2.Next(30, 90));
            Console.WriteLine(rnd2.Next(30, 90));



        }
    }
}
