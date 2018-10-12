using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Drink : VendingItem
    {
        const string Message = "Glug, Glug, Yum!";

        public Drink(
            string productName,
            decimal price,
            int itemsRemaining) : base(
                productName, 
                price, 
                itemsRemaining, 
                Message
                )
        {
        }
    }
}
