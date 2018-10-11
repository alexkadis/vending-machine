using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Gum : IVendingItem
    {
        public Gum(
            string productName,
            decimal price,
            int itemsRemaining) : base(
                productName, 
                price, 
                itemsRemaining, 
                "Chew, Chew, Yum!"
                )
        {
            // TODO: do we need something here???
        }
    }
}
