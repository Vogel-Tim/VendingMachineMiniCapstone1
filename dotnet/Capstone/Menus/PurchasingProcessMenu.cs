using Capstone.VendingMachineClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Menus
{
    public class PurchasingProcessMenu : MainMenu
    {
       
        public PurchasingProcessMenu(VendingMachine vendoMatic800) : base(vendoMatic800)
        {

        }

        public override void IsOnDisplay()
        {
            string purchasingProcessMenuInput = "";
            PrintHeader();
            Console.WriteLine("(1) Feed Money");
            Console.WriteLine("(2) Select Product");
            Console.WriteLine("(3) Finish Transaction");
            Console.WriteLine();
            Console.WriteLine($"Current Money Provided: {VendoMatic800.Balance:C2}");
            purchasingProcessMenuInput = Console.ReadLine();


            if (purchasingProcessMenuInput == "1")
            {
                Menu feedMoneyMenu = new FeedMoneyMenu(VendoMatic800);
                feedMoneyMenu.IsOnDisplay();
            }
            else if (purchasingProcessMenuInput == "2")
            {
                Menu purchaseMenu = new PurchaseMenu(VendoMatic800);
                purchaseMenu.IsOnDisplay();
            }
            else if (purchasingProcessMenuInput == "3")
            {
                Menu finishTransactionMenu = new FinishTransactionMenu(VendoMatic800);
                finishTransactionMenu.IsOnDisplay();
                
            }
            else
            {
                Console.WriteLine("INPUT INVALID PRESS ENTER TO CONTINUE");
                Console.ReadLine();
                IsOnDisplay();
            }
        }

        protected override void Log()
        {
            base.Log();
        }

    }
}
