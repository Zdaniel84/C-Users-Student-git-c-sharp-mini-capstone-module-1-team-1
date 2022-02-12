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
        //public List<VendingItems> itemList { get; set; } = new List<VendingItems>();

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

        public void ShowItems()
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

        public void ProductSelection()
        {
            //List<string> sampleList = new List<string>();
            
            try
            {
                using (StreamReader stream = new StreamReader(path))
                    // we are using stream reader to read the text file DV
                {

                    while (!stream.EndOfStream)
                        // while the stream of data hasnt finished DV
                    {

                        string line = stream.ReadLine();
                        // read each line DV
                        string[] items = line.Split("|");
                        // remove each | or delimiter i think, itll seperate everything DV
                        sampleList.AddRange(items);
                        // adds all of the items in the text file DV

                        int stock = 5;
                        // stock of each item is 5 DV

                        Console.WriteLine(string.Join(", ", items) + ", " + stock);
                        // seperate each item in the text file with commas , add the stock (5 to begin with) we will need to implement a method that takes it away with each purchase DV


                    }
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Error reading file.");
                //any exceptions will cause an error message DV
            }
            Console.WriteLine("Enter Product code:");
            //enter the product code (ex A1 B3 C2 D4) to retrieve item in that slot DV
            string userInput = Console.ReadLine();
            // here we will key in the product code DV
            for (int i = 0; i < sampleList.Count; i++)
                // will go through ALL of our options of product codes DV
            {
                if (sampleList[i].Equals(userInput))
                    //the product code == to what we inputted will:
                {
                    Console.WriteLine("your choice is " + sampleList[i + 1]);
                    // show the name of the snack DV
                    Console.WriteLine("price: " + sampleList[i + 2]);
                    // and the price of the snack DV
                    Console.ReadLine();
                    // for the next step DV
                }
            }
        }





    }
}
