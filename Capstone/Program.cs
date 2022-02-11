using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.Generic;

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
                string path = @"C:\Users\Student\git\c-sharp-mini-capstone-module-1-team-1\vendingmachine.csv";
        
            

            

            //Chips fritos = new Chips();

           
            //Console.WriteLine(fritos.Type);

            //VendingItems vend = new VendingItems();

            List<string> sampleList = new List<string>();
            //bool goBack = true;
            bool goBack = false;
            while (goBack == false)
            {
                if (mainMenuChoice == "1")
                {



                    VendingItems itemList = new VendingItems();

                    itemList.GetItems();


                    VendingMachine menuReturn = new VendingMachine();
                    menuReturn.PrintMenu();
                    
                    

                }
                
                if (mainMenuChoice == "2")
                {
                    Console.WriteLine("(1) Feed Money");
                    Console.WriteLine("(2) Select Product");
                    Console.WriteLine("(3) Finish Transaction");
                    Console.WriteLine("Select item");
                    string subMenuChoice = Console.ReadLine();

                    if (subMenuChoice == "1")
                    {
                        Console.WriteLine("Enter whole dollar amount"); //Fix to follow readme
                        string amountEntered = Console.ReadLine();
                        decimal numericalAmountEntered = new decimal();
                        decimal balance = 0M;
                        decimal.TryParse(amountEntered, out balance);

                        sample.AddRange(items);


            Chips fritos = new Chips();

           
            Console.WriteLine(fritos.Type);
           

            

            //if (mainMenuChoice == "1")
            //{

            //    try
            //    {
            //        using (StreamReader stream = new StreamReader(path))
            //        {

            //            while (!stream.EndOfStream)
            //            {
            //                string line = stream.ReadLine();
            //                //string[] items = line.Split("|");
                            
            //                Console.WriteLine(line);
            //            }
            //        }
            //    }

            //    catch (Exception)
            //    {
            //        Console.WriteLine("Error reading file.");
            //    }

                        // subtract from balance
                    }

            //}



        }


            }


        }

    }
}









