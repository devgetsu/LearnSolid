using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.IS.Fail
{
    public class Bird : IAnimal
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
