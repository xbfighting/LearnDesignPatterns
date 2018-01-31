
namespace DependenceInversionPrinciple
{
    public class HigherLayer
    {
        private IAnimal _animal;
        // Animal's daliy
        public HigherLayer(string type)
        {
            switch (type)
            {
                case "PIG":
                    _animal = new Pig();
                    break;
                case "DOG":
                    _animal = new Dog();
                    break;
                default:
                    break;
            }
        }

        public IAnimal GetAnimal()
        {
            return _animal;
        }

        public void DaliyPlay()
        {
            _animal.Sleep();
            _animal.Eat();
            _animal.Walk();
        }
    }
}
