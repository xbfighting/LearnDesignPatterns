
namespace StrategyMode
{
    class Context
    {
        public Strategy Strategy;

        public Context(Strategy strategy)
        {
            Strategy = strategy;
        }

        public void AlgorithmInterface()
        {
            Strategy.AlgorithmInterface();
        }
    }
}
