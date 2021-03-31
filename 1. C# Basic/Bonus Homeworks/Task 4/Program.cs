using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 4:
            //Write a program that will find out the sum of all even numbers in the range 1-N (N is input from keyboard).

            Console.WriteLine("Input any number:");
            string userInput = Console.ReadLine();
            bool isValidNumber = int.TryParse(userInput, out int inputNumber);

            int result = 0;

            for(int i = 0; i <= inputNumber; i++)
            {
                if(i % 2 == 0)
                {
                    result += i;
                }
                continue;
            }

            Console.WriteLine("The sum of all even numbers is " + result);

            Console.ReadLine();
        }
    }
}
