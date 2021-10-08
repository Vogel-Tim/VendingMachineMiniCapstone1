using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Candy : VendingMachineItem
    {
       
        private string Display { get; }

        public Candy() : base()
        {
            Display = "Munch Munch, Yum!";
        }

        public Candy(string slotPosition, string name) : base (slotPosition, name)
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
