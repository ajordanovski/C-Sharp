using SEDC.CSharpAdv.Class04.Exercise01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Exercise01.GenericClass
{
    public class PetStore<T>
        where T : Pet
    {
        public List<T> Pets { get; set; }

        public PetStore()
        {
            Pets = new List<T>();
        }

        public void printsPets(List<T> Pets)
        {
            foreach (T item in Pets)
            {
                Console.WriteLine($"The name of the pet is {item.Name}, it is type of {item.Type} and is {item.Age} years old.");
            }
        }

        public void BuyPet(string name)
        {
            string nameToLower = name.ToLower();

            T item = Pets.FirstOrDefault(x => x.Name.ToLower().Equals(nameToLower));

            if (item != null)
            {
                Pets.Remove(item);
                Console.WriteLine($"You just bought a pet with name {item.Name} and it is type of {item.Type}.");
            }
            else 
            {
                Console.WriteLine("Sorry... There is not pet with that name!");
            }

            Console.WriteLine();
        }
    }
}