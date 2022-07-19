using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Classes
{
    internal class Engine
   {
        public enum FuelType {Gasoline,Electric,LPG,Diesel,Hybrid }
        FuelType fuelType { get; }
        int HorsePower { get; }

        public override string ToString()
        {
            return $"Engine is powered by {fuelType} and horsepower of the engine is {HorsePower}";
        }
    }
}
