namespace Capstone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SubMenu
    {
        private VendingMachine vm;

        public SubMenu(VendingMachine vm)
        {
            this.vm = vm;
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
                Console.WriteLine($"Money in Machine: {this.vm.MoneyInMachine.ToString("C")}");
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
                            if (!this.vm.Money.AddMoney(amountToSubmit))
                            {
                                Console.WriteLine("Insert a valid amount.");
                            }
                            else
                            {
                                Console.WriteLine($"Money in Machine: {this.vm.Money.MoneyInMachine.ToString("C")}");
                                break;
                            }
                        }
                    }

                }
                else if (input == "2")
                {
                    while (true)
                    {
                        this.vm.DisplayAllItems();
                        Console.Write(">>> What item do you want? ");
                        string choice = Console.ReadLine();

                        if (this.vm.ItemExists(choice) && vm.RetreiveItem(choice))
                        {
                            Console.WriteLine($"Enjoy your {vm.VendingMachineItems[choice].ProductName}\n{this.vm.VendingMachineItems[choice].MessageWhenVended}");
                            break;
                        }
                        else if (!this.vm.ItemExists(choice))
                        {
                            Console.Clear();
                            Console.WriteLine("**INVALID ITEM**");
                        }
                        else if (this.vm.ItemExists(choice) && this.vm.Money.MoneyInMachine > this.vm.VendingMachineItems[choice].Price)
                        {
                            Console.WriteLine(this.vm.VendingMachineItems[choice].MessageWhenSoldOut);
                        }
                        else if (this.vm.Money.MoneyInMachine < vm.VendingMachineItems[choice].Price)
                        {
                            Console.WriteLine(this.vm.NotEnoughMoneyError);
                            break;
                        }
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Finishing Transaction");
                    Console.WriteLine(this.vm.Money.GiveChange());
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
