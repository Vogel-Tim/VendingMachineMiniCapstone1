using Capstone.VendingMachineClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Menus
{
    class FeedMoneyMenu : PurchasingProcessMenu
    {
        private decimal moneyInput = 0;

        public FeedMoneyMenu(VendingMachine vendoMatic800) : base(vendoMatic800)
        {

        }

        public override void IsOnDisplay()
        {
            string moneySelection = "";
            PrintHeader();
            Console.WriteLine("ALL CHANGE RETURNEED IN COINS!");
            Console.WriteLine("(1) $1");
            Console.WriteLine("(2) $2");
            Console.WriteLine("(3) $5");
            Console.WriteLine("(4) $10");
            Console.WriteLine("(5) $20");
            Console.WriteLine("(6) RETURN to previous MENU");
            Console.WriteLine("(7) ADVANCE to PURCHASE MENU");
            Console.WriteLine();
            Console.WriteLine($"Current money provided: {VendoMatic800.Balance:C2}");
            moneySelection = Console.ReadLine();

            switch (moneySelection)
            {
                case "1":
                    moneyInput = 1;
                    FeedMoney(1);
                    break;
                case "2":
                    moneyInput = 2;
                    FeedMoney(2);
                    break;
                case "3":
                    moneyInput = 5;
                    FeedMoney(5);
                    break;
                case "4":
                    moneyInput = 10;
                    FeedMoney(10);
                    break;
                case "5":
                    moneyInput = 20;
                    FeedMoney(20);
                    break;
                case "6":
                    base.IsOnDisplay();
                    break;
                case "7":
                    Menu purchaseMenu = new PurchaseMenu(VendoMatic800);
                    purchaseMenu.IsOnDisplay();
                    break;
                default:
                    Console.WriteLine("Input not accepted! Please press ENTER to continue");
                    Console.ReadLine();
                    this.IsOnDisplay();
                    break;
            }
        }

        private void FeedMoney(decimal money)
        {
            VendoMatic800.IncreaseBalance(money);
            this.Log();
            base.Log();
            this.IsOnDisplay();
        }

        protected sealed override void Log()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(logFilePath, true))
                {
                    sw.Write($"{DateTime.UtcNow} FEED MONEY: {moneyInput:C2}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
