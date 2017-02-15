using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3_EnhancingClass
{
    class BankTest
    {
        static void Main(string[] args)
        {
            Account a = new Account("001-001-001", "Tan Ah Kow", 2000);
            Account b = new Account("001-001-002", "Kim Keng Lee", 5000);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            a.Deposit(100);
            Console.WriteLine(a.Show());
            a.Withdraw(200);
            Console.WriteLine(a.Show());
            a.TransferTo(300, b);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
        }
    }

    class Account
    {
        //attributes
        string name;
        string accountNum;
        double initialAmt, currentAmt;

        //properties
        public string Show()
        {
            return(String.Format(accountNum+" "+name+" "+ "{0}",currentAmt));
        }
        //conductors
        public Account(string name, string accountNum, double initialAmt)
        {
            this.name = name;
            this.accountNum = accountNum;
            this.initialAmt = initialAmt;
            currentAmt = initialAmt;
        }
 
        //methods
        public void Deposit(double amount)
        {
            currentAmt = initialAmt + amount;
        }

        public void Withdraw(double amount)
        {
            currentAmt -= amount;
        }

        public void TransferTo(double amount, Account Another)
        {
            Withdraw(amount);
            Another.Deposit(amount);
        }
    }

}
