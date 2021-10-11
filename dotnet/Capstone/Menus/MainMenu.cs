using Capstone.VendingMachineClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Menus
{
    public class MainMenu : Menu
    {
        
        public MainMenu(VendingMachine vendoMatic800) : base (vendoMatic800)
        {
            
        }

        public override void IsOnDisplay()
        {
            string mainMenuInput = "";
            Console.Clear();
            base.PrintHeader();
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
            mainMenuInput = Console.ReadLine();
            if (mainMenuInput == "1")
            {

                DisplayInventory();
                Console.WriteLine();
                Console.WriteLine("Press ENTER To Return To Main Menu");
                Console.ReadLine();
                this.IsOnDisplay();
            }
            else if (mainMenuInput == "2")
            {
                Menu purchasingProcessMenu = new PurchasingProcessMenu(VendoMatic800);
                purchasingProcessMenu.IsOnDisplay();
            }
            else if (mainMenuInput == "3")
            {
                IsOn = false;
            }
            else
            {
                Console.WriteLine("INVALID INPUT PLEASE PRESS ENTER TO TRY AGAIN");
                Console.ReadLine();
            }
        }

        protected override void Log()
        {
            base.Log();
        }
    }
}
