using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Exercise01.Entities
{
    public class Dog : Pet
    {
        public string FavoriteFood { get; set; }

        public Dog (string name, int age, string favouriteFood) : base (name, PetType.Dog, age)
        {
            FavoriteFood = favouriteFood;
        }

        public void GoodBoi()
        {
            Console.WriteLine($"The {Name} is a GoodBoi!");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"The pet of type {PetType.Dog} with name: {Name}, is {Age} years old, and the favourite food is {FavoriteFood}.");
        }
    }
}
