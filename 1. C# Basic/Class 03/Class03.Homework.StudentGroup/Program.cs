using System;

namespace Class03.Homework.StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 2
            //*Make a new console application called StudentGroup
            //* Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names. 
            //* Get a number from the console between 1 and 2 and print the students from that group in the console.
            //* Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
            //* Test Data:
            //*Enter student group: (there are 1 and 2 )
            //    *1
            //* Expected Output:
            //*The Students in G1 are: 
            //  *Zdravko
            //  * Petko
            //  * Stanko
            //  * Branko
            //  * Trajko

            string[] studentsG1 = { "Hobbit", "Elf", "Dwarf", "Ork", "Smigol" };
            string[] studentsG2 = { "Jack", "Neo", "Optimus", "Joker", "Ironman" };

            Console.WriteLine("input number 1 (students from group 1) or number 2 (students from group 2)");
            int input = int.Parse(Console.ReadLine());
            
            switch(input)
            {
                case 1:
                    for (int i = 0; i < studentsG1.Length; i++)
                    {
                        Console.WriteLine(studentsG1[i]);
                    };
                    break;
                case 2:
                    for (int i = 0; i < studentsG2.Length; i++)
                    {
                        Console.WriteLine(studentsG2[i]);
                    };
                    break;
                default:
                    Console.WriteLine("invalid number: input 1 or 2");
                    break;
            }

            Console.ReadLine();
        }
    }
}
