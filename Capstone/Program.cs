using System;
using System.Collections.Generic;
using System.IO;

namespace Capstone
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
            Console.WriteLine("Select item");
            
            string mainMenuChoice = Console.ReadLine();
            string fullPath = @"C:\Users\Student\git\c-sharp-mini-capstone-module-1-team-1\vendingmachine.csv";
            
            VendingItems vend = new VendingItems();
            VendingMachine bal = new VendingMachine();
            Customer cust = new Customer();

            List<string> sample = new List<string>();

            if (mainMenuChoice == "1")
            {
                int userBuys = 0;
                int stock = 5;


                using (StreamReader sr = new StreamReader(fullPath))
                {

                    while (!sr.EndOfStream)
                    {

                        string line = sr.ReadLine();

                        string[] items = line.Split('|');

                        sample.AddRange(items);

                        if (userBuys == 0)
                        {
                            Console.WriteLine(string.Join(", ", items) + $", {stock - userBuys}");
                        }
                        else if (userBuys == 1)
                        {
                            Console.WriteLine(string.Join(", ", items) + $", {stock - userBuys}");
                        }
                        else if (userBuys == 2)
                        {
                            Console.WriteLine(string.Join(", ", items) + $", {stock - userBuys}");
                        }
                        else if (userBuys == 3)
                        {
                            Console.WriteLine(string.Join(", ", items) + $", {stock - userBuys}");
                        }
                        else if (userBuys >= 4)
                        {
                            Console.WriteLine(string.Join(", ", items) + $", {stock - userBuys}");
                        }
                        else
                        {
                            Console.WriteLine("SOLD OUT");
                        }
                        continue;
                    }
                        Console.WriteLine();
                        Console.WriteLine("(1) Display Vending Machine Items");
                        Console.WriteLine("(2) Purchase");
                        Console.WriteLine("(3) Exit");
                        Console.WriteLine("Select item");
                        Console.WriteLine();
                        string secondAnswer = Console.ReadLine();
                    if( secondAnswer == "3")
                    {
                        Environment.Exit(0);
                    }
                    

                    
                     if (secondAnswer == "2")
                    {
                        Console.WriteLine("(1) Feed Money");
                        Console.WriteLine("(2) Select Product");
                        Console.WriteLine("(3) Finish Transaction");
                        //Console.WriteLine($"Current Balance: { Balance }");
                        Console.WriteLine();
                        string thirdAnswer = Console.ReadLine();

                    }



                    //if (mainMenuChoice == "1")
                    //{

                    //    try
                    //    {
                    //        using (StreamReader stream = new StreamReader(path))
                    //        {

                    //            while (!stream.EndOfStream)
                    //           {
                    //                string line = stream.ReadLine();
                    //               //string[] items = line.Split("|");

                    //                Console.WriteLine(line);
                    //           }
                    //        }
                    //    }

                    //    catch (Exception)
                    //    {
                    //        Console.WriteLine("Error reading file.");
                    //    }


                    //}



                }


            }


        }

    }
}









