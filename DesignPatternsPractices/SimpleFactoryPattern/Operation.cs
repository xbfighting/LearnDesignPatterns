using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 运算
    /// </summary>
    public class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    /// <summary>
    /// 加法
    /// </summary>
    internal class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }

    /// <summary>
    /// 减法
    /// </summary>
    internal class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    /// <summary>
    /// 乘法
    /// </summary>
    internal class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA*NumberB;
            return result;
        }
    }

    /// <summary>
    /// 除法
    /// </summary>
    internal class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (Math.Abs(NumberB) < 1)
            {
                throw new Exception("除数不能为0。");
            }
            result = NumberA/NumberB;
            return result;
        }
    }
}
