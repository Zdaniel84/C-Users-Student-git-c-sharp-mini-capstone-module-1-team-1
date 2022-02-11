using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Capstone
{
    public class VendingItems : IVendable
    {
        //might have to move dictionary at some point

        public string Slot { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }

        public int Stock { get; set; }
        //public List<VendingItems> sampleList { get; set; } = new List<VendingItems>();
       
        public VendingItems(string slot, string item, decimal price, string type, int stock)
        {
            this.Slot = slot;
            this.Item = item;
            this.Price = price;
            this.Type = type;
            this.Stock = stock;
            
        }
        public VendingItems()
        {

        }


        public List<string> sampleList = new List<string>();


        //public Dictionary<string, VendingItems> vendingItems = new Dictionary<string, VendingItems>();

        public string path = @"C:\Users\Student\git\c-sharp-mini-capstone-module-1-team-1\vendingmachine.csv";

        public void GetItems()
        {
            try
            {
                using (StreamReader stream = new StreamReader(path))
                {

                    while (!stream.EndOfStream)
                    {

                        string line = stream.ReadLine();
                        string[] items = line.Split("|");
                        sampleList.AddRange(items);

                        int stock = 5;

                        Console.WriteLine(string.Join(", ", items) + ", " + stock);


                    }
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Error reading file.");
            }

        }

        public virtual void GetSound(string sound)
        {
            Console.WriteLine("");
        }
        
        

        



    }
}
