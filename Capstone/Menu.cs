using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    class Menu
    {
        public void Display()
        {
            while (true)
            {
                PrintHeader();

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
                }
                else if (input == "2")
                {
                    SubMenu submenu = new SubMenu();
                    submenu.Display();
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




        private void PrintHeader()
        {
            Console.WriteLine("WELCOME TO THE BEST VENDING MACHINE EVER!!!! (Distant crowd roar)");
        }

    }
}
