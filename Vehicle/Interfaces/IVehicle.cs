using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Interfaces
{
    internal interface IVehicle
    {
        enum StartVehicle { Started, Stopped }
        StartVehicle GetState ();
        int CurrentSpeed { get; set; }

        int SpeedMax { get;}
        int SpeedMin { get;}
        int TargetSpeed { set; }
        void Accelerate(int CurrentSpeed);
        void Decelerate(int CurrentSpeed);
       
        


    }
}
