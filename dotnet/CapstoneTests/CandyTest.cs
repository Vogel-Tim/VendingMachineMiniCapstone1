using Capstone.Items;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class CandyTest
    {
        [TestMethod]
        public void TestCandyConstructor()
        {
            Candy testCandy = new Candy("A1", "Buttertoe", 2.50M);

            string slotPosition = testCandy.SlotPosition;
            string name = testCandy.Name;
            decimal price = testCandy.Price;
            string message = testCandy.Display;

            Assert.AreEqual("A1", slotPosition);
            Assert.AreEqual("Buttertoe", name);
            Assert.AreEqual(2.50M, price);
            Assert.AreEqual("Munch Munch, Yum!", message);
        }

        [TestMethod]
        public void TestDisplayMessage()
        {
            Candy testCandy = new Candy();

            string displayMessage = testCandy.DisplayMessage();

            Assert.AreEqual("Munch Munch, Yum!", displayMessage);
        }
    }
}
