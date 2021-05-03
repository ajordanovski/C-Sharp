using SEDC.CSharpAdv.Class03.Exercise01.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class03.Exercise01.StaticModels
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; }

        static DogShelter()
        {
            Dogs = new List<Dog>();
        }

        public static void PrintAll()
        {
            foreach(Dog dog in Dogs)
            {
                Console.WriteLine($"Id: {dog.Id} Name: {dog.Name} Color: {dog.Color}");
            }
        }

        public static void AddDog(Dog dog)
        {
            Dogs.Add(dog);
            Console.WriteLine($"The dog {dog.Name} is added in to Dogs Shelter!");
        }
    }
}