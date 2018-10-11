using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Candies : IVendingItem
    {
        public Candies(
            string productName,
            decimal price,
            int itemsRemaining) : base(
                productName, 
                price, 
                itemsRemaining, 
                "Munch, Munch, Yum!"
                )
        {
            // TODO: do we need something here???
        }
    }
}
