using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.IS.Correct
{
    public class Bird : IAnimal, IFlyable
    {
        public void eat()
        {
            throw new NotImplementedException();
        }

        public void fly()
        {
            throw new NotImplementedException();
        }

        public void sleep()
        {
            throw new NotImplementedException();
        }
    }
}
