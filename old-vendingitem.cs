using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public abstract class VendingItem
    {
        /// <summary>
        /// The name of the VendingItem
        /// </summary>
        public string ProductName { get; private set; }

        /// <summary>
        /// The price of the VendingItem
        /// </summary>
        public decimal Price { get; private set; }

        /// <summary>
        /// How many of each VendingItem remains
        /// </summary>
        public int ItemsRemaining { get; private set; }

        /// <summary>
        /// What the menu displays when the VendingItem is vended
        /// </summary>
        public string MessageWhenVended { get; private set; }

        public VendingItem(string productName, decimal price, int itemsRemaining, string messageWhenVended)
        {
            this.ProductName = productName;
            this.Price = price;
            this.ItemsRemaining = itemsRemaining;
            this.MessageWhenVended = messageWhenVended;
        }

    }
}
