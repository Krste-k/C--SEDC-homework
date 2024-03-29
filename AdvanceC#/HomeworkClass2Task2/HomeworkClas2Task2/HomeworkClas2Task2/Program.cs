﻿//Car Service

//Create one abstract class Vehicle with abstract method Drive, and two classes Car and Truck that inherit from Vehicle and override the method Drive.
//Create 3 interfaces:
//ICarWash that has methods WashCar that works for Cars, and WashTrailer that works for Trailers.
//IGasPump that has method PumpGas that works for all vehicles
//IRepairService that has methods CheckVehicle and FixVehicle that work for all vehicles.
//Implement each interface in a different class: CarWash, GasPump and RepairService.
//Implement all interfaces in one class CarCenter.
//Methods can be implemented with Console.Writeline or changing and checking bools (ex. isClean, isGasFull, isBroken...)

using HomeworkClas2Task2.Entities;

Car car = new Car("BMW", 2019);
Truck truck = new Truck("Ford", 2021);
CarCenter carCenter = new CarCenter();

car.Drive();
truck.Drive();

carCenter.WashCar(car);
carCenter.WashTrailer(truck);

carCenter.PumpGas(car);
carCenter.PumpGas(truck);

carCenter.CheckVehicle(car);
carCenter.CheckVehicle(truck);

carCenter.FixVehicle(car);
carCenter.FixVehicle(truck);