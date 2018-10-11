using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Chips : IVendingItem
    {
        public Chips(
            string productName,
            decimal price,
            int itemsRemaining) : base(
                productName, 
                price, 
                itemsRemaining, 
                "Crunch, Crunch, Yum!"
                )
        {
            // TODO: do we need something here???
        }
    }
}
