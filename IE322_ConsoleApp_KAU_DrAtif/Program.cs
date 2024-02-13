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

            //Calling the methods of the class BankAccount
            myAccount.Deposit(100);
            yourAccount.Deposit(200);
           hisAccount.Deposit(300);
           hisAccount.Deposit(100);

           // Console.WriteLine(myAccount.CheckBalance().ToString());
           Console.WriteLine(yourAccount.CheckBalance().ToString());
           Console.WriteLine(hisAccount.CheckBalance().ToString());


            Console.ReadKey();

        }
    }
}
