using System;

namespace OrderDistrubution.Opeartor
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
    }
}
