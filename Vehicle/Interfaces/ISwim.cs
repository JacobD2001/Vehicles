using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Interfaces
{
    internal interface ISwim
    {
        int Displacement { get; }
        void Swim();
        void LeaveWater();
        void DropAnchor();
        void BringUpAnchor();
    }
}
