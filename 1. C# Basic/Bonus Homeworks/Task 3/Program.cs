using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 3:
            //Write a program, which will be calculating the product of the digits of an input number.

            Console.WriteLine("Input any number:");
            string userInput = Console.ReadLine();
            bool isValidNumber = int.TryParse(userInput, out int inputNumber);

            int startNumber = 1;

            while(inputNumber != 0)
            {
                startNumber = startNumber * (inputNumber % 10);

                inputNumber = inputNumber / 10;
            }

            Console.WriteLine("Product of the digits is " + startNumber);


            Console.ReadLine();
        }
    }
}
