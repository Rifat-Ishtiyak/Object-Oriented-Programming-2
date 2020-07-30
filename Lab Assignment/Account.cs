using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment
{
    class Account
    {
 
        string acname;
        string dob, address;
        double balance;
        public int transaction=0;

       public  Random r = new Random();
        int accountno;

        //public Account(String acname, String dob, String address, double balance)
        //{
        //    this.acname = acname;
        //    this.dob = dob;
        //    this.address = address;
        //    this.balance = balance;
        //}

        public string AccountName
        {
            set { this.acname = value;
                accountno = r.Next(100, 200); 
                }
            get { return this.acname; }
        }
        public string DateOfBirth
        {
            set { this.dob = value; }
            get { return this.dob; }
        }
        public string Address
        {
            set { this.address = value; }
            get { return this.address; }

        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        } 
        public int AccountNumber
        {
            //set { this.accountno=r.Next(100,200); }
            get { return accountno; }
        }

        virtual public void Deposit(double amount)
        {
            balance += amount;
            transaction+=1;
        } 

        virtual public void Withdraw(double amount)
        {
            balance -= amount;
            transaction += 1;
        }

       virtual public void Transfer(Account receiver, double amount)
        {
            this.Withdraw(amount);
            receiver.Deposit(amount);
        }

        virtual public void ChangeName(string name)
        {
            this.acname = name;
        }

        virtual public void ShowTransaction()
        {
            Console.WriteLine("Total Transaction: "+transaction);
        }

        public void Display()
        {
            Console.WriteLine("Account Name: "+AccountName);
            Console.WriteLine("Date of birth: "+DateOfBirth);
            Console.WriteLine("Address: "+Address);
            Console.WriteLine("Account Balacne: "+Balance);
            Console.WriteLine("Account Number: " + AccountNumber);
        }
      
    }
}
