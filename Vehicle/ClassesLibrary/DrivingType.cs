using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Interfaces;

namespace Vehicle.Classes
{
    internal class DrivingType : Engine, IDrive, IVehicle, IUnits, IEnvironment //driving type = vehicle 
    {
        public int Wheels { get; } = 0;

        public DrivingType(int wheels)
        {
            Wheels = wheels;
        }

        public int CurrentSpeed { get; set; }
        public int SpeedMax { get => 350; } 
        public int SpeedMin { get => 0; } 
        public int TargetSpeed { get; set; }


        public IEnvironment.environments currentEnvironment;
        public IVehicle.StartVehicle isStarted; //we create new variable
        public IVehicle.StartVehicle GetState() => isStarted;

        public IUnits.SpeedUnits unit; //we create new variable

        public DrivingType(int wheels, int currentSpeed, int targetSpeed, IEnvironment.environments currentEnvironment, IVehicle.StartVehicle isStarted, IUnits.SpeedUnits unit)
        {
            Wheels = wheels;
            CurrentSpeed = currentSpeed;
            TargetSpeed = targetSpeed;
            this.currentEnvironment = currentEnvironment;
            this.isStarted = isStarted;
            this.unit = unit;
        }
        public DrivingType()
        {

        }
        public IUnits.SpeedUnits GetUnit() => unit;
        public void Accelerate(int CurrentSpeed)
        {
            CurrentSpeed = this.CurrentSpeed;

            if (isStarted == IVehicle.StartVehicle.Started)
            {
                while (CurrentSpeed != TargetSpeed && CurrentSpeed < SpeedMax)
                {
                    Console.WriteLine($"Your current speed is: {CurrentSpeed +=10}{IUnits.SpeedUnits.kmph}"); 
                }              
            }
           
            Console.WriteLine($"Your current speed is: {CurrentSpeed}{IUnits.SpeedUnits.kmph}");

        }

        public void Decelerate(int CurrentSpeed)
        {
            CurrentSpeed = this.CurrentSpeed;

            if (isStarted == IVehicle.StartVehicle.Started)
            {
                while (CurrentSpeed != TargetSpeed && CurrentSpeed > SpeedMin)
                {
                    Console.WriteLine($"Your current speed is: {CurrentSpeed -= 10}{IUnits.SpeedUnits.kmph}");
                }
            }


            Console.WriteLine($"Your current speed is: {CurrentSpeed}{IUnits.SpeedUnits.kmph}");
        }
      

        public void ChangeEnvironment()
        {
            Console.Write("To what environment? land/water/sky: ");
            string input = Console.ReadLine();

            if (input == "land")
            {
                IEnvironment.environments toLand = IEnvironment.environments.land;
                Console.WriteLine($"Currently you are in {toLand}");

            }
            else if (input == "water")
            {
                IEnvironment.environments toWater = IEnvironment.environments.water;
                Console.WriteLine($"Currently you are in {toWater}");
            }
            else if (input == "sky")
            {
                IEnvironment.environments toSky = IEnvironment.environments.sky;
                Console.WriteLine($"Currently you are in {toSky}");
            }
        }

        public override string ToString()
        {
            return $"Number of wheels: {Wheels} , Current speed: {CurrentSpeed}{IUnits.SpeedUnits.kmph}, Max speed of this vehicle is: {SpeedMax}{IUnits.SpeedUnits.kmph}, Min speed of this vehicle is: {SpeedMin}{IUnits.SpeedUnits.kmph}, Your target speed is: {TargetSpeed}{IUnits.SpeedUnits.kmph}, Current environment is: {currentEnvironment}, Your vehicle is: {IVehicle.StartVehicle.Stopped}";
        }

    }
}
