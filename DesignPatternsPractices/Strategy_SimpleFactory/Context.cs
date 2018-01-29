using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_SimpleFactory
{
    public class Context
    {
        CashSuper cStrategy;

        public Context(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cStrategy = new CashNormal();
                    break;
                case "打九折":
                    cStrategy = new CashRebate("0.9");
                    break;
                case "满30减1":
                    cStrategy = new CashReturn("30", "1");
                    break;
                default:
                    break;
            }
        }

        public double AcceptCash(double money)
        {
            return cStrategy.AcceptCash(money);
        }
    }
}
