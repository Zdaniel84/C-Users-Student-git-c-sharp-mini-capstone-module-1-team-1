using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class UserExpirience 
    {
        //public List<string> listOfProducts = new List<string>(); causes stack overfow
        //public List<string> userExpirience = new List<string>(); causes stack overflow
        public List<string> listOfProducts = new List<string>();
        public string path = @"C:\Users\Student\git\c-sharp-mini-capstone-module-1-team-1\vendingmachine.csv";

        public void PrintMenu()
        {

            Console.WriteLine("  ♦▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬♦");
            Console.WriteLine("  ♦      (1) Display Vending Machine Items     ♦");
            Console.WriteLine("  ♦               (2) Purchase                 ♦");
            Console.WriteLine("  ♦                (3) Exit                    ♦");
            Console.WriteLine("  ♦▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬♦");
            Console.WriteLine();
            Console.WriteLine("           ♦▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬♦");
            Console.WriteLine("           ♦ Please select 1, 2 or 3 ♦");
            Console.WriteLine("           ♦▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬♦");

        }
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
                        listOfProducts.AddRange(items);

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



















    }
}
