using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Exercise01.Entities
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public PetType Type { get; }
        public int Age { get; set; }

        public Pet(string name, PetType type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }

        public abstract void PrintInfo();
    }
}
