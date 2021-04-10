using Class06.Homework.Task01.MyClasses;
using System;
using System.Collections.Generic;

namespace Class06.Homework.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver racer1 = new Driver("Bob", 8);
            Driver racer2 = new Driver("Greg", 7);
            Driver racer3 = new Driver("Jill", 6);
            Driver racer4 = new Driver("Anne", 5);

            Car car1 = new Car("Hyundai", 15);
            Car car2 = new Car("Mazda", 20);
            Car car3 = new Car("Ferrari", 35);
            Car car4 = new Car("Porsche", 30);

            Car carPick1 = new Car();
            Driver racerPick1 = new Driver();
            Car carPick2 = new Car();
            Driver racerPick2 = new Driver();

            while (true)
            {
                
                Console.WriteLine("Choose a Car no.1: \n1. Hyundai \n2. Mazda \n3. Ferrari \n4. Porsche");
                int.TryParse(Console.ReadLine(), out int carNo1);
                if (carNo1 > 4 || carNo1 < 1)
                {
                    Console.WriteLine("Wrong pick... Please pick 1, 2, 3 or 4");
                    continue;
                }

                if (carNo1 == 1)
                {
                    carPick1 = car1;
                }
                if (carNo1 == 2)
                {
                    carPick1 = car2;
                }
                if (carNo1 == 3)
                {
                    carPick1 = car3;
                }
                if (carNo1 == 4)
                {
                    carPick1 = car4;
                }


                Console.WriteLine("Choose Driver: \n1. Bob \n2. Greg \n3. Jill \n4. Anne");
                int.TryParse(Console.ReadLine(), out int racerNo1);
                if (racerNo1 > 4 || racerNo1 < 1)
                {
                    Console.WriteLine("Wrong pick... Please pick 1, 2, 3 or 4");
                    continue;
                }

                if (racerNo1 == 1)
                {
                    racerPick1 = racer1;
                }
                if (racerNo1 == 2)
                {
                    racerPick1 = racer2;
                }
                if (racerNo1 == 3)
                {
                    racerPick1 = racer3;
                }
                if (racerNo1 == 4)
                {
                    racerPick1 = racer4;
                }

                Console.WriteLine("Choose a Car no.2: \n1. Hyundai \n2. Mazda \n3. Ferrari \n4. Porsche");
                int.TryParse(Console.ReadLine(), out int carNo2);
                if (carNo2 > 4 || carNo2 < 1)
                {
                    Console.WriteLine("Wrong pick... Please pick 1, 2, 3 or 4");
                    continue;
                }

                if (carNo2 == 1)
                {
                    carPick2 = car1;
                }
                if (carNo2 == 2)
                {
                    carPick2 = car2;
                }
                if (carNo2 == 3)
                {
                    carPick2 = car3;
                }
                if (carNo2 == 4)
                {
                    carPick2 = car4;
                }

                Console.WriteLine("Choose Driver: \n1. Bob \n2. Greg \n3. Jill \n4. Anne");
                int.TryParse(Console.ReadLine(), out int racerNo2);
                if (racerNo2 > 4 || racerNo2 < 1)
                {
                    Console.WriteLine("Wrong pick... Please pick 1, 2, 3 or 4");
                    continue;
                }

                if (racerNo2 == 1)
                {
                    racerPick2 = racer1;
                }
                if (racerNo2 == 2)
                {
                    racerPick2 = racer2;
                }
                if (racerNo2 == 3)
                {
                    racerPick2 = racer3;
                }
                if (racerNo2 == 4)
                {
                    racerPick2 = racer4;
                }

                RaceCars(carPick1, carPick2, racerPick1, racerPick2);

                Console.WriteLine("Do you wanna another race? \n Y or N");
                string answer = Console.ReadLine().ToLower();
                if (answer == "n")
                {
                    break;
                }

                Console.Clear();
                continue;
            }

            Console.ReadLine();
        }

        public static void RaceCars(Car no1, Car no2, Driver d1, Driver d2)
        {
            no1.Racer = d1;
            no2.Racer = d2;

            if( no1.CalculateSpeed(no1.Racer) > no2.CalculateSpeed(no2.Racer))
            {
                Console.WriteLine($"The winner is driver {no1.Racer.Name} with car {no1.Model} the speed was {no1.CalculateSpeed(no1.Racer)}");
            } 
            else if (no1.CalculateSpeed(no1.Racer) < no2.CalculateSpeed(no2.Racer))
            {
                Console.WriteLine($"The winner is driver {no2.Racer.Name} with car {no2.Model} the speed was {no2.CalculateSpeed(no2.Racer)}");
            }
            else
            {
                Console.WriteLine($"They both share first place because they were moving at the same speed.");
            }
        }
    }
}
