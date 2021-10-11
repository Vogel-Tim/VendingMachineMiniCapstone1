using Capstone.Items;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class ChipTest
    {
        [TestMethod]
        public void TestChipConstructor()
        {
            Chip testChip = new Chip("A1", "CornChip", 2.50M);

            string slotPosition = testChip.SlotPosition;
            string name = testChip.Name;
            decimal price = testChip.Price;
            string message = testChip.Display;

            Assert.AreEqual("A1", slotPosition);
            Assert.AreEqual("CornChip", name);
            Assert.AreEqual(2.50M, price);
            Assert.AreEqual("Crunch Crunch, Yum!", message);
        }

        [TestMethod]
        public void TestDisplayMessage()
        {
            Chip testChip = new Chip();

            string displayMessage = testChip.DisplayMessage();

            Assert.AreEqual("Crunch Crunch, Yum!", displayMessage);
        }
    }
}
