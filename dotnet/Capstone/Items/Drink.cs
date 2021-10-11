using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Items
{
    public class Drink : VendingMachineItem
    {
        public string Display { get; }

        public Drink()
        {
            Display = "Glug Glug, Yum!";
        }

        public Drink(string slotPosition, string name, decimal price) : base (slotPosition, name, price)
        {
            Display = "Glug Glug, Yum!";
        }

        public override string DisplayMessage()
        {
            return Display;
        }
    }
}
