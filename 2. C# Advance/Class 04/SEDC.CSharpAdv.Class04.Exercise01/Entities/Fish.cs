using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Exercise01.Entities
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public Fish(string name, int age, string color, int size) : base (name, PetType.Fish, age)
        {
            Color = color;
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"The pet of type {PetType.Fish} with name: {Name}, is {Age} years old, have {Color} colora and it {Size}cm big.");
        }
    }
}
