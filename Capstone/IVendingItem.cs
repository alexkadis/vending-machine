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
        string ProductName { get; set; }

        /// <summary>
        /// The price of the VendingItem
        /// </summary>
        decimal Price { get; set; }

        /// <summary>
        /// How many of each VendingItem remains
        /// </summary>
        int ItemsRemaining { get; set; }

        /// <summary>
        /// What the menu displays when the VendingItem is vended
        /// </summary>
        string MessageWhenVended { get; set; }

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

    }
}
