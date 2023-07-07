using AbstractFactory;

VehicleFamilfyFactory vehicleFamilfyFactory = new BikeFamilyFactory();

VehicleFactory carFactory = vehicleFamilfyFactory.CreateCarFactory();
VehicleFactory bikeFactory = vehicleFamilfyFactory.CreateBikeFactory();

Vehicle car = carFactory.CreateVehicle();
Vehicle bike = bikeFactory.CreateVehicle();

car.Drive();
bike.Drive();
