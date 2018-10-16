namespace Capstone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Money
    {
        private Logger log;

        public Money(Logger log)
        {
            this.MoneyInMachine = 0M;
            this.log = log;
        }

        public decimal MoneyInMachine { get; private set; }

        public bool AddMoney(string amount)
        {
            if (!decimal.TryParse(amount, out decimal amountInserted))
            {
                amountInserted = 0M;
                return false;
            }

            string message = $"FEED MONEY: ";

            // Logging before: current money in machine
            decimal before = this.MoneyInMachine;

            // Add the money
            this.MoneyInMachine += amountInserted;

            // Logging after: current money in machine
            decimal after = this.MoneyInMachine;

            // Log the log
            this.log.Log(message, before, after);
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
            string result = string.Empty;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;

            // Logging message "CANDYBARNAME A1"
            string message = $"GIVE CHANGE: ";

            // Logging before: current money in machine
            decimal before = this.MoneyInMachine;

            if (this.MoneyInMachine > 0)
            {
                while (this.MoneyInMachine > 0)
                {
                    if (this.MoneyInMachine >= 0.25M)
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

                result = GetMessage(quarters, dimes, nickels);

                // Logging after: current money in machine
                decimal after = this.MoneyInMachine;

                // Log the log
                log.Log(message, before, after);
            }
            else
            {
                result = "No money to return";
            }

            return result;
        }

        private string GetMessage(int quarters, int dimes, int nickels)
        {
            string qS = string.Empty;
            string dS = string.Empty;
            string nS = string.Empty;

            if (quarters > 0)
            {
                qS = $"{quarters} quarters";
            }

            if (dimes > 0)
            {
                dS = $"{dimes} dimes";
            }

            if (nickels > 0)
            {
                nS = $"{nickels} nickels";
            }

            string result = $"Your change is ";

            if (quarters > 0 && dimes > 0 && nickels > 0)
            {
                result += $"{qS}, {dS}, and {nS}";
            }
            else if ((quarters > 0 && dimes > 0) || (quarters > 0 && nickels > 0))
            {
                result += $"{qS} and {dS}{nS}";
            }
            else if (dimes > 0 && nickels > 0)
            {
                result += $"{dS} and {nS}";
            }
            else if (quarters > 0 || dimes > 0 || nickels > 0)
            {
                result += $"{qS}{dS}{nS}";
            }
            else
            {
                result = "No change to give.";
            }

            return result;
        }
    }
}