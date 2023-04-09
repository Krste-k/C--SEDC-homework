using HomeworkClass3.Entities;
using System.ComponentModel.DataAnnotations;

//Create a class Vehicle with properties Id, Type, YearOfProduction, BatchNumber.
//Create two classes Car and Bike that inherit from Vehicle. Car has property FuelTank (int) and Countries in which it is produced and Bike has property Color.
//Class Vehicle has method PrintVehicle that prints Id, Type and YearOfProduction.
//Class Car also has method PrintVehicle that prints the Type and the Countries in which it is produced.
//Class Bike also has method PrintVehicle that Prints the YearOfProduction and the Color.
//Create a static class that serves as a DB, that has list of Vehicles. In this list put objects of type Car, Bike and Vehicle.
//In the main program call PrintVehicle for each object in the list in the db.
//Create a static class called Validator, that contains a method Validate, that receives a Vehicle and validates is Id is not 0, that Type is not empty and YearOfProduction is not 0.
//Call Validate from main Program with a couple of objects.

Car car1 = new Car
{
    Id = 1,
    Type = "Sedan",
    YearsOfProduction = 2021,
    BatchNumber = "001",
    FurlTank = 50,
    Countries = new List<string> { "USA", "Japan" }
};

Bike bike1 = new Bike
{
    Id = 2,
    Type = "Mountain Bike",
    YearsOfProduction = 2020,
    BatchNumber = "002",
    Color = "Blue"
};

Vehicle vehicle1 = new Vehicle
{
    Id = 3,
    Type = "Truck",
    YearsOfProduction = 2019,
    BatchNumber = "003"
};

List<Vehicle> dbList = new List<Vehicle>();
dbList.Add(car1);
dbList.Add(bike1);
dbList.Add(vehicle1);

foreach (Vehicle vehicle in dbList)
{
    vehicle.PrintVehicle();
}


