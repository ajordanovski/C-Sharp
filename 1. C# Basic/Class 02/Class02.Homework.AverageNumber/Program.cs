using System;

namespace Class02.Homework.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 2
            //Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
            //* Test Data:
            //  *Enter the First number: 10
            // * Enter the Second number: 15
            // * Enter the third number: 20
            // * Enter the four number: 30
            //* Expected Output:
            //*The average of 10, 15, 20 and 30 is: 18

            Console.WriteLine("Inpunt first number and press enter:");
            string firstNumber = Console.ReadLine();
            double num1 = int.Parse(firstNumber);

            Console.WriteLine("Inpunt second number and press enter:");
            string secondNumber = Console.ReadLine();
            double num2 = int.Parse(secondNumber);

            Console.WriteLine("Inpunt third number and press enter:");
            string thirdNumber = Console.ReadLine();
            double num3 = int.Parse(thirdNumber);

            Console.WriteLine("Inpunt forth number and press enter:");
            string fourthNumber = Console.ReadLine();
            double num4 = int.Parse(fourthNumber);

            double result = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("The average of " + num1 + ", " + num2 + ", " + num3 + " and " + num4 + " is " + result);

            Console.ReadLine();
        }
    }
}