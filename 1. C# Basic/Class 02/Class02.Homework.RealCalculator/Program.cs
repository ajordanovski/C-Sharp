using System;

namespace Class02.Homework.RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 1
            //Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.
            //* Test Data:
            //  *Enter the First number: 10
            // * Enter the Second number: 15
            // * Enter the Operation: +
            //*Expected Output:
            //*The result is: 25


            Console.WriteLine("Inpunt first number and press enter:");
            string firstNumber = Console.ReadLine();
            bool isValidFirstNumber = int.TryParse(firstNumber, out int num1);
            Console.WriteLine("Input second number and press enter:");
            string secondNumber = Console.ReadLine();
            bool isValidSecondNumber = int.TryParse(secondNumber, out int num2);
            Console.WriteLine("Input Operation ( +, - , * , / ) and press enter:");
            string operation = Console.ReadLine();


            if((isValidFirstNumber && isValidSecondNumber) && (operation == "+" || operation == "-" || operation == "*" || operation == "/"))
            {
                if (operation == "+")
                {
                    int result = num1 + num2;
                    Console.WriteLine("The result of " + num1 + " and " + num2 + " is " + result);
                }
                if (operation == "-")
                {
                    int result = num1 - num2;
                    Console.WriteLine("The result of " + num1 + " and " + num2 + " is " + result);
                }
                if (operation == "*")
                {
                    int result = num1 * num2;
                    Console.WriteLine("The result of " + num1 + " and " + num2 + " is " + result);
                }
                if (operation == "/")
                {
                    int result = num1 / num2;
                    Console.WriteLine("The result of " + num1 + " and " + num2 + " is " + result);
                }
            }
            else
            {
                Console.WriteLine("invalid operation");
            }

            Console.ReadLine();
        }
    }
}