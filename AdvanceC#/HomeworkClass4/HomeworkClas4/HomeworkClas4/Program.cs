using HomeworkClas4.Entities;

JapaneseCar car1 = new JapaneseCar
{
    Id = 1,
    Brand = "Toyota",
    Model = "Camry",
    MaxSpeed = 120,
    HorsePower = 180,
    FuelType = "Gasoline"
};

GermanCar car2 = new GermanCar
{
    Id = 2,
    Brand = "BMW",
    Model = "X5",
    MaxSpeed = 150,
    HorsePower = 220,
    FuelType = "Diesel"
};

FrenchCar car3 = new FrenchCar
{
    Id = 3,
    Brand = "Peugeot",
    Model = "308",
    MaxSpeed = 140,
    HorsePower = 130,
    FuelType = "Gasoline"
};

GenericDb<Car> carDb = new GenericDb<Car>();


Car carById = carDb.GetById(2);
if (carById != null)
{
    carById.Print();
}


carDb.PrintAll();
