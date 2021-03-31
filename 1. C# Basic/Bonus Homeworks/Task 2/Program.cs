using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 2:
            //Write a program that will print out all numbers in the range 1-N (N is input from keyboard, N>5) that divide 2 and 3.

            Console.WriteLine("Input number bigger than 5");
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber > 2)
            {
                for (int i = 1; i <= inputNumber; i++)
                {
                    if (i % 2 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please input number bigger than 5");
            }

            Console.ReadLine();
        }
    }
}
