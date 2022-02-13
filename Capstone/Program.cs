using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;


namespace Capstone
{
    public class Program : IPausable
    {
        public static void Main(string[] args)
        {
            MoneyRelated moneyRelated = new MoneyRelated();
          
            UserExpirience userExpirience= new UserExpirience();

            Customization artStuff = new Customization();

            artStuff.GetPicture("welcone.txt");
            IPausable.ShortPause();
            userExpirience.PrintMenu();
            
            string mainMenuChoice = Console.ReadLine();
           
            bool goBack = true;
            

            if (mainMenuChoice == "3")
                
            {
                Environment.Exit(0); 
            }

            while (goBack == true)
                
            {

                if (mainMenuChoice == "1")
                    
                {

                    Console.Clear();
                    
                    userExpirience.ShowItems();
                   
                    Console.WriteLine("Enter 'm' to return to main menu");
                    
                    string backToMainMenu = Console.ReadLine();
                   
                    Console.Clear();
                    
                    if (backToMainMenu == "m")
                   
                    {
                        userExpirience.PrintMenu();
                        mainMenuChoice = Console.ReadLine();
                        continue;
                    }

                }

                if (mainMenuChoice == "2")
                
                {
                    
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("    ♦▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬♦");
                    Console.WriteLine("    ♦             (1) Feed Money               ♦");
                    Console.WriteLine("    ♦            (2) Select Product            ♦");
                    Console.WriteLine("    ♦           (3) Finish Transaction         ♦");
                    Console.WriteLine("    ♦▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬♦");
                    Console.WriteLine();
                    Console.WriteLine(" ♦▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬♦");
                    Console.WriteLine($"          Current money provided: {moneyRelated.Balance - moneyRelated.NewBalance}");
                    Console.WriteLine(" ♦▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬♦");
                    Console.WriteLine();
                    Console.WriteLine("             ♦▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬♦");
                    Console.WriteLine("             ♦ Please select 1, 2 or 3 ♦");
                    Console.WriteLine("             ♦▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬♦");
                    moneyRelated.Balance -= moneyRelated.NewBalance;  

                    string subMenuChoice = Console.ReadLine();
                
                    if (subMenuChoice == "1")
                      
                    {    
                        moneyRelated.GetBalance();
                    }

                    if (subMenuChoice == "2")
                       
                    {    
                        moneyRelated.ProductSelection();
                      
                        
                    }

                    if (subMenuChoice == "3")
                        
                    {
                        moneyRelated.GiveChange();
                        IPausable.ShortPause();
                        Environment.Exit(0);   
                    }
                }
                else
                {
                    Environment.Exit(0);
                }

            }

            

            //public VendingItems()
            //{

            //}


        //public List<string> sampleList = new List<string>();


        //public string path = @"C:\Users\Student\git\c-sharp-mini-capstone-module-1-team-1\vendingmachine.csv";

        //public void ShowItems()
        //{
        //    try
        //    {
        //        using (StreamReader stream = new StreamReader(path))
        //        {

        //            while (!stream.EndOfStream)
        //            {

        //                string line = stream.ReadLine();
        //                string[] items = line.Split("|");
        //                sampleList.AddRange(items);

        //                int stock = 5;

        //                Console.WriteLine(string.Join(", ", items) + ", " + stock);


        //            }
        //        }
        //    }

        //    catch (Exception)
        //    {
        //        Console.WriteLine("Error reading file.");
        //    }

        //}

        //public virtual void GetSound(string sound)
        //{
        //    Console.WriteLine("");
        //}

        //public void ProductSelection()
        //{
            

        //    try
        //    {
        //        using (StreamReader stream = new StreamReader(path))
                
        //        {

        //            while (!stream.EndOfStream)
                    
        //            {

        //                string line = stream.ReadLine();
                       
        //                string[] items = line.Split("|");
                        
        //                sampleList.AddRange(items);
                        


        //                int stock = 5;

                        

        //                Console.WriteLine(string.Join(", ", items) + ", " + stock);
                        


        //            }
        //        }
        //    }

        //    catch (Exception)
        //    {
        //        Console.WriteLine("Error reading file.");
                
        //    }
        //    Console.WriteLine("Enter Product code:");
            
        //    string userInput = Console.ReadLine();
            
        //    for (int i = 0; i < sampleList.Count; i++)
            
        //    {
        //        if (sampleList[i].Equals(userInput))
                
        //        {
                    
        //            Console.WriteLine("your choice is " + sampleList[i + 1]);
                 
        //            Console.WriteLine("price: " + sampleList[i + 2]);
        //            decimal priceOf = decimal.Parse(sampleList[i + 2]);

        //            Console.WriteLine("Your remaining balance is: " + vendingMachine.subtractFromBalance(priceOf));

                    
        //            if (sampleList[i + 3].Equals("Chip"))
        //            {
        //                Chips chips = new Chips();
        //                Console.WriteLine(chips.Sound);
        //            }
        //            if (sampleList[i + 3].Equals("Candy"))
        //            {
        //                Candy candy = new Candy();
        //                Console.WriteLine(candy.Sound);
        //            }
        //            if (sampleList[i + 3].Equals("Drink"))
        //            {
        //                Beverage beverage = new Beverage();
        //                Console.WriteLine(beverage.Sound);
        //            }
        //            if (sampleList[i + 3].Equals("Gum"))
        //            {
        //                Gum gum = new Gum();
        //                Console.WriteLine(gum.Sound);
        //            }
        //            Console.ReadLine();
        //        }
        //    }
        //}
        //public decimal Balance { get; private set; }

        
        //public void PrintMenu()
        //{
        //    Console.WriteLine("*******************************");
        //    Console.WriteLine("(1) Display Vending Machine Items");
        //    Console.WriteLine("(2) Purchase");
        //    Console.WriteLine("(3) Exit");
        //    Console.WriteLine("Select 1, 2 or 3");
            
        //}




       

        //public void GetBalance()


        //{
           
        //    Console.WriteLine("Enter whole dollar amount: "); 
        //    string amountEntered = Console.ReadLine();
           

        //    decimal.TryParse(amountEntered, out decimal balance);
           

        //    this.Balance += balance;
            

        //}
        //public decimal subtractFromBalance(decimal price)
        //{
        //    return this.Balance - price;
        //}



        //while (mainMenuChoice == "2")
        //{
        //    Console.WriteLine("(1) Feed Money");
        //    Console.WriteLine("(2) Select Product");
        //    Console.WriteLine("(3) Finish Transaction");
        //    Console.WriteLine("Select item");
        //    string subMenuChoice = Console.ReadLine();

        //    if (subMenuChoice == "1")
        //    {
        //        Console.WriteLine("Enter whole dollar amount"); //Fix to follow readme
        //        string amountEntered = Console.ReadLine();
        //        decimal numericalAmountEntered = new decimal();
        //        decimal balance = 0M;
        //        decimal.TryParse(amountEntered, out balance);

        //        //sampleList.AddRange(items);

        //        balance += numericalAmountEntered;
        //        Console.WriteLine("Balance: " + balance);
        //    }

        //    if (subMenuChoice == "2")
        //    {
        //        try
        //        {
        //            using (StreamReader stream = new StreamReader(path))
        //            {

        //                while (!stream.EndOfStream)
        //                {

        //                    string line = stream.ReadLine();
        //                    string[] items = line.Split("|");
        //                    sampleList.AddRange(items);

        //                    int stock = 5;

        //                    // Console.WriteLine(string.Join(", ", items) + ", " + stock);

        //                }
        //            }
        //        }

        //        catch (Exception)
        //        {
        //            Console.WriteLine("Error reading file.");
        //        }

        //        Console.WriteLine("Select product (A1, B3, etc...)");
        //        string userSelection = Console.ReadLine();

        //        //Lots to add here

        //        if (userSelection == "A1" || userSelection == "A2" || userSelection == "A3" || userSelection == "A4")
        //        {
        //            Chips chips = new Chips();
        //            Console.WriteLine(chips.Sound);
        //        }

        //        string userInput = userSelection;

        //        for (int i = 0; i < sampleList.Count; i++)
        //        {
        //            if (sampleList[i].Equals(userInput))
        //            {
        //                Console.WriteLine("your choice is " + sampleList[i + 1]);
        //                Console.WriteLine("price: " + sampleList[i + 2]);
        //                //string[] itemsAndStock = new string[5] {[i], [i + 1], [i + 2], [i + 3], [i + 4], "5"};
        //            }
        //        }

        //        // subtract from balance
        //    }

        //}





    }


}
} //I had a build error and it said that i needed } brackets at the end here. Added these and will run tests now. DV
















