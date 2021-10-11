using Capstone.Items;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class DrinkTest
    {
        [TestMethod]
        public void TestDrinkConstructor()
        {
            Drink testDrink = new Drink("A1", "LemonLime", 2.50M);

            string slotPosition = testDrink.SlotPosition;
            string name = testDrink.Name;
            decimal price = testDrink.Price;
            string message = testDrink.Display;

            Assert.AreEqual("A1", slotPosition);
            Assert.AreEqual("LemonLime", name);
            Assert.AreEqual(2.50M, price);
            Assert.AreEqual("Glug Glug, Yum!", message);
        }

        [TestMethod]
        public void TestDisplayMessage()
        {
            Drink testDrink = new Drink();

            string displayMessage = testDrink.DisplayMessage();

            Assert.AreEqual("Glug Glug, Yum!", displayMessage);
        }
    }
}
