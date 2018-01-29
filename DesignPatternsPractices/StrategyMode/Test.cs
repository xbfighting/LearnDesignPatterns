using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMode
{
    class Test
    {
        // Just to give an example
        public void TestMode(string type)
        {
            Strategy strategy;
            switch (type)
            {
                case "A":
                    strategy = new Context(new ConcreteStrategyA()).Strategy;
                    break;
                case "B":
                    strategy = new Context(new ConcreteStrategyB()).Strategy;
                    break;
                case "C":
                    strategy = new Context(new ConcreteStrategyC()).Strategy;
                    break;
                default:
                    strategy = new Context(new ConcreteStrategyA()).Strategy;
                    break;
            }

            strategy.AlgorithmInterface();
        }
    }
}
