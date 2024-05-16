using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Correct
{
    public class Rectangle : IShape
    {
        public double length { get; set; }
        public double height { get; set; }
        public double getArea()
        {
            return length * height;
        }
    }
}
