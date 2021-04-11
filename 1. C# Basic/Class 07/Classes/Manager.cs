using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Manager : Employee
    {
        //# Exercise 03
        //Add class Manager that inherits from Employee and has a new property called Bonus - double, private
        //●Create a constructor that sets all properties except Bonus
        //●Create a method called AddBonus that adds bonus to the Bonus property
        //●Override the method GetSalary to return the Salary + Bonus

        private double Bonus { get; set; }

        public Manager(string firstName, string lastName, double salary) : base(firstName, lastName, Role.Manager, salary)
        {
        }

        public double AddBonus(double bonusInput)
        {
            return Bonus = bonusInput;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
