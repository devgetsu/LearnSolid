using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.IS.Fail
{
    public class Cat : IAnimal
    {
        public void eat()
        {
            throw new NotImplementedException();
        }

        public void fly()
        {
            // qilolmedi
        }

        public void sleep()
        {
            throw new NotImplementedException();
        }
    }
}
