using System;

namespace Class03.Homework.SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 1
            //Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array:
            //*Test Data:
            //*Enter integer no.1:
            //    *4
            //  * Enter integer no.1:
            //    *3
            //  * Enter integer no.1:
            //    *7
            //  * Enter integer no.1:
            //    *3
            //  * Enter integer no.1:
            //    *2
            //  * Enter integer no.1:
            //    *8
            //* Expected Output:
            //*The result is: 14


            int[] emptyIntArray = new int[6];

            int sumOfEven = 0;

            for(int i = 0; i < emptyIntArray.Length; i++)
            {
                Console.WriteLine("Input number in Array");
                string input = Console.ReadLine();
                bool isValidInput = int.TryParse(input, out int userInput);
                emptyIntArray[i] = userInput;
                //emptyIntArray[i] = int.Parse(Console.ReadLine());
                if (emptyIntArray[i] % 2 == 0)
                {
                    sumOfEven += emptyIntArray[i];
                }
            }

            Console.WriteLine("The sum of the even numbers from the array is " + sumOfEven);

            Console.ReadLine();
        }
    }
}