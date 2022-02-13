using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Capstone
{
    public interface IPausable
    {
        public static void ShortPause()
        {
            Thread.Sleep(1000);
        }

        public static void LongPause()
        {
            Thread.Sleep(3000);
        }

        
    }
}
