using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = true;

            Bank b = new Bank();
           // Bank c = new Bank();


            while (quit)
            {
                Console.WriteLine(" ");
                Console.WriteLine("* Open a Bank Account.");
                Console.WriteLine("* Perform Transaction for an account.");
                Console.WriteLine("* Exit the application");

                Console.Write("\nSelect a option: ");
                string c1 = Console.ReadLine();

                switch (c1)
                {
                    case "open":
                        Console.WriteLine(" ");
                        Console.WriteLine("* Open Savings Account");
                        Console.WriteLine("* Open Checking Account");
                        Console.WriteLine("* Exit from the application");

                        Console.Write("\nSelect a option: ");
                        string c2 = Console.ReadLine();
                        
                        switch (c2)
                        {
                            case "savings":
                                Console.Write("\nEnter your account name: ");
                                string name = Console.ReadLine();
                                Console.Write("Enter your date of birth: ");
                                string dateofbirth = Console.ReadLine();
                                Console.Write("Enter your address: ");
                                string address = Console.ReadLine();
                                Console.Write("Enter your balance: ");
                                double balance =Convert.ToDouble( Console.ReadLine());

                                b.CreateSavingsAccount(new Savings { AccountName = name, DateOfBirth = dateofbirth, Address = address, Balance = balance });
                                Console.WriteLine(" ");
                                b.PrintAccount(name);


                                break;
                            case "checking":
                                Console.Write("\nEnter your account name: ");
                                string name2 = Console.ReadLine();
                                Console.Write("Enter your date of birth: ");
                                string dateofbirth2 = Console.ReadLine();
                                Console.Write("Enter your address: ");
                                string address2 = Console.ReadLine();
                                Console.Write("Enter your balance: ");
                                double balance2 = Convert.ToDouble(Console.ReadLine());

                                b.CreatecheckingAccount(new checking() { AccountName = name2, DateOfBirth = dateofbirth2, Address = address2, Balance = balance2 });
                                Console.WriteLine(" ");
                                b.PrintAccount2(name2);

                                break;
                            case "quit":
                                Console.WriteLine("--Successfully exited from system--");
                                quit = false;
                                break;
                        }

                        break;
                    case "account":
                        Console.WriteLine(" ");
                        Console.WriteLine("* Deposit money in an account.");
                        Console.WriteLine("* Withdraw money from an account.");
                        Console.WriteLine("* Transfer money to another account.");
                        Console.WriteLine("* Change the owner name.");
                        Console.WriteLine("* Display the number of transaction & closing balance");
                        Console.WriteLine("* Exit From the application.");

        
                        Console.Write("\nSelect a option: ");
                        string c3 = Console.ReadLine();

                        switch (c3)
                        {
                            case "deposit":
                                Console.Write("\nEnter account name: ");
                                string name1 = Console.ReadLine();
                                Console.Write("Enter account type: ");
                                string type1 = Console.ReadLine();
                                Console.Write("Enter amount: ");
                                double amount1 =Convert.ToDouble(Console.ReadLine());

                                if (type1=="savings")
                                {
                                    b.DepositAccount(name1, amount1);
                                }
                                else if(type1 == "checking"){
                                    b.DepositAccount2(name1, amount1);
                                    
                                }

                                break;
                            case "withdraw":
                                Console.Write("\nEnter account name: ");
                                string name2 = Console.ReadLine();
                                Console.Write("Enter account type: ");
                                string type2 = Console.ReadLine();
                                Console.Write("Enter amount: ");
                                double amount2 = Convert.ToDouble(Console.ReadLine());

                                if (type2 == "savings")
                                {
                                    b.WithdrawAccount(name2, amount2);
                                }
                                else if (type2 == "checking")
                                {
                                    b.WithdrawAccount2(name2, amount2);

                                }

                                break;
                            case "transfer":

                                break;
                            case "change":
                                Console.Write("\nEnter your previous account name: ");
                                string name3 = Console.ReadLine();
                                Console.Write("Enter account type: ");
                                string type3 = Console.ReadLine();
                                Console.Write("Enter your current name: ");
                                string name4 = Console.ReadLine();

                                //  b.ChangeName(name3, name4);
                                if (type3 == "savings")
                                {
                                    b.ChangeName(name3, name4);
                                }
                                else if (type3 == "checking")
                                {
                                    b.ChangeName2(name3, name4);

                                }

                                break;
                            case "show":
                                Console.Write("\nEnter your Account Name: ");
                                string name5 = Console.ReadLine();
                                Console.Write("Enter account type: ");
                                string type5 = Console.ReadLine();
                                //b.ShowTransaction(name5);
                                if (type5 == "savings")
                                {
                                    b.ShowTransaction(name5);
                                }
                                else if (type5 == "checking")
                                {
                                    b.ShowTransaction2(name5);

                                }

                                break;
                            case "quit":
                                Console.WriteLine("!--Successfully exited from system--!");
                                quit = false;
                                break;
                            
                        }


                        break;
                    case "quit":
                        Console.WriteLine("!--Successfully exited from system--!");
                        quit = false;
                        break;
                }


            }
        }
    }
}
