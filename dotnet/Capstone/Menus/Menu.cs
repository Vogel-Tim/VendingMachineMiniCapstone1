using Capstone.VendingMachineClasses;
using Capstone.Items;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Menus
{
    public abstract class Menu
    {
        protected string logFilePath = @"C:\Users\Student\workspace\orange-mod1-capstone-team4\dotnet\Log.txt";

        public bool IsOn { get; set; }
        public VendingMachine VendoMatic800 { get; } = new VendingMachine();

        public Menu()
        {

        }

        public Menu(VendingMachine vendoMatic800)
        {
            VendoMatic800 = vendoMatic800;
            IsOn = true;
        }

        protected virtual void PrintHeader()
        {
            Console.Clear();
            Console.WriteLine("********VENDO-MATIC 800********");
            Console.WriteLine("PLEASE CHOOSE FROM THE FOLLOWING");
            Console.WriteLine();
        }

        public void DisplayInventory()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("***LOCATION  ~  NAME  ~  PRICE  ~  REMAINING***");
            Console.WriteLine("***********************************************");
            Console.WriteLine();
            foreach (VendingMachineItem item in VendoMatic800.Inventory)
            {
                if (VendoMatic800.Stock[item.SlotPosition] == 0)
                {
                    Console.WriteLine($"{item.SlotPosition}  ~  {item.Name}  ~  {item.Price:C2}  ~  SOLD OUT!");
                }
                else
                {
                    Console.WriteLine($"{item.SlotPosition}  ~  {item.Name}  ~  {item.Price:C2}  ~  {VendoMatic800.Stock[item.SlotPosition]}");
                }
            }
           
        }

        public abstract void IsOnDisplay();

        protected virtual void Log()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(logFilePath, true))
                {
                    sw.WriteLine($" {VendoMatic800.Balance:C2}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
