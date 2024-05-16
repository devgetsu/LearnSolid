using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Fail
{
    public abstract class Vehicle
    {
        protected bool IsEngineWorking { get; set; } = false;

        public abstract void StartEngine();
        public abstract void StopEngine();
        public abstract void MoveForward();
        public abstract void MoveBack();
    }
}
