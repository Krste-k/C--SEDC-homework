using homeWorkClass2C_A.Entities;
using homeWorkClass2C_A.Entities.Interfaces;


//Create interfaces called IAnimal, IDog, ICat
//IAnimal : Contains method PrintAnimal
//IDog - Contains method Bark
//ICat - Contains method Eat that gets parameter food of type string
//Create an abstract class Animal (you choose the properties) that implements IAnimal, with abstract method PrintAnimal
//Create class Dog that implements IDog and inherits from Animal. Implement PrintAnimal but also Bark.
//Create class Cat that implements ICat and inherits from Animal. Implement PrintAnimal but also Eat.
//Create several objects and test the method calls
//The implementation for the methods is on your choice.


Animal dog1 = new Dog("Sarko", 5);
dog1.PrintAnimal();

Animal cat1 = new Cat("Mace",2);
cat1.PrintAnimal();