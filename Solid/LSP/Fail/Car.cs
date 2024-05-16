using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Fail
{
    public class Car : Vehicle
    {
        public override void MoveBack()
        {
            //ortga
        }

        public override void MoveForward()
        {
            //oldinga
        }

        public override void StartEngine()
        {
            // engine started
        }

        public override void StopEngine()
        {
            //engine stopped
        }
    }
}
