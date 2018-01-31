using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenceInversionPrinciple
{
    public interface  IAnimal
    {
        void Eat();

        void Sleep();

        void Walk();
    }
}
