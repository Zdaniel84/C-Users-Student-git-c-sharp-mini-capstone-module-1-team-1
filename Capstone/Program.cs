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
                Console.Clear();



                if (mainMenuChoice == "2")
                {

                    Console.WriteLine("(1) Feed Money");
                    Console.WriteLine("(2) Select Product");
                    Console.WriteLine("(3) Finish Transaction");

                    Console.WriteLine("");
                    Console.WriteLine("Current money provided: " + currentMoney);
                    Console.WriteLine("");
                    Console.WriteLine("Select 1, 2, or 3");
                    string subMenuChoice = Console.ReadLine();
                    while (goBack == true)
                    {
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
                        itemList.GetItems();

                        if (subMenuChoice == "2")
                        {
                            //Console.WriteLine("Select product (A1, B3, etc...)");
                            //string userSelection = Console.ReadLine();

                            ////Lots to add here

                            //if (userSelection == "A1" || userSelection == "A2" || userSelection == "A3" || userSelection == "A4")
                            //{
                            //    Chips chips = new Chips();
                            //    Console.WriteLine(chips.Sound);
                            //}


                            Console.WriteLine("Enter product code");
                            string userInput = Console.ReadLine();

                            var lines = File.ReadAllLines(path);

                            for (int i = 0; i < lines.Length; i += 5)
                            {
                                if (userInput == "A1")
                                    Console.WriteLine($"Your choice was {lines[0]}");
                                if (userInput == "A2")
                                    Console.WriteLine($"Your choice was {lines[1]}");
                                if (userInput == "A3")
                                    Console.WriteLine($"Your choice was {lines[2]}");
                                if (userInput == "A4")
                                    Console.WriteLine($"Your choice was {lines[3]}");
                                if (userInput == "B1")
                                    Console.WriteLine($"Your choice was {lines[4]}");
                                if (userInput == "B2")
                                    Console.WriteLine($"Your choice was {lines[5]}");
                                if (userInput == "B3")
                                    Console.WriteLine($"Your choice was {lines[6]}");
                                if (userInput == "B4")
                                    Console.WriteLine($"Your choice was {lines[7]}");
                                if (userInput == "C1")
                                    Console.WriteLine($"Your choice was {lines[8]}");
                                if (userInput == "C2")
                                    Console.WriteLine($"Your choice was {lines[9]}");
                                if (userInput == "C3")
                                    Console.WriteLine($"Your choice was {lines[10]}");
                                if (userInput == "C4")
                                    Console.WriteLine($"Your choice was {lines[11]}");
                                if (userInput == "D1")
                                    Console.WriteLine($"Your choice was {lines[12]}");
                                if (userInput == "D2")
                                    Console.WriteLine($"Your choice was {lines[13]}");
                                if (userInput == "D3")
                                    Console.WriteLine($"Your choice was {lines[14]}");
                                if (userInput == "D4")
                                    Console.WriteLine($"Your choice was {lines[15]}");





                                //string[] itemsAndStock = new string[5] {[i], [i + 1], [i + 2], [i + 3], [i + 4], "5"};
                            }



                        }


                    }

                }
            }
            if (mainMenuChoice == "3")
            {

                Environment.Exit(0);
                goBack = false;
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

        //for (int i = 0; i < itemList.Count; i++)
        //{
        //    if (itemList[i].Equals(userInput))
        //    {
        //        Console.WriteLine("your choice is " + itemList[i + 1]);
        //        Console.WriteLine("price: " + itemList[i + 2]);
        //        //string[] itemsAndStock = new string[5] {[i], [i + 1], [i + 2], [i + 3], [i + 4], "5"};
        //    }
        //}

        // subtract from balance
    }

}

















