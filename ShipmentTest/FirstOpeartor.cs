using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTest
{
    public class FirstOpeartor : AbstractOpeartor
    {
        public override void Op1(string str)
        {
            Console.WriteLine("override abstract Console.WriteLine Op1 1!");
        }

        public override void Op2(string str)
        {
            Console.WriteLine("override abstract Console.WriteLine Op2 1!");
        }

        public override void Op3(string str)
        {
            Console.WriteLine("override abstract Console.WriteLine Op3 1!");
        }

        public override void Default(string str)
        {
            Console.WriteLine("override default Console.WriteLine Default 1!");
        }
    }
}
