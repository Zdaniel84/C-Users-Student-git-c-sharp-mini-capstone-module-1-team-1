using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Chips : VendingItems
    {
        public string Sound { get; set; } = "Crunch Crunch, Yum!";

        public Chips(string slot, string item, decimal price, string type, string sound, int stock) : base(slot, item, price, type, stock)
        {

            this.Sound = sound;


        }
        public Chips()
        {

        }

        public override void GetSound(string sound)
        {
            Console.WriteLine("Crunch Crunch, Yum!");
        }

    }
}
