using Classes;
using System;

namespace SEDC.CSharpOop.Class07.Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            //# Exercise 01
            Employee otherEmploy = new Employee("Petko", "Petkovski", Role.Other, 400);
            otherEmploy.PrintInfo();


            //# Exercise 02
            SalesPerson saleEmploy = new SalesPerson("Brzi", "Besni");
            saleEmploy.AddSuccessRevenue();
            saleEmploy.PrintInfo();


            //# Exercise 03
            Manager managerEmploy = new Manager("Goce", "Shefot", 2000);
            managerEmploy.AddBonus(350);
            managerEmploy.PrintInfo();


            Console.ReadLine();
        }
    }
}