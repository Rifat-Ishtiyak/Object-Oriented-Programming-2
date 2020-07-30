using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment
{
    class checking:Account
    {
        public override void Deposit(double amount)
        {
            base.Deposit(amount);
        }

        override public void Withdraw(double amount)
        {
            
            base.Withdraw(amount);
        }

        override public void Transfer(Account receiver, double amount)
        {
            this.Withdraw(amount);
            receiver.Deposit(amount);
        }

        override public void ChangeName(string name)
        {
            base.AccountName = name;
            Console.WriteLine("Seccussfully name changed into: " + base.AccountName);
        }

        override public void ShowTransaction()
        {
            Console.WriteLine("Tottal transaction: " + base.transaction);
        }
    }
}
