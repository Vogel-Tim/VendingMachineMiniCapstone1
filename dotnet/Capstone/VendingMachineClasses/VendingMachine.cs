using Capstone.Items;
using System;
using System.Collections.Generic;
using System.IO;

namespace Capstone.VendingMachineClasses
{
    public class VendingMachine
    { 
        public List<VendingMachineItem> Inventory { get; } = new List<VendingMachineItem>();
        public Dictionary<string, int> Stock { get; private set; } = new Dictionary<string, int>();
        public string Name { get; }
        public decimal Balance { get; private set; }

        public VendingMachine()
        {
            Name = "VENDO-MATIC 800";
            Balance = 0;
        }

        public VendingMachine(List<VendingMachineItem> inventory)
        {
            Inventory = inventory;
            Name = "VENDO-MATIC 800";
            Balance = 0;
           
            foreach (VendingMachineItem item in Inventory)
            {
                Stock.Add(item.SlotPosition, 5);
            }
        }

        public void IncreaseBalance(decimal money)
        {
            Balance += money;
        }

        public void DecreaseBalance(decimal money)
        {
            Balance -= money;
        }

        public void ClearBalance()
        {
            Balance = 0;
        }
    }
}
