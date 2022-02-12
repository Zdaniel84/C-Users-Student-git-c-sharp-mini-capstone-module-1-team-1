using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Gum : VendingItems
    {



        public string Sound { get; set; } = "Chew Chew, Yum!";
     

        public Gum()
        {

        }
        public override void GetSound(string sound)
        {
            Console.WriteLine("Chew Chew, Yum!");
        }

    }
}
