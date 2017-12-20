using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;
            double money = 100d;
            double result = 0d;
            context = new Context("正常收费");
            result = context.AcceptCash(money);
            Console.WriteLine($"应收{money},实收{result}");

            context = new Context("满30减1");
            result = context.AcceptCash(money);
            Console.WriteLine($"应收{money},实收{result},九折");

            context = new Context("打九折");
            result = context.AcceptCash(money);
            Console.WriteLine($"应收{money},实收{result},满三十减1");

        }
    }
}
