using SEDC.CSharpAdv.Class04.Exercise01.Entities;
using System;

namespace SEDC.CSharpAdv.Class04.Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.ReadLine();
        }
    }
}

//Class 04 - EXERCISE 01
//▸Create 4 classes:
//▹Pet( abstract ) with Name, Type, Age and abstract PrintInfo()
//▹Dog( from Pet ) with GoodBoiand FavoriteFood
//▹Cat( from Pet ) with Lazy and LivesLeft
//▹Fish( from Pet ) with color, size
//▸Create a PetStoregeneric class with:
//▹Generic list of pets -Dogs, Cats or Fish depending on what is passed as T
//▹Generic method printsPets() -Prints Dogs, Cats or Fish depending on what is passed as T
//▹BuyPet() -Method that takes ‘name’ as parameter, find the first pet by that name, removes it from the list and gives a success  message.
//If there is no pet by that name, inform the customer
//▸Create a Dog, Cat and fish store with 2 pets each
//▹Buy a dog and a cat from the Dog and Cat store
//▹Call PrintPets() method on all stores
