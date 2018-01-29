using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_SimpleFactory
{
    abstract class CashSuper
    {
        public abstract double AcceptCash(double money);
    }

    class CashNormal : CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }

    class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;

        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }
        public override double AcceptCash(double money)
        {
            return money * moneyRebate;
        }
    }

    class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;

        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }

        public override double AcceptCash(double money)
        {
            return money - Math.Floor(money / moneyCondition) * moneyReturn;
        }
    }
}
