using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Drink : VendingMachineItem
    {
        private string Display { get; }

        public Drink() : base()
        {
            Display = "Glug Glug, Yum!";
        }

        public Drink(string slotPosition, string name) : base(slotPosition, name)
        {
            Display = "Glug Glug, Yum!";
        }

        public Drink(string slotPosition, string name, decimal price)
        {
            Display = "Glug Glug, Yum!";
        }



        public override string DisplayMessage()
        {
            return Display;
        }
    }
}
