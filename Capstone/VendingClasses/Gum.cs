using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Gum : VendingItems
    {



        public string Sound { get; set; } = "Chew Chew, Yum!";
        public Gum(string slot, string item, decimal price, string type, string sound, int stock) : base(slot, item, price, type, stock)
        {

            this.Sound = sound;


        }
        public override void GetSound(string sound)
        {
            Console.WriteLine("Chew Chew, Yum!");
        }

    }
}
