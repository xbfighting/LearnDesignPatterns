using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenceInversionPrinciple
{
    /// <summary>
    /// Pig
    /// </summary>
    public class Pig : IAnimal
    {
        void IAnimal.Eat()
        {
            Console.WriteLine("Pig Eat");
        }

        void IAnimal.Sleep()
        {
            Console.WriteLine("Pig Sleep");
        }

        void IAnimal.Walk()
        {
            Console.WriteLine("Pig Walk");
        }

        /// <summary>
        /// 独有的
        /// </summary>
        void HengHeng()
        {
            Console.WriteLine("Pig HengHeng");
        }
    }

    public class Dog : IAnimal
    {
        void IAnimal.Eat()
        {
            Console.WriteLine("Dog Eat");
        }

        void IAnimal.Sleep()
        {
            Console.WriteLine("Dog Sleep");
        }

        void IAnimal.Walk()
        {
            Console.WriteLine("Dog Walk");
        }

        /// <summary>
        /// 独有的
        /// </summary>
        void WangWang()
        {
            Console.WriteLine("Dog WangWang");
        }
    }
}
