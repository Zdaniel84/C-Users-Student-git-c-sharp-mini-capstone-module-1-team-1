using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Capstone
{
    public class MoneyRelated : IPausable
    {
        public List<string> listOfProducts = new List<string>();

        Customization easterEgg = new Customization();
        public decimal Balance { get;  set; }
        public decimal NewBalance { get; set; }
        public decimal PriceOfItem { get; set; }

        public int Stock { get; set; } = 5;

        public int AmtPurchased { get; set; }



        public string path = @"C:\Users\Student\git\c-sharp-mini-capstone-module-1-team-1\vendingmachine.csv";
        public void GetBalance()
        {

            Console.WriteLine("Enter dollar amount (1, 2, 5, or 10): ");
            
            string amountEntered = Console.ReadLine();
           
            decimal.TryParse(amountEntered, out decimal balance);
           if(balance == 1 || balance == 2 || balance == 5 || balance == 10)
            {
                this.Balance += balance;
            }
           else
            {                
                Console.WriteLine("Please enter a valid amount");
                Console.ReadLine();
            }
            



            
        }

        public decimal subtractFromBalance(decimal price)
        {
            return this.Balance - price;
        }

        public void ProductSelection()
        {
           try
            {
                using (StreamReader stream = new StreamReader(path))

                {
                    while (!stream.EndOfStream)

                    {

                        string line = stream.ReadLine();

                        string[] items = line.Split("|");

                        listOfProducts.AddRange(items);

                        int stockAvaliabe = this.Stock - this.AmtPurchased;

                        Console.WriteLine(string.Join(", ", items) + ", " + stockAvaliabe);




                    }
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Error reading file.");

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter Product code:");

            string userInput = Console.ReadLine();
            if (userInput == "12")
            {
                easterEgg.GetPicture("magichorse.txt");
                Console.WriteLine("How did THAT get in there?!");
                IPausable.LongPause();
            }
            bool loopBreak = true;
            
            while (loopBreak)
            {



                for (int i = 0; i < listOfProducts.Count; i++)

                {
                    if (listOfProducts[i].Equals(userInput))

                    {

                        Console.WriteLine("your choice is " + listOfProducts[i + 1]);

                        Console.WriteLine("price: " + listOfProducts[i + 2]);
                        

                        decimal.TryParse(listOfProducts[i + 2], out decimal productPrice);
                        if(Balance < productPrice)
                        {
                            Console.Clear();
                            Console.WriteLine("Not enough for selected item");
                            Console.Read();
                        }                        
                        else
                        {
                            
                            NewBalance = productPrice;
                            Console.WriteLine("Your remaining balance is:" + (Balance - NewBalance));
                            if (listOfProducts[i + 3].Equals("Chip"))
                            {
                                Chips chips = new Chips();
                                Console.WriteLine(chips.Sound);
                            }
                            if (listOfProducts[i + 3].Equals("Candy"))
                            {
                                Candy candy = new Candy();
                                Console.WriteLine(candy.Sound);
                            }
                            if (listOfProducts[i + 3].Equals("Drink"))
                            {
                                Beverage beverage = new Beverage();
                                Console.WriteLine(beverage.Sound);
                            }
                            if (listOfProducts[i + 3].Equals("Gum"))
                            {
                                Gum gum = new Gum();
                                Console.WriteLine(gum.Sound);
                            }
                            
                            Console.ReadLine();
                            break;
                        }
                        
                        
                        
                        

                        //if (listOfProducts[i + 3].Equals("Chip"))
                        //{
                        //    Chips chips = new Chips();
                        //    Console.WriteLine(chips.Sound);
                        //}
                        //if (listOfProducts[i + 3].Equals("Candy"))
                        //{
                        //    Candy candy = new Candy();
                        //    Console.WriteLine(candy.Sound);
                        //}
                        //if (listOfProducts[i + 3].Equals("Drink"))
                        //{
                        //    Beverage beverage = new Beverage();
                        //    Console.WriteLine(beverage.Sound);
                        //}
                        //if (listOfProducts[i + 3].Equals("Gum"))
                        //{
                        //    Gum gum = new Gum();
                        //    Console.WriteLine(gum.Sound);
                        //}

                        //Console.ReadLine();
                        //break;
                    }
                }
                break;
            }
        }

        public void GiveChange()
        {
            decimal quarters = 0M;
            decimal dimes = 0M;
            decimal nickels = 0M;
            decimal pennies = 0M;
            decimal change = this.Balance - this.PriceOfItem;

            //if (change >= 100)
            if (change > 0.99M)
            {
                while (change > 0.24M)
                {
                    change -= 0.25M;
                    quarters++;
                }
                while (change > 0.90M)
                {
                    change -= 0.10M;
                    dimes++;
                }
                while (change > 0.04M)
                {
                    change -= 0.05M;
                    nickels++;
                }
                while (change < 0.04M && change > 0M)
                {
                    change -= 0.01M;
                    pennies++;
                }
                Console.WriteLine("Thank you for shopping with us!");
                Console.WriteLine($"Your change is: {quarters} quarters {dimes} dimes {nickels} nickels and {pennies} pennies!");

            }

        }
    }
}
