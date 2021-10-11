using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Items
{
    public class Chip : VendingMachineItem
    {
        private string Display { get; }

        public Chip() : base()
        {
            Display = "Crunch Crunch, Yum!";
        }

        public Chip(string slotPosition, string name) : base(slotPosition, name)
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
