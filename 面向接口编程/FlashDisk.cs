using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class FlashDisk : IMobileStorage
    {
        public void Read()
        {
            Console.WriteLine("Reading from FlashDisk...");
            Console.WriteLine("Read finished!");
        }

        public void Write()
        {
            Console.WriteLine("Writing to FlashDisk...");
            Console.WriteLine("Write finished!");
        }
    }
}
