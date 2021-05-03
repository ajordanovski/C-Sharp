using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Exercise01.Entities
{
    public class Cat : Pet
    {
        public int LivesLeft { get; set; }

        public Cat (string name, int age, int livesLeft) : base(name, PetType.Cat, age)
        {
            LivesLeft = livesLeft;
        }

        public void Lazy()
        {
            Console.WriteLine($"The cats are very Lazy, also cat '{Name}' is Lazy! Maybe that is the key to have 9 lives :)");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"The pet of type {PetType.Cat} with name: {Name}, is {Age} years old, have {LivesLeft} lives left.");
        }
    }
}
