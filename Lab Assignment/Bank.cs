using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment
{
    class Bank
    {
        Savings[] accounts1=new Savings[2];
        checking[] accounts2=new checking[2];
        

        //public Bank(int size)
        //{
        //    this.accounts1 = new Savings[size];
        //    this.accounts2 = new checking[size];
        //}

        public void CreateSavingsAccount(Savings account)
        {
            for(int i = 0; i < accounts1.Length; i++)
            {
                if (accounts1[i] == null)
                {
                    accounts1[i] = account;
                    break;
                }
            }
        }

        public void CreatecheckingAccount(checking account)
        {
            for (int i = 0; i < accounts1.Length; i++)
            {
                if (accounts2[i] == null)
                {
                    accounts2[i] = account;
                    break;
                }
            }
        }

        public void DepositAccount(string accountName, double amount)
        {
            for(int i = 0; i <= accounts1.Length; i++)
            {
                if (accounts1[i].AccountName == accountName)
                {
                    accounts1[i].Deposit(amount);
                    Console.WriteLine("\nSuccessfully deposited " + amount);
                    Console.WriteLine("Current balance: " + accounts1[i].Balance);
                    break;
                }
            }

        }

        public void DepositAccount2(string accountName, double amount)
        {
            for (int i = 0; i <= accounts2.Length; i++)
            {
                if (accounts2[i].AccountName == accountName)
                {
                    accounts2[i].Deposit(amount);
                    Console.WriteLine("\nSuccessfully deposited " + amount);
                    Console.WriteLine("Current balance: " + accounts2[i].Balance);
                    break;
                }
            }

        }

        public void WithdrawAccount(string accountName, double amount)
        {
            for (int i = 0; i <= accounts1.Length; i++)
            {
                if (accounts1[i].AccountName == accountName)
                {
                    accounts1[i].Withdraw(amount);               
                    Console.WriteLine("Current balance: " +accounts1[i].Balance);
                    break;
                }
            }
        }

        public void WithdrawAccount2(string accountName, double amount)
        {
            for (int i = 0; i <= accounts2.Length; i++)
            {
                if (accounts2[i].AccountName == accountName)
                {
                    accounts2[i].Withdraw(amount);
                    Console.WriteLine("Successfully withdrawn: "+amount);
                    Console.WriteLine("Current balance: " + accounts2[i].Balance);
                    break;
                }
            }
        }

        public void ChangeName(string accountName,string updatedName)
        {
            for (int i=0;i<=accounts1.Length;i++)
            {
                if(accounts1[i].AccountName == accountName)
                {
                    accounts1[i].ChangeName(updatedName);
                    break;
                }
            }
        }

        public void ChangeName2(string accountName, string updatedName)
        {
            for (int i = 0; i <= accounts2.Length; i++)
            {
                if (accounts2[i].AccountName == accountName)
                {
                    accounts2[i].ChangeName(updatedName);
                    break;
                }
            }
        }

        public void ShowTransaction(string accountName)
        {
            for (int i = 0; i <= accounts1.Length; i++)
            {
                if (accounts1[i].AccountName == accountName)
                {
                    accounts1[i].ShowTransaction();
                    break;

                }
            }

        }

        public void ShowTransaction2(string accountName)
        {
            for (int i = 0; i <= accounts2.Length; i++)
            {
                if (accounts2[i].AccountName == accountName)
                {
                    accounts2[i].ShowTransaction();
                    break;
                }
            }

        }


        public void PrintAccount(string accountName)
        {
        
            for (int i = 0; i < accounts1.Length; i++)
            {  
                if (accounts1[i].AccountName == accountName)
                {
                    accounts1[i].Display();
                    break;
                }
                
            }

           
        }

        public void PrintAccount2(string accountName)
        {

            for (int i = 0; i < accounts1.Length; i++)
            {
                if (accounts2[i].AccountName == accountName)
                {
                    accounts2[i].Display();
                    break;
                }

            }


        }




    }
}
