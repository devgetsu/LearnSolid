using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Correct
{
    public class Circle : IShape
    {
        public double radius { get; set; }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }
    }
}
