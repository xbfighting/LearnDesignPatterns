using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTest
{
    public class SecondOpeartor : AbstractOpeartor
    {
        public override void Op1(string str)
        {
            Console.WriteLine("override abstract Console.WriteLine Op1 2!");
        }

        public override void Op2(string str)
        {
            Console.WriteLine("override abstract Console.WriteLine Op2 2!");
        }

        public override void Op3(string str)
        {
            Console.WriteLine("override abstract Console.WriteLine Op3 2!");
        }

        public void Default(string str)
        {
            Console.WriteLine("override Default Console.WriteLine Default 2!");
        }
    }
}
