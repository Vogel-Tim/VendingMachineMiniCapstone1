using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {

        //Class Specific variables
        private string mainMenuInput = "";
        private string displayMenuInput = "";
        private string moneySelection = "";

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

        private void PrintHeader()
        {
            Console.Clear();
            Console.WriteLine("********VENDO-MATIC 800********");
            Console.WriteLine("PLEASE CHOOSE FROM THE FOLLOWING");
            Console.WriteLine();
        }

        private void PrintInventory()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***LOCATION  ~  NAME  ~  PRICE  ~  REMAINING***");
            Console.WriteLine("***********************************************");
            Console.WriteLine();
            foreach (VendingMachineItem item in Inventory)
            {
               

                Console.WriteLine($"{item.SlotPosition}  ~  {item.Name}  ~  {item.Price}  ~  {Stock[item.SlotPosition]}");
                
            }


        }

        private void MainMenuDisplay()
        {
            PrintHeader();
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
           
        }

        private void DisplayInventory()
        {
            
            Console.Clear();
            PrintInventory();
            Console.WriteLine();
            Console.WriteLine("Press ENTER To Return To Main Menu");
            Console.ReadLine();
        }
        private void DisplayPurchaseMenu()
        {
            PrintHeader();
            Console.WriteLine("(1) Feed Money");
            Console.WriteLine("(2) Select Product");
            Console.WriteLine("(3) Finish Transaction");
            Console.WriteLine();
            Console.WriteLine($"Current Money Provided: {Balance}");
            displayMenuInput = Console.ReadLine();


            if (displayMenuInput == "1")
            {
                FeedMoneyDisplay();   
            } 





        }
        private void FeedMoneyDisplay()
        {
            PrintHeader();
            Console.WriteLine("ALL CHANGE RETURNEED IN COINS!");
            Console.WriteLine("(1) $1");
            Console.WriteLine("(2) $2");
            Console.WriteLine("(3) $5");
            Console.WriteLine("(4) $10");
            Console.WriteLine("(5) $20");
            Console.WriteLine("(6) EXIT to main menu");
            moneySelection = Console.ReadLine();
            
            if(moneySelection == "1")
            {
                FeedMoney(1);
            }
            else if(moneySelection == "2")
            {
                FeedMoney(2);
            }
            else if(moneySelection == "3")
            {
                FeedMoney(5);
            }
            else if(moneySelection == "4")
            {
                FeedMoney(10);
            }
            else if(moneySelection == "5")
            {
                FeedMoney(20);
            }
            else if(moneySelection == "6")
            {
                MainMenuDisplay();
            }
            else
            {
                Console.WriteLine("Input not accepted! Please press ENTER to continue");
                Console.ReadLine();
                FeedMoneyDisplay();
            }
           
        }
        private void FeedMoney(decimal money)
        {

        }



         


        public void Run()
        {
            bool isRunning = true;
            
           
            


            while (isRunning)
            {
                MainMenuDisplay();



                mainMenuInput = Console.ReadLine();
                if (mainMenuInput == "1")
                    {
                        
                        DisplayInventory();
                    }
                    else if(mainMenuInput == "2")
                    {
                        DisplayPurchaseMenu();
                    }
                    else
                    {
                    isRunning = false;
                    }

                  
                
                
            }

        }
    }

}
