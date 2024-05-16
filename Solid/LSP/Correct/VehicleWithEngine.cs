using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Correct
{
    public abstract class VehicleWithEngine : IVehicle
    {
        protected bool IsEngineWorking { get; set; } = false;

        public abstract void StartEngine();
        public abstract void StopEngine();
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
