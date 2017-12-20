using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTest
{
    public abstract class AbstractOpeartor : IOpeartor
    {
        public abstract void Op1(string str);

        public abstract void Op2(string str);

        public abstract void Op3(string str);

        public virtual void Default(string str)
        {
            Console.WriteLine("Default Console.WriteLine Default 2!");
        }
    }
}
