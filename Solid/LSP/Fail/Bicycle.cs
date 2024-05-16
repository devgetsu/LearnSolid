using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Fail
{
    public class Bicycle : Vehicle
    {
        public override void MoveBack()
        {
            // ortga yuradi
        }

        public override void MoveForward()
        {
            //oldinga yuradi
        }

        public override void StartEngine()
        {
            // engine not found!!
        }

        public override void StopEngine()
        {
            // engine not found!!
        }
    }
}
