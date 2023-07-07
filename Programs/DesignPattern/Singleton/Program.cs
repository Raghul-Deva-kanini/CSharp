using Singleton;

VehicleFactory vehicleFactory = VehicleFactory.Instance;

Vehicle car = vehicleFactory.CreateVehicle("car");
Vehicle bike = vehicleFactory.CreateVehicle("bike");

car.Drive();
bike.Drive();

Vehicle car2 = vehicleFactory.CreateVehicle("car");
car2.Drive();
