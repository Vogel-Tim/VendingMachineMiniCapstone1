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
            myVendingMachine.Run();
            //myVendingMachine.printInventory();
            
        }
    }
}
