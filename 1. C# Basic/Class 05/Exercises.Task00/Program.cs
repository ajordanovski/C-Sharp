using System;

namespace Exercises.Task00
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 0:
            //Create a function that calculates the result of raising an integer to another integer (eg 5 raised to 3 = 5^3 = 5 × 5 × 5 = 125).

            Console.WriteLine("Input a number:");
            string userInput = Console.ReadLine();
            bool isValidNumber = int.TryParse(userInput, out int inputNumber);

            Console.WriteLine("Input how many times to multiply inputed number:");
            string userInput2 = Console.ReadLine();
            bool isValidNumber2 = int.TryParse(userInput2, out int inputNumber2);

            int calculate = Raising(inputNumber, inputNumber2);

            Console.WriteLine($"The result is {calculate}");

            Console.ReadLine();
        }

        static int Raising(int num1, int num2)
        {
            int result = 1;
            for(int i = 1; i <= num2; i++)
            {
                result = result * num1;
            }
            return result;
        }

    }
}
