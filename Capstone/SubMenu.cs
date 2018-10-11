using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class SubMenu
    {
        public void Display()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("SubMenu 1");
                Console.WriteLine("1] >> Submenu Option 1");
                Console.WriteLine("2] >> Submenu Option 2");
                Console.WriteLine("Q] >> Return to Main Menu");

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Performing submenu option 1");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Performing submenu option 2");
                }
                else if (input == "Q")
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
