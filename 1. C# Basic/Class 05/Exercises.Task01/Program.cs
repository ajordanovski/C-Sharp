using System;

namespace Exerccises.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 1:
            //Write a function that will give stats about an integer number.
            //The function should write the stats in console. The stats required are:

            //*Whats the value of the number 
            //* How many digits the number has 
            //* Is the number odd or even 
            //* Is the number positive 

            //I.e. if the user enters the number 25, the response should be 
            //```sh
            //The number 25 is a 2 digit number, it's odd and it's a positive number.
            //```

            Console.WriteLine("Input a number:");
            string userInput = Console.ReadLine();
            bool isValidNumber = int.TryParse(userInput, out int inputNumber);

            int digits = CountDigits(userInput);
            string oddEven = OddOrEven(inputNumber);
            string positiveNegative = PositiveOrNegative(inputNumber);

            Console.WriteLine($"The number {inputNumber} is a {digits} digit number, it's a {oddEven} and it's a {positiveNegative} number");

            Console.ReadLine();
        }

        static int CountDigits(string num)
        {
            return num.Length;
        }

        static string OddOrEven(int num)
        {
            if (num % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }

        static string PositiveOrNegative(int num)
        {
            if (num >= 0)
            {
                return "positive";
            }
            else
            {
                return "negative";
            }
        }
    }
}