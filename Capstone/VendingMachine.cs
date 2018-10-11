using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        public Dictionary<string, IVendingItem> VendingMachineItems = new Dictionary<string, IVendingItem>();
        FileHandler HandleFiles = new FileHandler();
        public Money Money = new Money();

        public VendingMachine()
        {
            this.VendingMachineItems = HandleFiles.GetVendingItems();

        }

        public bool ItemExists(string itemNumber)
        {
            return VendingMachineItems.ContainsKey(itemNumber);
        }

        public bool RetreiveItem(string itemNumber)
        {
            if (ItemExists(itemNumber)
                && VendingMachineItems[itemNumber].RemoveItem()
                && Money.MoneyInMachine >= VendingMachineItems[itemNumber].Price)
            {
                Money.RemoveMoney(VendingMachineItems[itemNumber].Price);
                return true;
            }
            else if (!ItemExists(itemNumber))
            {
                Console.WriteLine("Item does not exist");
            }
            else if (!VendingMachineItems[itemNumber].RemoveItem())
            {
                Console.WriteLine("Unable to remove item. Whoops!");
            }
            else if (Money.MoneyInMachine < VendingMachineItems[itemNumber].Price)
            {
                Console.WriteLine("Not enough money in the machine to complete the transaction.");
            }
            return false;
        }
    }
}
