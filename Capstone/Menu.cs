namespace Capstone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Menu
    {



        public void Display()
        {
            VendingMachine vm = new VendingMachine();

            PrintHeader();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1] Display Vending Machine Items");
                Console.WriteLine("2] Purchase");
                Console.WriteLine("Q] Quit");

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Displaying Items");
                    vm.DisplayAllItems();
                }
                else if (input == "2")
                {
                    SubMenu subMenu = new SubMenu(vm);
                    subMenu.Display();
                }
                else if (input.ToUpper() == "Q")
                {
                    Console.WriteLine("Quitting");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void PrintHeader()
        {
            Console.WriteLine("WELCOME TO THE BEST VENDING MACHINE EVER!!!! (Distant crowd roar)");
        }

    }
}
