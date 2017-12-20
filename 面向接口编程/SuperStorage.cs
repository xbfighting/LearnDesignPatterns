using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class SuperStorage
    {
        public SuperStorage()
        {
        }

        public void ReadEx()
        {
            Console.WriteLine("Reading from SuperStorage... (ReadEx)");
            Console.WriteLine("Read finished!");
        }

        public void WriteEx()
        {
            Console.WriteLine("Writing to SuperStorage... (WriteEx)");
            Console.WriteLine("Write finished!");
        }
    }
}
