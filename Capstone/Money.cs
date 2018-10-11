using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Money
    {
        public decimal MoneyInMachine { get; private set; }

        public Money()
        {
            this.MoneyInMachine = 0;
        }

        public bool AddMoney(string amount)
        {
            if (!decimal.TryParse(amount, out decimal amountInserted))
            {
                amountInserted = 0M;
                return false;
            }
            this.MoneyInMachine += amountInserted;
            return true;
        }

        public bool RemoveMoney(decimal amountToRemove)
        {
            if (this.MoneyInMachine <= 0)
            {
                return false;
            }
            
            this.MoneyInMachine -= amountToRemove;
            return true;
        }

        public string GiveChange()
        {
            string result = "";
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            if(this.MoneyInMachine > 0)
            {
                while (this.MoneyInMachine > 0)
                {
                    if(this.MoneyInMachine >= 0.25M)
                    {
                        quarters++;
                        this.RemoveMoney(0.25M);
                    }
                    else if (this.MoneyInMachine >= 0.10M)
                    {
                        dimes++;
                        this.RemoveMoney(0.10M);
                    }
                    else if (this.MoneyInMachine >= 0.05M)
                    {
                        nickels++;
                        this.RemoveMoney(0.05M);
                    }
                }
                result = $"Your change is {quarters} quarters, {dimes} dimes, and {nickels} nickels";
            }
            else
            {
                result = "No money to return";
            }
            return result;
        }
    }
}