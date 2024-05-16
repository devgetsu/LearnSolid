using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Correct
{
    public class Car : VehicleWithEngine
    {
        public override void StartEngine()
        {
            throw new NotImplementedException();
        }

        public override void StopEngine()
        {
            throw new NotImplementedException();
        }

        public void MoveBack()
        {
            throw new NotImplementedException();
        }

        public void MoveForvard()
        {
            throw new NotImplementedException();
        }
    }
}
