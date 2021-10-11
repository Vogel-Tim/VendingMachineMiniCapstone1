using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Items
{
    public class Candy : VendingMachineItem
    {
        public string Display { get; }

        public Candy() : base()
        {
            Display = "Munch Munch, Yum!";
        }

        public Candy(string slotPosition, string name, decimal price) : base (slotPosition, name, price)
        {
            Display = "Munch Munch, Yum!";
        }

        public override string DisplayMessage()
        {
            return Display;
        }
    }
}
