using System;
using System.Collections.Generic;
using System.IO;

namespace Capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VendingItems itemList = new VendingItems();
            decimal currentMoney = 0;
            VendingMachine menuReturn = new VendingMachine();
            menuReturn.PrintMenu();
            string mainMenuChoice = Console.ReadLine();
            string path = @"C:\Users\Student\git\c-sharp-mini-capstone-module-1-team-1\vendingmachine.csv";

            List<string> sampleList = new List<string>();
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
                    itemList.GetItems();
                    Console.WriteLine("Enter 'm' to return to main menu");
                    string backToMainMenu = Console.ReadLine();
                    Console.Clear();
                    if (backToMainMenu == "m")
                    {
                        menuReturn.PrintMenu();
                        mainMenuChoice = Console.ReadLine();

                    }

                }




                if (mainMenuChoice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("(1) Feed Money");
                    Console.WriteLine("(2) Select Product");
                    Console.WriteLine("(3) Finish Transaction");

                    Console.WriteLine("");
                    Console.WriteLine($"Current money provided: {currentMoney.ToString("C")}");
                    Console.WriteLine("");
                    Console.WriteLine("Select 1, 2, or 3");
                    string subMenuChoice = Console.ReadLine();

                    if (subMenuChoice == "1")
                    {
                        Console.WriteLine("Enter whole dollar amount: "); //Fix to follow readme
                        string amountEntered = Console.ReadLine();
                        Console.Clear();
                        decimal balance = new decimal();
                        // decimal balance = 0M;
                        decimal.TryParse(amountEntered, out balance);


                        //sampleList.AddRange(items);

                        currentMoney += balance;
                        Console.WriteLine("Balance: " + currentMoney);
                    }


                    if (subMenuChoice == "2")
                    {


                        VendingItems choice = new VendingItems();

                        choice.ProductSelection();

                        //if (userSelection == "A1" || userSelection == "A2" || userSelection == "A3" || userSelection == "A4")
                        //{
                        //    Chips chips = new Chips();
                        //    Console.WriteLine(chips.Sound);
                        //}
                    }
                    if (subMenuChoice == "3")
                    {
                        Environment.Exit(0);
                    }


                }
                else
                {

                    Environment.Exit(0);

                }

            }


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
}









