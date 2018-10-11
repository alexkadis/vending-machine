using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone
{
    public class FileHandler
    {
        public Dictionary<string, IVendingItem> GetVendingItems()
        {
            Dictionary<string, IVendingItem> items = new Dictionary<string, IVendingItem>();

            using (StreamReader sr = new StreamReader("vendingmachine.csv"))
            {
                while (!sr.EndOfStream)
                {
                    // Read the line
                    string line = sr.ReadLine();

                    string[] itemDetails = line.Split("|");

                    string itemName = itemDetails[1];

                    if(!decimal.TryParse(itemDetails[2], out decimal itemPrice))
                    {
                        itemPrice = 0M;
                    }

                    int itemsRemaining = 5;

                    IVendingItem item;
                    
                    switch (itemDetails[3])
                    {
                        case "Chip":
                            item = new Drinks(itemName, itemPrice, itemsRemaining);
                            break;
                        case "Drink":
                            item = new Drinks(itemName, itemPrice, itemsRemaining);
                            break;
                        case "Gum":
                            item = new Gum(itemName, itemPrice, itemsRemaining);
                            break;
                        default:
                            // CANDY IS THE DEFAULT AS IT SHOULD BE AND ALWAYS WILL
                            item = new Chips(itemName, itemPrice, itemsRemaining);
                            break;
                    }

                    items.Add(itemDetails[0], item);
                }
            }
            return items;
        }
    }
}
