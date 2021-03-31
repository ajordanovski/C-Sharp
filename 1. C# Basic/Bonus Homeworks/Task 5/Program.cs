using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 5:
            //Write a program that will find out the sum of all odd numbers in the range 1-N (N is input from keyboard).

            Console.WriteLine("Input any number:");
            int userInput = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i <= userInput; i++)
            {
                if (i % 2 != 0)
                {
                    result += i;
                }
                continue;
            }

            Console.WriteLine("The sum of all odd numbers is " + result);



            Console.ReadLine();
        }
    }
}