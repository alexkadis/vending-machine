using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Gum : VendingItem
    {
        const string Message = "Chew, Chew, Yum!";

        public Gum(
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
