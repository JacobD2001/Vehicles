using Vehicle.Classes;

//Create object of SwimType
SwimType Amphibian = new SwimType(Engine.FuelType.Diesel, 12, 600);
//Prints Info
Console.WriteLine(Amphibian.ToString());
//Method testing (only those which are characteristic for SwimType)
Amphibian.BringUpAnchor();
Amphibian.DropAnchor();
Amphibian.ChangeEnvironment(); //pick land as it's amfibia and than go to the water
Amphibian.Swim();
////////////////////
List<SwimType> SwimmingVehicles = new List<SwimType>();
SwimType Cargoship = new SwimType(Engine.FuelType.Diesel, 0, 67264);
SwimType Submarine = new SwimType(Engine.FuelType.Diesel, 0, 1384);
SwimmingVehicles.Add(Cargoship);
SwimmingVehicles.Add(Amphibian);
SwimmingVehicles.Add(Submarine);
//Prints info
Console.WriteLine(Cargoship.ToString());
Console.WriteLine(Submarine.ToString());
Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Create object of DrivingType
DrivingType Car = new DrivingType(4, 60, 150, Vehicle.Interfaces.IEnvironment.environments.land, Vehicle.Interfaces.IVehicle.StartVehicle.Started, Vehicle.Interfaces.IUnits.SpeedUnits.kmph);
//Prints Info
Console.WriteLine(Car.ToString());
//Method testing (only those which are characteristic for DrivingType)
Car.GetState();
Car.Accelerate(50);
Car.Decelerate(50);
Car.ChangeEnvironment();
////////////////////
List<DrivingType> DrivingVehicles = new List<DrivingType>();
DrivingType Truck = new DrivingType(8, 90, 20, Vehicle.Interfaces.IEnvironment.environments.land, Vehicle.Interfaces.IVehicle.StartVehicle.Started, Vehicle.Interfaces.IUnits.SpeedUnits.kmph);
DrivingType Tank = new DrivingType(0, 40, 80, Vehicle.Interfaces.IEnvironment.environments.land, Vehicle.Interfaces.IVehicle.StartVehicle.Started, Vehicle.Interfaces.IUnits.SpeedUnits.kmph);
DrivingVehicles.Add(Car);
DrivingVehicles.Add(Truck);
DrivingVehicles.Add(Tank);
//Prints info
Console.WriteLine(Truck.ToString());
Console.WriteLine(Tank.ToString());
Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Create object of FlyingType
FlyingType Helicopter = new FlyingType(0,50,1000);
//Prints Info
Console.WriteLine(Helicopter.ToString());
//Method testing (only those which are characteristic for FlyingType)
Helicopter.FlyUp(1000);
////////////////////
List<FlyingType> FlyingVehicles = new List<FlyingType>();
FlyingType Airplane = new FlyingType(22, 1000, 4000);
FlyingType Aerocraft = new FlyingType(10, 10000, 0);
FlyingVehicles.Add(Helicopter);
FlyingVehicles.Add(Airplane);
FlyingVehicles.Add(Aerocraft);
//Prints Info
Console.WriteLine(Airplane.ToString());
Console.WriteLine(Aerocraft.ToString());
Console.WriteLine("------THE END OF THE TEST-----");