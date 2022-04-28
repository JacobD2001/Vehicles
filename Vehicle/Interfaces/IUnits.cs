using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Interfaces
{
    internal interface IUnits
    {
        enum SpeedUnits
        {
            kmph,
            knots,
            mps,
            meters
        }

        SpeedUnits GetUnit();
    }
}
