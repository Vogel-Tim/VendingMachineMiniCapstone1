using Capstone.VendingMachineClasses;
using Capstone.Items;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class StockBoyTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            StockBoy testStockBoy = new StockBoy("testData");

            Assert.AreEqual("testData", testStockBoy.Data);
        }

        [TestMethod]
        public void TestStockVendingMachine()
        {
            StockBoy testStockBoy = new StockBoy(@"C:\Users\Student\workspace\orange-mod1-capstone-team4\dotnet\vendingmachinetest.csv");
            List<VendingMachineItem> stockList = new List<VendingMachineItem>();
            stockList = testStockBoy.StockVendingMachine();

            Assert.AreEqual(1.45M, stockList[1].Price);
            Assert.AreEqual("D4", stockList[15].SlotPosition);

        }
    }

}
