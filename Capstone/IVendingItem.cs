using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public abstract class IVendingItem
    {
        /// <summary>
        /// The name of the VendingItem
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// The price of the VendingItem
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// How many of each VendingItem remains
        /// </summary>
        public int ItemsRemaining { get; set; }

        /// <summary>
        /// What the menu displays when the VendingItem is vended
        /// </summary>
        public string MessageWhenVended { get; set; }

        public IVendingItem()
        {

        }

        public IVendingItem(string productName, decimal price, int itemsRemaining, string messageWhenVended)
        {
            this.ProductName = productName;
            this.Price = price;
            this.ItemsRemaining = itemsRemaining;
            this.MessageWhenVended = messageWhenVended;
        }


        /// <summary>
        /// Returns false if it can't get the item
        /// </summary>
        /// <param name="itemNumber"></param>
        /// <returns></returns>
        public bool RemoveItem()
        {
            if(ItemsRemaining > 0)
            {
                ItemsRemaining--;
                return true;
            }
            return false;
        }
    }
}
