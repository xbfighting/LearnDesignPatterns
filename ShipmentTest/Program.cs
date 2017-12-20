using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 装饰模式、抽象类集成接口，默认实现几个方法
 */
namespace ShipmentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var fac1 = new DealShipmentFactory(1, 1);
            fac1.ShipmentGen();
            //fac1.BindShipment();

            var fac2 = new DealShipmentFactory(2, 2);
            fac2.ShipmentGen();
            //fac2.BindShipment();

            string stre = "1";


            PrintStr(stre);
            ChangeStr1(stre);
            PrintStr(stre);


            var test = new Test
            {
                Type1 = "Type1",
                Type2 = "Type2",
            };

            PrintStr(test);
            ChangeStr1(test);
            PrintStr(test);

        }

        static void ChangeStr1(string stre)
        {
            stre = "test";
        }

        private static void PrintStr(string stre)
        {
            Console.WriteLine(stre);
        }

        static void ChangeStr1(Test test)
        {
            test.Type1 = "test";
            test.list = new List<int> {1,2};
        }

        static void PrintStr(Test test)
        {
            Console.WriteLine(test.Type1);
            Console.WriteLine(test.Type2);
            Console.WriteLine(test.list);
        }
    }

    public class Test
    {
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public List<int> list { get; set; } 
    }
}
