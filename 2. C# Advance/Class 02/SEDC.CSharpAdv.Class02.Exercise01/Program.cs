using SEDC.CSharpAdv.Class02.Exercise01.Models;
using System;

namespace SEDC.CSharpAdv.Class02.Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "Trpe", "trpe25", "asd123", 10);
            Student student2 = new Student(2, "Petko", "pepo25", "asd123", 7);
            Teacher teacher1 = new Teacher(3, "Tyson", "tyson32", "asd123", "JavaScript");
            Teacher teacher2 = new Teacher(4, "Joshua", "joshua33", "asd123", "C#");
            student1.PrintUser();
            student2.PrintUser();
            teacher1.PrintUser();
            teacher2.PrintUser();


            Console.ReadLine();
        }
    }
}

//Class 02 - EXERCISE 01
//●Create an interfaces  called IUser, IStudent,  ITeacher
//▹IUser : Id, Name, Username, Password, PrintUser() -Prints Id, Name and Username
//▹IStudent:  Grades, override PrintUser()  to show grades
//▹ITeacher : Subject, override PrintUser()  to show subject
//●Create an abstract  class User and inherits from IUser
//●Create a class Student  that inherits from User and IStudent
//●Create a class Teacher  that inherits from User and ITeacher
//●Create 2 teacher and 2 student  objects and call PrintUser() on all of them