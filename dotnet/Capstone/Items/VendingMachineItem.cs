using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Items
{
    public abstract class VendingMachineItem
    {
        public string Name { get; }
        public string SlotPosition { get; }
        public decimal Price { get; }

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
