using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Capstone
{
    public class VendingItems
    {
        //might have to move dictionary at some point


        //public decimal Balance { get; }


        //public VendingItems(decimal balance, decimal currentMoney)
        //{
        //    this.Balance = balance;
        //    this.CurrentMoney = currentMoney;
        //}

        public VendingItems()
        {

        }

        VendingMachine vendingMachine = new VendingMachine();

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

                        //Dictionary<sampleList, int> itemDictionary = new Dictionary<sampleList, int>();
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
                    //if ()
                    Console.WriteLine("your choice is " + sampleList[i + 1]);
                    // show the name of the snack DV
                    Console.WriteLine("price: " + sampleList[i + 2]);
                    decimal priceOf = decimal.Parse(sampleList[i + 2]);

                    // and the price of the snack DV
                    Console.WriteLine("Your remaining balance is: " + vendingMachine.subtractFromBalance(priceOf));

                    // for the next step DV
                    if (sampleList[i + 3].Equals("Chip"))
                    {
                        Chips chips = new Chips();
                        Console.WriteLine(chips.Sound);
                    }
                    if (sampleList[i + 3].Equals("Candy"))
                    {
                        Candy candy = new Candy();
                        Console.WriteLine(candy.Sound);
                    }
                    if (sampleList[i + 3].Equals("Drink"))
                    {
                        Beverage beverage = new Beverage();
                        Console.WriteLine(beverage.Sound);
                    }
                    if (sampleList[i + 3].Equals("Gum"))
                    {
                        Gum gum = new Gum();
                        Console.WriteLine(gum.Sound);
                    }
                    Console.ReadLine();
                }
            }
        }
        





    }
}
