using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public abstract class VendingMachineItem
    {
        public string Name { get; private set; }
        public string SlotPosition { get; private set;}
        public decimal Price { get; private set; }


        public VendingMachineItem()
        {

        }
        
        public VendingMachineItem(string slotPosition, string name)
        {
            SlotPosition = slotPosition;
            Name = name;
            Price = 0;
        }

        public VendingMachineItem(string slotPosition, string name, decimal price)
        {
            SlotPosition = slotPosition;
            Name = name;
            Price = price;
        }


        public abstract string DisplayMessage();
    }
}
