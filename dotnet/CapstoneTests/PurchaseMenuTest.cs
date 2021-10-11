using Capstone.Menus;
using Capstone.VendingMachineClasses;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class PurchaseMenuTest
    {
        [TestMethod]
        public void TestDespenseMethod_DecreasesVendingMachineBalance()
        {
            StockBoy testStockBoy = new StockBoy(@"C:\Users\Student\workspace\orange-mod1-capstone-team4\dotnet\vendingmachinetest.csv");
            VendingMachine testVendingMachine = new VendingMachine(testStockBoy.StockVendingMachine());
            
            Capstone.Menus.PurchaseMenu testPurchaseMenu = new Capstone.Menus.PurchaseMenu(testVendingMachine);
            testPurchaseMenu.VendoMatic800.IncreaseBalance(10);
            decimal startingBalance = testPurchaseMenu.VendoMatic800.Balance;
            int testParameter = 13;
            testPurchaseMenu.DispenseItem(testParameter);




            Assert.AreEqual(startingBalance - testVendingMachine.Inventory[testParameter].Price, testPurchaseMenu.VendoMatic800.Balance );

        }
    }
}
