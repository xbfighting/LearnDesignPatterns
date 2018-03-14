using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDistrubution.Opeartor
{
    /// <summary>
    /// IOpeartor 定义基础操作
    /// </summary>
    public interface IOpeartor
    {
        void Op1(string str);

        void Op2(string str);

        void Op3(string str);

        void Default(string str);
    }
}
