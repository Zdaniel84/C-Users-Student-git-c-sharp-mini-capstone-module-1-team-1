using System;
using System.IO;

namespace Capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("(1) Display Vending Machine Items");
            //Console.WriteLine("(2) Purchase");
            //Console.WriteLine("(3) Exit");
            //Console.WriteLine("Select item");
            //string mainMenuChoice = Console.ReadLine();
            //string path = @"C:\Users\Student\git\c-sharp-mini-capstone-module-1-team-1\vendingmachine.csv";



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


            //}



        }


    }


}










