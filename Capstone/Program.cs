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
            //creates item list (however is this necisary?) I cant spell ;~; DV ***
                // This and menuReturn below are declaring a variable and initializing it to be able to use the method in VendingItems class MR
            decimal currentMoney = 0;
            //sets the amount that you have avaliable to 0.00 DV
            VendingMachine menuReturn = new VendingMachine();
            //another menu list? ( If someone could explain ) DV ***
            menuReturn.PrintMenu();
            //this will print the menu from the VendingMachine class. It has a group of CW to print to your console asking if you would like to view the products, purchase or exit DV
            string mainMenuChoice = Console.ReadLine();
            // Choose to 1. View the items 2. Purchase an item 3. Exit the program DV
            //string path = @"C:\Users\Student\git\c-sharp-mini-capstone-module-1-team-1\vendingmachine.csv";
            // This is the path to vendingmachine.csv

           // List<string> sampleList = new List<string>();
            // sample list. Will have more info once why it is here DV ***
                // Good catch, there was no reason for this to be here it was unused MR
            bool goBack = true;
            // When true we will continue throughout the steps DV

            if (mainMenuChoice == "3")
                // the menu will be printed, if we choose "3" it will exit the program DV
            {
                Environment.Exit(0);
                // I personally found this online, I assume the purpose it to exit the program in Console, it was said to be the safest way DV
            }

            while (goBack == true)
                //while this boolean is true we will continue through the program. Now we will have the options within our initial choices. DV
            {

                if (mainMenuChoice == "1")
                    // In the main menu we have pressed "1", Display the menu DV
                {

                    Console.Clear();
                    // "Clears the console buffer and corresponding console window of display information" it will clear our previous menu and ensure this menu will be at the top of our console DV 
                    itemList.ShowItems();
                    //this is necisary! it holds all of the info from our .csv (an assupmtion, plz correct if wrong) DV
                    Console.WriteLine("Enter 'm' to return to main menu");
                    // at the end of our list it will ask if we want to return to the main menu, which is in the class VendingMachine. DV
                    string backToMainMenu = Console.ReadLine();
                    // Go back to that menu if "m" is pressed DV
                    Console.Clear();
                    //this will clear the list of items and bring the Main Menu to the top of our page DV
                    if (backToMainMenu == "m")
                        // IF "m" is pressed ... DV
                    {
                        menuReturn.PrintMenu();
                        // return to main menu DV
                        mainMenuChoice = Console.ReadLine();
                        //ask for another input (1, 2, 3) DV
                        continue;
                    }

                }




                if (mainMenuChoice == "2")
                    //If you are in main menu and press "2" DV
                {
                    Console.Clear();
                    //this will clear previous menu and send this to the top ( can we put this in a subMenu class? ) DV
                    Console.WriteLine("(1) Feed Money");
                    Console.WriteLine("(2) Select Product");
                    Console.WriteLine("(3) Finish Transaction");
                    // there are three options to leave this page DV

                    Console.WriteLine("");
                    Console.WriteLine($"Current money provided: {currentMoney.ToString("C")}");
                    Console.WriteLine("");
                    // we will get an updated count of money we have provided. This method is in the program.cs below DV
                    Console.WriteLine("Select 1, 2, or 3");
                    string subMenuChoice = Console.ReadLine();
                    // this prompts us to make a choice within the sub menu DV 

                    if (subMenuChoice == "1")
                        //we have chosen "1" in the sub menu 
                    {
                        Console.WriteLine("Enter whole dollar amount: "); //Fix to follow readme 
                        // prompts us to enter a dollar amount ex: 1, 2, 4, 10, 20 DV
                        string amountEntered = Console.ReadLine();
                        // our response DV
                        Console.Clear();
                        decimal balance = new decimal();
                        // I would love to get a better explaination of why we need this, because i am unsure :( DV ***
                            // This is to declare the variable balance to be used below MR

                        decimal.TryParse(amountEntered, out balance); 
                        // what we have added has been inputted as a string. a tryparse will turn this into a decimal. I feel like it has something to to with the line above DV


                        //sampleList.AddRange(items);

                        currentMoney += balance;
                        //we are adding the currentMoney of accumulated money to the balance of money we have inputted DV
                        Console.WriteLine("Balance: " + currentMoney);
                        //this will display what we have accumulated DV
                    }


                    if (subMenuChoice == "2")
                        // we have chosen "2" in the subMenu DV
                    {


                        VendingItems choice = new VendingItems();
                        // again would love some further explaination. Tried debugging and dont really understand im sorry DV ***

                        choice.ProductSelection();
                        // this is a method found in the class VendingItems this will show you the choices once again DV

                        //if (userSelection == "A1" || userSelection == "A2" || userSelection == "A3" || userSelection == "A4")
                        //{
                        //    Chips chips = new Chips();
                        //    Console.WriteLine(chips.Sound);
                        //}
                    }
                    if (subMenuChoice == "3")
                        // we have chosen "3" in the subMenu DV
                    {
                        Environment.Exit(0);
                        // it will exit our program as we are finished. I think this is where we implement the method to get change but i could be wrong! DV
                    }


                }
                else
                {

                    Environment.Exit(0);
                    //invalid inputs will close system as well. they close in main but just re-upload the subMenu when invalid key is pressed in subMenu. DV

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
} //I had a build error and it said that i needed } brackets at the end here. Added these and will run tests now. DV
















