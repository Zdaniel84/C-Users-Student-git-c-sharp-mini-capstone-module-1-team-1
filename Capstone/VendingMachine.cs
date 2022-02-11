using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
<<<<<<< HEAD
=======
        public void PrintMenu()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
            Console.WriteLine("Select 1, 2 or 3");
            string mainMenuChoice = Console.ReadLine();
        }
>>>>>>> 8a3c44b6f969b981be7b5cb7a857ee22a16c6b2d


        public decimal Balance { get; private set; } = 0;

        public VendingMachine()
        {
           
        }


        public virtual void DepositMoney() 
        {
            switch (Balance)
            {
                case (1):
                    this.Balance += 1;
                    break;
                case (5):
                    this.Balance += 5;
                    break;
                case (10):
                    this.Balance += 10;
                    break;
                case (20):
                    this.Balance += 20;
                    break;
                default:
                    Console.WriteLine("Cannot accept value, please enter $1, $5, $10, or $20");
                    break;
            }

        }



















    }
}
