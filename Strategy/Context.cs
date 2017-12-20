using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Context
    {
        CashSuper cStrategy;
        public Context(string type)
        {
            switch(type)
            {
                case "正常收费":
                    this.cStrategy = new CashNormal();
                    break;
                case "满30减1":
                    this.cStrategy = new CashReturn("30", "1");
                    break;
                case "打九折":
                    this.cStrategy = new CashRebate("0.9");
                    break;
            }
        }

        public double AcceptCash(double money)
        {
            return cStrategy.acceptCash(money);
        }
    }
}
