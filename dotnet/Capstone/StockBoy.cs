using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class StockBoy
    {
        private string Data { get; }
        

        public StockBoy()
        {

        }

        public StockBoy(string data)
        {
            Data = data;
        }

        public List<VendingMachineItem> ArrangeItems()
        {
            List<string> rawData = new List<string>();
            List<VendingMachineItem> supply = new List<VendingMachineItem>();
            try
            {
                using (StreamReader sr = new StreamReader(Data))
                {
                    while (!sr.EndOfStream)
                    {
                        rawData.Add(sr.ReadLine());
                    }

                }
            }catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            try
            {
                foreach (string item in rawData)
                {
                    string[] makeClassObject = item.Split("|");
                    if (makeClassObject[3].Equals("Chip"))
                    {
                        VendingMachineItem createItem = new Chip(makeClassObject[0], makeClassObject[1], decimal.Parse(makeClassObject[2]));
                        supply.Add(createItem);
                    }
                    else if (makeClassObject[3].Equals("Candy"))
                    {
                        VendingMachineItem createItem = new Candy(makeClassObject[0], makeClassObject[1], decimal.Parse(makeClassObject[2]));
                        supply.Add(createItem);
                    }
                    else if (makeClassObject[3].Equals("Drink"))
                    {
                        VendingMachineItem createItem = new Gum(makeClassObject[0], makeClassObject[1], decimal.Parse(makeClassObject[2]));
                        supply.Add(createItem);
                    }
                    else
                    {
                        VendingMachineItem createItem = new Gum(makeClassObject[0], makeClassObject[1], decimal.Parse(makeClassObject[2]));
                        supply.Add(createItem);
                    }
                }
            }catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return supply;
            
        }

    }
}
