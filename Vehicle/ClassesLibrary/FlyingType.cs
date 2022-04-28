using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Interfaces;
namespace Vehicle.Classes
{
    internal class FlyingType : DrivingType, IFly
    {
        
        public new int SpeedMax { get => 200; }
        public new int SpeedMin { get => 20; }
        
        int IFly.MetersAboveGround { get; set; }
        public int TargetHeight { get; set; }
        public int CurrentHeight { get; set; }

        public new int CurrentSpeed;
        public int MaxHeight = 14000;
        public int MinHeight = 0;

        public FlyingType(int wheels) : base(wheels) { }
                            
        public FlyingType(int targetHeight, int currentHeight, int currentSpeed)
        {
            TargetHeight = targetHeight;
            CurrentHeight = currentHeight;
            CurrentSpeed = currentSpeed;
            
        }

        public void FlyDown(int TargetHeight)
        {

            TargetHeight = this.TargetHeight;

        

            if (isStarted == IVehicle.StartVehicle.Started)
            {
                if (CurrentHeight == TargetHeight)
                {
                    Console.WriteLine($"Your current height is: {CurrentHeight} { IUnits.SpeedUnits.meters}");
                }

                while (CurrentHeight > TargetHeight)
                {
                    Console.WriteLine($"Your current height is: {CurrentHeight -= 50} { IUnits.SpeedUnits.meters}");   
                    
                }

                if (CurrentHeight == 0)
                {
                    Console.WriteLine("You landed!");
                }
            }
  
        }

        public void FlyUp(int TargetHeight)
        {

            TargetHeight = this.TargetHeight;

            if (isStarted == IVehicle.StartVehicle.Started)
            {
                if (CurrentHeight == TargetHeight)
                {
                   Console.WriteLine($"Your current height is: {CurrentHeight} { IUnits.SpeedUnits.meters}");
                }
                while (CurrentHeight < TargetHeight)
                {
                    Console.WriteLine($"Your current height is: {CurrentHeight += 50} { IUnits.SpeedUnits.meters}");


                }
     
               
            }
   
        }
    
        public override string ToString()
        {
            return $"Number of wheels: {Wheels} , Current speed: {CurrentSpeed}{IUnits.SpeedUnits.mps}, Max speed of this vehicle is: {SpeedMax}{IUnits.SpeedUnits.mps},\n Min speed of this vehicle is: {SpeedMin}{IUnits.SpeedUnits.mps}, Your target speed is: {TargetSpeed}{IUnits.SpeedUnits.mps}, Current environment is: {IEnvironment.environments.sky},\n Your vehicle is: {isStarted}, your current height is: {CurrentHeight}{IUnits.SpeedUnits.meters}, your target height is: {TargetHeight}{IUnits.SpeedUnits.meters}";
        }


    }
}
