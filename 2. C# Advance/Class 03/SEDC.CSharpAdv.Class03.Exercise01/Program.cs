using SEDC.CSharpAdv.Class03.Exercise01.Helpers;
using SEDC.CSharpAdv.Class03.Exercise01.Models;
using System;
using SEDC.CSharpAdv.Class03.Exercise01.StaticModels;

namespace SEDC.CSharpAdv.Class03.Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(1, "Rex", "Black");
            Dog dog2 = new Dog(2, "Bruno", "Brown");
            Dog dog3 = new Dog(3, "Linda", "White");
            Dog dog4 = new Dog() { Name = "Dzeki" };
            Dog dog5 = new Dog() { Name = "Murdzo", Color = "Black and Brown"};
            Dog dog6 = new Dog(-1, "Spaky", "White");

            Validate.ValidateHelper(dog1);
            Validate.ValidateHelper(dog2);
            Validate.ValidateHelper(dog3);
            Validate.ValidateHelper(dog4);
            Validate.ValidateHelper(dog5);
            Validate.ValidateHelper(dog6);

            Console.WriteLine("==================================");

            DogShelter.AddDog(dog1);
            DogShelter.AddDog(dog2);
            DogShelter.AddDog(dog3);

            Console.WriteLine("==================================");

            DogShelter.PrintAll();

            Console.ReadLine();
        }
    }
}

//Class 03 - EXERCISE 01
//●Create a class called Dog that has:
//▹Id, Name, Color, Bark() -Prints “Bark Bark”
//▹A static method  Validate() -Checks if dog has all 3 properties, 
//if Id is not less than 0 and Name is 2 characters or longer
//●Create a static class called DogShelter  that has:
//▹List of Dogs
//▹PrintAll() -prints all dogs from List of Dogs
//●Create 3 Dog objects, call validate  on them to see if they are okay, 
//add them in the List of Dogs and call PrintAll()