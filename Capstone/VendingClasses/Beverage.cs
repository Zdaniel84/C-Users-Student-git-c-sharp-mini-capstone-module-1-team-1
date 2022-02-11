using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Beverage : VendingItems 
    {

        public string Sound { get; set; } = "Glug Glug, Yum!";
        public Beverage(string slot, string item, decimal price, string type, string sound, int stock) : base(slot, item, price, type, stock)
        {

            this.Sound = sound;


        }

        public override void GetSound(string sound)
        {
            Console.WriteLine("Glug Glug, Yum!");
        }
    }
}
