using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Candy : VendingItems
    {
        public string Sound { get; set; } = "Munch Munch, Yum!";

        public Candy(string slot, string item, decimal price, string type, string sound, int stock) : base(slot, item, price, type, stock)
        {

            this.Sound = sound;


        }

        public override void GetSound(string sound)
        {
            Console.WriteLine("Munch Munch, Yum!");
        }




    }
}
