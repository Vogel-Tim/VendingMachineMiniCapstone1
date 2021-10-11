using Capstone.VendingMachineClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Menus
{
    public class FinishTransactionMenu : MainMenu
    {

        public FinishTransactionMenu() : base()
        {

        }

        public FinishTransactionMenu(VendingMachine vendoMatic800) : base(vendoMatic800)
        {

        }

        protected override void PrintHeader()
        {
            Console.Clear();
            Console.WriteLine("*******************************");
            Console.WriteLine("********VENDO-MATIC 800********");
            Console.WriteLine("*******************************");
            Console.WriteLine();
        }

        public override void IsOnDisplay()
        {
            this.PrintHeader();
            MakeChange();
            this.Log();
            VendoMatic800.ClearBalance();
            base.Log();
        }

        private void MakeChange()
        { 
            decimal remainingBalance = VendoMatic800.Balance;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;

            quarters = (int)(remainingBalance / .25M);
            remainingBalance -= (decimal)(quarters * 0.25);
            dimes = (int)(remainingBalance / .10M);
            remainingBalance -= (decimal)(dimes * .10M);
            nickels = (int)(remainingBalance / .05M);
            Console.WriteLine($"You recieved {VendoMatic800.Balance:C2} in Change as: {quarters} Quarter(s); {dimes} Dime(s); {nickels} Nickel(s).");
            Console.WriteLine("THANK YOU FOR USING VENDO-MATIC 800. HAPPY SNACKING! :: PRESS ENTER TO FINISH THIS TRANSACTION");
            Console.ReadLine();
        }

        protected sealed override void Log()
        {
            decimal startBalance = VendoMatic800.Balance;
            try
            {
                using (StreamWriter sw = new StreamWriter(logFilePath, true))
                {
                    sw.Write($"{DateTime.UtcNow} GIVE CHANGE: {startBalance:C2}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
