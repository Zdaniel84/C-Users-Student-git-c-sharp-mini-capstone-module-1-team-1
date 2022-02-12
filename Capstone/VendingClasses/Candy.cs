using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Candy : VendingItems
    {
        public string Sound { get; set; } = "Munch Munch, Yum!";

 
        public Candy()
        {

        }

        public override void GetSound(string sound)
        {
            Console.WriteLine("Munch Munch, Yum!");
        }




    }
}
