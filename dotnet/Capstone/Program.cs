using Capstone.Items;
using Capstone.Menus;
using Capstone.VendingMachineClasses;
using System;
using System.IO;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string dataFilePath = @"C:\Users\Student\workspace\orange-mod1-capstone-team4\dotnet\vendingmachine.csv";
            StockBoy minimumWageWorker = new StockBoy(dataFilePath);
            VendingMachine myVendingMachine = new VendingMachine(minimumWageWorker.StockVendingMachine());
            Menu vendingMachineMenu = new MainMenu(myVendingMachine);
            while (vendingMachineMenu.IsOn)
            {
                vendingMachineMenu.IsOnDisplay();
            }
             
           
        }

    }
}
