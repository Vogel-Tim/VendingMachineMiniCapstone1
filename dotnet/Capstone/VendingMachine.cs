using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {

        //Class Properties
        private List<VendingMachineItem> Inventory { get; } = new List<VendingMachineItem>();
        public string Name { get; }
        public decimal Balance { get; private set; }

        //Constructors
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
        }


    }
}
