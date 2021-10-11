
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Items
{
    public class Chip : VendingMachineItem
    {
        public string Display { get; }

        public Chip() : base()
        {
            Display = "Crunch Crunch, Yum!";
        }

        public Chip(string slotPosition, string name, decimal price) : base (slotPosition, name, price)
        {
            Display = "Crunch Crunch, Yum!";
        }

        public override string DisplayMessage()
        {
            return Display;
        }
    }
}
