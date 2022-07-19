using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Interfaces;

namespace Vehicle.Classes
{
    internal class SwimType : DrivingType, ISwim
    {  
        public new int SpeedMax { get => 40; }
        public new int SpeedMin { get => 1; }
        public int displacement = 0;

        FuelType fuelTypeOfSwim = FuelType.Diesel;

        public SwimType(FuelType fuelTypeOfSwim, int wheels, int displacement) : base(wheels)
        {
            this.fuelTypeOfSwim = fuelTypeOfSwim;
            wheels = 0;
            this.Displacement = displacement;
        }

        public int Displacement { get; }

        public void BringUpAnchor()
        {
            Console.WriteLine("Anchor is up, ahoi!");
        }

        public void DropAnchor()
        {
            Console.WriteLine("Anchor is at the bottom, take some rest");
        }

        public void LeaveWater()
        {
            Console.WriteLine("You are amfibia and you left water, nice work!");
        }

        public void Swim()
        {
            Console.WriteLine("Welcome back in the water, cool down a bit.");
        }
    
        public override string ToString()
        {
            return $"Current speed is: {CurrentSpeed}{IUnits.SpeedUnits.knots}, Max speed of this vehicle is: {SpeedMax}{IUnits.SpeedUnits.knots}, Min speed of this vehicle is: {SpeedMin}{IUnits.SpeedUnits.knots},\n Your target speed is: {TargetSpeed}{IUnits.SpeedUnits.knots}, Current environment is: {IEnvironment.environments.water}, Number of wheels is: {Wheels}\n Your vehicle is: {IVehicle.StartVehicle.Stopped}, Your displacement is {Displacement}, You tank your vehicle with: {fuelTypeOfSwim}";
        }

    }
}
