using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        public Logger Log = new Logger();
        public Dictionary<string, IVendingItem> VendingMachineItems = new Dictionary<string, IVendingItem>();
        FileHandler HandleFiles = new FileHandler();
        public Money Money;


        public VendingMachine()
        {
            this.VendingMachineItems = HandleFiles.GetVendingItems();
            this.Money = new Money(this.Log);

        }

        public bool ItemExists(string itemNumber)
        {
            return VendingMachineItems.ContainsKey(itemNumber);
        }

        public bool RetreiveItem(string itemNumber)
        {
            // If the item exists (not Q1 or something like that)
            // and we can remove the item
            // and we have more money in the machine than the price
            if (ItemExists(itemNumber)
                && VendingMachineItems[itemNumber].RemoveItem()
                && Money.MoneyInMachine >= VendingMachineItems[itemNumber].Price)
            {
                // Logging message "CANDYBARNAME A1"
                string message = $"{VendingMachineItems[itemNumber].ProductName.ToUpper()} {itemNumber}";

                // Logging before: current money in machine
                decimal before = Money.MoneyInMachine;

                // Remove the money
                Money.RemoveMoney(VendingMachineItems[itemNumber].Price);

                // Logging after: current money in machine
                decimal after = Money.MoneyInMachine;

                // Log the log
                Log.Log(message, before, after);

                return true;
            }
            else if (Money.MoneyInMachine < VendingMachineItems[itemNumber].Price)
            {
                Console.WriteLine("Not enough money in the machine to complete the transaction.");
            }
            return false;
        }
    }
}
