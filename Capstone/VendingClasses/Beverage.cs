using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Beverage : VendingItems
    {

        public string Sound { get; set; } = "Glug Glug, Yum!";

        public Beverage()
        {

        }

        public override void GetSound(string sound)
        {
            Console.WriteLine("Glug Glug, Yum!");
        }
    }
}
