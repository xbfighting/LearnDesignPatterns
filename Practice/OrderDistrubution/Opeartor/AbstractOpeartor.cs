using System;

namespace OrderDistrubution.Opeartor
{
    /// <summary>
    /// AbstractOpeartor 继承 IOpeartor
    /// 抽象操作层，实现一些公用的方法，特定的操作类不需要重复实现，也可以重写，减少代码冗余。
    /// </summary>
    public abstract class AbstractOpeartor : IOpeartor
    {
        public abstract void Op1(string str);

        public abstract void Op2(string str);

        public abstract void Op3(string str);

        public virtual void Default(string str)
        {
            // 默认实现，大多的操作类这个动作都一样。
            Console.WriteLine("Default Console.WriteLine Default 2!");
        }
    }
}
