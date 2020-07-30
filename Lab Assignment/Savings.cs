using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment
{
    class Savings : Account
    {
        double minbalance = 5000;

        public override void Deposit(double amount)
        {
            base.Deposit(amount);

        }

        override public void Withdraw(double amount)
        {
            Console.WriteLine("Fixed Amount for Savings Acc is: " + minbalance);
            Console.WriteLine("");

            if ((base.Balance -= amount) >= minbalance)
            {
                base.transaction += 1;
                Console.WriteLine("Withdrawn " + amount);           
            }
            else
            {
                base.Balance += amount;
                Console.WriteLine("!--minimum withdraw-limit has been reached--!");
            }
        }

        override public void Transfer(Account receiver, double amount)
        {
            this.Withdraw(amount);
            receiver.Deposit(amount);
        }

       override public void ChangeName(string name)
        {
            base.AccountName = name;
            Console.WriteLine("Seccussfully name changed into: "+base.AccountName);
        }

        override public void ShowTransaction()
        {
            Console.WriteLine("Tottal transaction: "+base.transaction);
        }
    }
}
