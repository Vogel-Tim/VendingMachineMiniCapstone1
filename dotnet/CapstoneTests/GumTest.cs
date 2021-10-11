using Capstone.Items;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class GumTest
    {
        [TestMethod]
        public void TestGumConstructor()
        {
            Gum testGum = new Gum("A1", "WinterWind", 2.50M);

            string slotPosition = testGum.SlotPosition;
            string name = testGum.Name;
            decimal price = testGum.Price;
            string message = testGum.Display;

            Assert.AreEqual("A1", slotPosition);
            Assert.AreEqual("WinterWind", name);
            Assert.AreEqual(2.50M, price);
            Assert.AreEqual("Chew Chew, Yum!", message);
        }

        [TestMethod]
        public void TestDisplayMessage()
        {
            Gum testGum = new Gum();

            string displayMessage = testGum.DisplayMessage();

            Assert.AreEqual("Chew Chew, Yum!", displayMessage);
        }
    }
}
