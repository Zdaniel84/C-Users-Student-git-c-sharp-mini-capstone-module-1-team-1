using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine 
    {
      
        public decimal Balance { get; private set; }

        public VendingMachine(decimal balance)
        {
           
            this.Balance = balance;
        }
        public void PrintMenu()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
            Console.WriteLine("Select 1, 2 or 3");
            //string mainMenuChoice = Console.ReadLine();
            // method to display the main menu on our console DV
        }


       

        public VendingMachine()
        {

        }

        public void GetBalance()


        { 
            //decimal currentMoney = 0;
            //sets the amount that you have avaliable to 0.00 DV
            Console.WriteLine("Enter whole dollar amount: "); //Fix to follow readme 
                                                              // prompts us to enter a dollar amount ex: 1, 2, 4, 10, 20 DV
            string amountEntered = Console.ReadLine();
            // our response DV
            //Console.Clear();
            //decimal balance = 0;
            
            // I would love to get a better explaination of why we need this, because i am unsure :( DV ***
            // This is to declare the variable balance to be used below MR

            decimal.TryParse(amountEntered, out decimal balance);
            // what we have added has been inputted as a string. a tryparse will turn this into a decimal. I feel like it has something to to with the line above DV


            //sampleList.AddRange(items);

            this.Balance += balance;
            //we are adding the currentMoney of accumulated money to the balance of money we have inputted DV
            // Console.WriteLine($"Current money provided: {CurrentMoney.ToString("C")}");
            ////this will display what we have accumulated DV
            //Console.ReadLine();
           // return this.Balance;
            
        }
        public decimal subtractFromBalance(decimal price)
        {
            return this.Balance - price;
        }
        //public virtual void DepositMoney()
        //{
        //    switch (Balance)
        //    {
        //        case (1):
        //            this.Balance += 1;
        //            break;
        //        case (5):
        //            this.Balance += 5;
        //            break;
        //        case (10):
        //            this.Balance += 10;
        //            break;
        //        case (20):
        //            this.Balance += 20;
        //            break;
        //        default:
        //            Console.WriteLine("Cannot accept value, please enter $1, $5, $10, or $20");
        //            break;
        //    }

        //}



















    }
}
