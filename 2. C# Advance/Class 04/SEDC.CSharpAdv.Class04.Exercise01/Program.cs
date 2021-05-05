using SEDC.CSharpAdv.Class04.Exercise01.Entities;
using SEDC.CSharpAdv.Class04.Exercise01.GenericClass;
using System;

namespace SEDC.CSharpAdv.Class04.Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            PetStore<Dog> DogStore = new PetStore<Dog>();
            PetStore<Cat> CatStore = new PetStore<Cat>();
            PetStore<Fish> FishStore = new PetStore<Fish>();

            Dog dog1 = new Dog("Dzeki", 2, "bacon");
            Dog dog2 = new Dog("Shpic", 3, "bone");
            Cat cat1 = new Cat("Tom", 1, 9);
            Cat cat2 = new Cat("Mico", 2, 9);
            Fish fish1 = new Fish("Nemo", 1, "golden", 2);
            Fish fish2 = new Fish("Sharki", 4, "gray", 10);

            DogStore.Pets.Add(dog1);
            DogStore.Pets.Add(dog2);
            CatStore.Pets.Add(cat1);
            CatStore.Pets.Add(cat2);
            FishStore.Pets.Add(fish1);
            FishStore.Pets.Add(fish2);

            DogStore.printsPets(DogStore.Pets);
            CatStore.printsPets(CatStore.Pets);
            FishStore.printsPets(FishStore.Pets);

            Console.WriteLine("===============================");

            Console.WriteLine("Say the name of the dog you want to buy from the dog shop: ");
            DogStore.BuyPet(Console.ReadLine());
            Console.WriteLine("Say the name of the cat you want to buy from the cat shop: ");
            CatStore.BuyPet(Console.ReadLine());

            DogStore.printsPets(DogStore.Pets);
            CatStore.printsPets(CatStore.Pets);
            FishStore.printsPets(FishStore.Pets);

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
