using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class MobileHardDisk : IMobileStorage
    {
        public void Read()
        {
            Console.WriteLine("Reading from MobileHardDisk...");
            Console.WriteLine("Read finished!");
        }

        public void Write()
        {
            Console.WriteLine("Writing to MobileHardDisk...");
            Console.WriteLine("Write finished!");
        }
    }
}