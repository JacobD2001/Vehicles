using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Interfaces
{
    internal interface IFly
    {
        public int MetersAboveGround { get; set; }
        void FlyUp(int TargetHeight);
        void FlyDown(int TargetHeight);

    }
}
