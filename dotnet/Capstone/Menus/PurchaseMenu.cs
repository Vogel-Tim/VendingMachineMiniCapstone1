using Capstone.VendingMachineClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Menus
{
    public class PurchaseMenu : PurchasingProcessMenu
    {
        
        private string itemLocation = "";
        private int purcahsedItemIndex = 0;

        public PurchaseMenu(VendingMachine vendoMatic800) : base(vendoMatic800)
        {

        }

        public override void IsOnDisplay()
        {
            PrintHeader();
            DisplayInventory();
            Console.WriteLine();
            Console.WriteLine($"PLEASE SELECT PRODUCT LOCATION :: BALANCE {VendoMatic800.Balance:C2} :: Enter \"BACK\" to return to previous MENU");
            itemLocation = Console.ReadLine().ToUpper();
            if (itemLocation.Equals("BACK"))
            {
                base.IsOnDisplay();
            }
            else
            {
                PurchaseItem(itemLocation);
            }
        }

        private void PurchaseItem(string location)
        {
            
            for (int i = 0; i < VendoMatic800.Inventory.Count; i++)
            {
                if (VendoMatic800.Inventory[i].SlotPosition.Equals(location))
                {
                    purcahsedItemIndex = i;
                }
            }

            if (!VendoMatic800.Stock.ContainsKey(location))
            {
                Console.WriteLine("ITEM NOT FOUND::PRESS ENTER TO CONTINUE");
                Console.ReadLine();
                base.IsOnDisplay();
            }
            else if (VendoMatic800.Stock.ContainsKey(location) && VendoMatic800.Stock[location] == 0)
            {
                Console.WriteLine("ITEM IS SOLD OUT::PRESS ENTER TO CONTINUE");
                Console.ReadLine();
                this.IsOnDisplay();

            }
            else if (VendoMatic800.Stock.ContainsKey(location) && VendoMatic800.Stock[location] > 0 && VendoMatic800.Inventory[purcahsedItemIndex].Price >= VendoMatic800.Balance)
            {
                Console.WriteLine("INSUFFICIENT FUNDS::PLEASE INSERT ADDITIONAL MONEY::PRESS ENTER TO CONTINUE");
                Console.ReadLine();
                base.IsOnDisplay();
            }
            else
            {
                DispenseItem(purcahsedItemIndex);
            }
        }

        private void DispenseItem(int index)
        {
            this.Log();
            VendoMatic800.DecreaseBalance(VendoMatic800.Inventory[index].Price);
            VendoMatic800.Stock[VendoMatic800.Inventory[index].SlotPosition]--;
            base.Log();
            Console.Clear();
            Console.WriteLine($"~~~~{VendoMatic800.Inventory[index].Name.ToUpper()} DISPENSED~~~~");
            Console.WriteLine();
            Console.WriteLine($"    {VendoMatic800.Inventory[index].DisplayMessage()}");
            Console.WriteLine($"{VendoMatic800.Inventory[index].Name} COST {VendoMatic800.Inventory[index].Price:C2} ~ {VendoMatic800.Balance:C2} REMAINING BALANCE");
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadLine();
            base.IsOnDisplay();
        }

        protected sealed override void Log()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(logFilePath, true))
                {
                    sw.Write($"{DateTime.UtcNow} {VendoMatic800.Inventory[purcahsedItemIndex].Name} {VendoMatic800.Inventory[purcahsedItemIndex].SlotPosition} {VendoMatic800.Balance:C2}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    
    }
}
