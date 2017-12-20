using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class NewMobileStorage : IMobileStorage
    {
        public void Read()
        {
            Console.WriteLine("Reading from NewMobileStorage...");
            Console.WriteLine("Read finished!");
        }

        public void Write()
        {
            Console.WriteLine("Writing to NewMobileStorage...");
            Console.WriteLine("Write finished!");
        }
    }
}
