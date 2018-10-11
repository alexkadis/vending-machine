using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Menu
    {
        VendingMachine VM = new VendingMachine();


        public void Display()
        {
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
                    
                    foreach (KeyValuePair<string, IVendingItem> kvp in VM.VendingMachineItems )
                    {
                        if(kvp.Value.ItemsRemaining > 0)
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value.ItemsRemaining} { kvp.Value.ProductName }. Costs: { kvp.Value.Price.ToString("C")} each.");
                        }
                        else
                        {
                            Console.WriteLine($"{kvp.Key}: { kvp.Value.ProductName } IS SOLD OUT.");
                        }
                    }
                }
                else if (input == "2")
                {
                    SubMenu submenu = new SubMenu(VM);
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




        private static void PrintHeader()
        {
            Console.WriteLine("WELCOME TO THE BEST VENDING MACHINE EVER!!!! (Distant crowd roar)");
        }

    }
}
