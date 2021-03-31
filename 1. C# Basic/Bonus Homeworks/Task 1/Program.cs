using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 1: 
            //Write a program that will print out all numbers from the range 1-N (N is input from keyboard, N>2) that divide with 3.

            Console.WriteLine("Input number bigger than 2");
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber > 2)
            {
                for (int i = 1; i <= inputNumber; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please input number bigger than 2");
            }


            Console.ReadLine();
        }
    }
}
