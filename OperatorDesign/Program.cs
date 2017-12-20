using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            //var operationAdd = new OperationAdd
            //{
            //    NumberA = 10,
            //    NumberB = 10
            //};
            //var result = operationAdd.GetResult();
            //Console.WriteLine(result);


            //var operationDiv = new OperationDiv
            //{
            //    NumberA = 10,
            //    NumberB = 0
            //};
            //result = operationDiv.GetResult();
            //Console.WriteLine(result);

            
            Operation oper;
            oper = OperationFactory.CreateOperate("*");
            oper.NumberA = 10;
            oper.NumberB = 11;
            var result = oper.GetResult();
            Console.WriteLine(result);
        }
    }
}
