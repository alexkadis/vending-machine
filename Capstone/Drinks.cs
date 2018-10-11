using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Drinks : IVendingItem
    {
        public Drinks(
            string productName,
            decimal price,
            int itemsRemaining) : base(
                productName, 
                price, 
                itemsRemaining, 
                "Glug, Glug, Yum!"
                )
        {
            // TODO: do we need something here???
        }
    }
}
