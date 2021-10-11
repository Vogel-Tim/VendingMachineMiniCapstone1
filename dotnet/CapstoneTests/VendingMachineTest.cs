using Capstone.VendingMachineClasses;
using Capstone.Items;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTest
    {
        [TestMethod]
        public void TestConstructors()
        {
            List<VendingMachineItem> testList = new List<VendingMachineItem>();
            testList.Add(new Candy("A1", "Kickers", 2));
            testList.Add(new Chip("A2", "Munchons", 1.5M));
            testList.Add(new Drink("A3", "RootWater", 1));
            testList.Add(new Gum("A4", "SummerBreeze", .50M));

            VendingMachine testMachine = new VendingMachine(testList);

            Assert.AreEqual("Kickers", testMachine.Inventory[0].Name);
            Assert.AreEqual(1.5M, testMachine.Inventory[1].Price);
            Assert.AreEqual("A3", testMachine.Inventory[2].SlotPosition);
            Assert.AreEqual("Chew Chew, Yum!", testMachine.Inventory[3].DisplayMessage());
        }

        [TestMethod]
        public void TestSock()
        {
            List<VendingMachineItem> testList = new List<VendingMachineItem>();
            testList.Add(new Candy("A1", "Kickers", 2));
            testList.Add(new Chip("A2", "Munchons", 1.5M));
            testList.Add(new Drink("A3", "RootWater", 1));
            testList.Add(new Gum("A4", "SummerBreeze", .50M));

            VendingMachine testMachine = new VendingMachine(testList);

            Assert.AreEqual(5, testMachine.Stock["A1"]);
            Assert.AreEqual(5, testMachine.Stock["A2"]);
            Assert.AreEqual(5, testMachine.Stock["A3"]);
            Assert.AreEqual(5, testMachine.Stock["A4"]);
        }

        [TestMethod]
        public void TestIncreaseBalalnce()
        {
            List<VendingMachineItem> testList = new List<VendingMachineItem>();
            testList.Add(new Candy("A1", "Kickers", 2));
            testList.Add(new Chip("A2", "Munchons", 1.5M));
            testList.Add(new Drink("A3", "RootWater", 1));
            testList.Add(new Gum("A4", "SummerBreeze", .50M));

            VendingMachine testMachine = new VendingMachine(testList);

            testMachine.IncreaseBalance(10);

            Assert.AreEqual(10, testMachine.Balance);
        }

        [TestMethod]
        public void TestDecreaseBalance()
        {
            List<VendingMachineItem> testList = new List<VendingMachineItem>();
            testList.Add(new Candy("A1", "Kickers", 2));
            testList.Add(new Chip("A2", "Munchons", 1.5M));
            testList.Add(new Drink("A3", "RootWater", 1));
            testList.Add(new Gum("A4", "SummerBreeze", .50M));

            VendingMachine testMachine = new VendingMachine(testList);
            testMachine.IncreaseBalance(25);
            testMachine.DecreaseBalance(10);

            Assert.AreEqual(15, testMachine.Balance);
        }

        [TestMethod]
        public void TestClearBalance()
        {
            List<VendingMachineItem> testList = new List<VendingMachineItem>();
            testList.Add(new Candy("A1", "Kickers", 2));
            testList.Add(new Chip("A2", "Munchons", 1.5M));
            testList.Add(new Drink("A3", "RootWater", 1));
            testList.Add(new Gum("A4", "SummerBreeze", .50M));

            VendingMachine testMachine = new VendingMachine(testList);
            testMachine.IncreaseBalance(25);
            testMachine.ClearBalance();

            Assert.AreEqual(0, testMachine.Balance);
        }

    }
}
