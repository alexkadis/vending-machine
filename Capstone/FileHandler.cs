using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone
{
    class FileHandler
    {
        private List<VendingItem> GetVendingItems()
        {
            using (StreamReader sr = new StreamReader("Items.txt"))
            {
                List<VendingItem> items = new List<VendingItem>();
                while (!sr.EndOfStream)
                {
                    //**Convert the entire document into a string
                    //string line = sr.ReadLine();
                    string line = sr.ReadLine();


                    Array itemDetails = line.Split("|");

                    for (int i = 0; i < itemDetails.Length; i++)
                    {

                    }


                }
                Console.WriteLine($"There are  words, and  in Alice In Wonderland");
            }
        }
    }
}
