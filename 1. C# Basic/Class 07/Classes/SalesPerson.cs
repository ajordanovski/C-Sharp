using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{   
    public class SalesPerson : Employee
    {
        //# Exercise 02
        //Create a SalesPerson class that inherits from Employee and has the following properties:
        //▹SuccessSaleRevenue double, private
        //▹The salary is by default 500 and role is default Sales
        //●Create constructor that sets all the properties
        //●Create a method called AddSuccessRevenue that will get a number and set the SuccessSaleRevenue to that value
        //●Override the GetSalary method to return the value of the salary plus bonus that is calculated by the SuccessSaleRevenue.
        //▹If less or equal to 2000 then add 500 bonus
        //▹If larger than 2000 but less or equal than 5000 then add 1000 bonus
        //▹If larger than 5000 add 1500 bonus

        private double SuccessSaleRevenue { get; set; }


        public SalesPerson(string firstName, string lastName) : base(firstName, lastName, Role.Sales, 500)
        {
            //SuccessSaleRevenue = successSaleRevenue;
        }

        public double AddSuccessRevenue()
        {
            double randomSale =  new Random().Next(500, 7000);
            return  SuccessSaleRevenue = randomSale;
        }

        public override double GetSalary()
        {
            double result = 0;

            if (SuccessSaleRevenue <= 2000)
            {
                result = 500;
            }
            if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                result = 1000;
            }
            if (SuccessSaleRevenue > 5000)
            {
                result = 1500;
            }

            return Salary + result;
        }

    }
}
