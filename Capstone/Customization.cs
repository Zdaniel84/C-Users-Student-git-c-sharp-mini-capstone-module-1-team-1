using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class Customization
    {
        
        public void GetPicture(string picFile)
        {
            string directory = Environment.CurrentDirectory;
            string file = picFile;
            string pic = Path.Combine(directory, file);

            try
            {
                using (StreamReader sr = new StreamReader(pic))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
