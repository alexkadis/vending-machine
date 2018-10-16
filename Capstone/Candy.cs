#pragma warning disable SA1633 // File must have header
namespace Capstone
#pragma warning restore SA1633 // File must have header
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Candy : VendingItem
    {
        public const string Message = "Munch, Munch, Yum!";

        public Candy(
            string productName,
            decimal price,
            int itemsRemaining)
                : base(
                productName,
                price,
                itemsRemaining,
                Message)
        {
        }
    }
}
