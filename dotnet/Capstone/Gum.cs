using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Gum : VendingMachineItem
    {
        private string Display { get; }

        public Gum() : base()
        {
            Display = "Chew Chew, Yum!";
        }

        public Gum(string slotPosition, string name) : base(slotPosition, name)
        {
            Display = "Chew Chew, Yum!";
        }

        public Gum(string slotPosition, string name, decimal price) : base (slotPosition, name, price)
        {
            Display = "Chew Chew, Yum!";
        }

        public override string DisplayMessage()
        {
            return Display;
        }
    }
}
