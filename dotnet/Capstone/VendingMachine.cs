using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {

        //Class Specific variables
        private string mainMenuInput = "";

        //Class Properties
        private List<VendingMachineItem> Inventory { get; } = new List<VendingMachineItem>();
        public Dictionary<string, int> Stock { get; private set; } = new Dictionary<string, int>();
        public string Name { get; }
        public decimal Balance { get; private set; }

        //Constructors
        public VendingMachine()
        {
            Name = "VENDO-MATIC 800";
            Balance = 0;
           
        }

        public VendingMachine(List<VendingMachineItem> inventory)
        {
            Inventory = inventory;
            Name = "VENDO-MATIC 800";
            Balance = 0;

            foreach (VendingMachineItem item in Inventory)
            {
                Stock.Add(item.SlotPosition, 5);
            }
            
        }

        public void PrintInventory()
        {
            foreach(VendingMachineItem item in Inventory)
            {
                Console.WriteLine($"{item.SlotPosition} {item.Name} {item.Price} {item.DisplayMessage()} {Stock[item.SlotPosition]}");
                
            }


        }

        private void MainMenuDisplay()
        {
            Console.Clear();
            Console.WriteLine("********VENDO-MATIC 800********");
            Console.WriteLine("PLEASE CHOOSE FROM THE FOLLOWING");
            Console.WriteLine();
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
            mainMenuInput = Console.ReadLine();
        }

        private void MainMenuOption1()
        {
            
            Console.Clear();
            PrintInventory();
            Console.WriteLine();
            Console.WriteLine("Press ENTER To Return To Main Menu");
            Console.ReadLine();
        }






        public void Run()
        {
            bool isRunning = true;
            bool isValidMainMenuInput = false;
           
            


            while (isRunning)
            {
                MainMenuDisplay();
              

                while (!isValidMainMenuInput)
                {
                    if (mainMenuInput == "1")
                    {
                        isValidMainMenuInput = true;
                        MainMenuOption1();
                    }
                    else if(mainMenuInput == "2")
                    {
                        isValidMainMenuInput = true;
                    }

                  
                }
                isValidMainMenuInput = false;
            }

        }
    }

}
