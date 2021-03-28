using System;

namespace Class02.Homework.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 3:
            //Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value.
            //Please find example below:
            //*Test Data:
            //*Input the First Number: 5
            //* Input the Second Number: 8
            //* Expected Output:
            //*After Swapping:
            //*First Number: 8
            //* Second Number: 5

            Console.WriteLine("Inpunt first number and press enter:");
            string firstNumber = Console.ReadLine();
            int num1 = int.Parse(firstNumber);

            Console.WriteLine("Inpunt second number and press enter:");
            string secondNumber = Console.ReadLine();
            int num2 = int.Parse(secondNumber);

            int help = num1;
            num1 = num2;
            num2 = help;


            Console.WriteLine("The value of First number is: " + num1);
            Console.WriteLine("The value of Second number is: " + num2);

            Console.ReadLine();
        }
    }
}


