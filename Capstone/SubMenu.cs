namespace Capstone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SubMenu
    {
        public VendingMachine VM;

        public SubMenu(VendingMachine vm)
        {
            this.VM = vm;
        }

        public void Display()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Please choose from the following options:");
                Console.WriteLine("1] >> Feed Money");
                Console.WriteLine("2] >> Select Product");
                Console.WriteLine("3] >> Finish Transaction");
                Console.WriteLine("Q] >> Return to Main Menu");
                Console.WriteLine($"Money in Machine: {this.VM.Money.MoneyInMachine.ToString("C")}");
                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine(">>> How much do you want to insert?");
                    while (true)
                    {
                        Console.Write("1, 2, 5, 10 dollars? ");
                        string amountToSubmit = Console.ReadLine();
                        if (amountToSubmit == "1"
                            || amountToSubmit == "2"
                            || amountToSubmit == "5"
                            || amountToSubmit == "10")
                        {
                            if (!this.VM.Money.AddMoney(amountToSubmit))
                            {
                                Console.WriteLine("Insert a valid amount.");
                            }
                            else
                            {
                                Console.WriteLine($"Money in Machine: {this.VM.Money.MoneyInMachine.ToString("C")}");
                                break;
                            }
                        }
                    }

                }
                else if (input == "2")
                {
                    while (true)
                    {
                        this.VM.DisplayAllItems();
                        Console.Write(">>> What item do you want? ");
                        string choice = Console.ReadLine();

                        if (this.VM.ItemExists(choice) && VM.RetreiveItem(choice))
                        {
                            Console.WriteLine($"Enjoy your {VM.VendingMachineItems[choice].ProductName}\n{this.VM.VendingMachineItems[choice].MessageWhenVended}");
                            break;
                        }
                        else if (!this.VM.ItemExists(choice))
                        {
                            Console.Clear();
                            Console.WriteLine("**INVALID ITEM**");
                        }
                        else if (this.VM.ItemExists(choice) && this.VM.Money.MoneyInMachine > this.VM.VendingMachineItems[choice].Price)
                        {
                            Console.WriteLine(this.VM.VendingMachineItems[choice].MessageWhenSoldOut);
                        }
                        else if (this.VM.Money.MoneyInMachine < VM.VendingMachineItems[choice].Price)
                        {
                            Console.WriteLine(this.VM.NotEnoughMoneyError);
                            break;
                        }
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Finishing Transaction");
                    Console.WriteLine(this.VM.Money.GiveChange());
                }
                else if (input.ToUpper() == "Q")
                {
                    Console.WriteLine("Returning to main menu");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }

                Console.ReadLine();
            }
        }
    }
}
