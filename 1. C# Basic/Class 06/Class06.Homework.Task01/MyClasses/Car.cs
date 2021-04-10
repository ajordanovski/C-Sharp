using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.Homework.Task01.MyClasses
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Racer { get; set; }

        public Car()
        {
            
        }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }


        public int CalculateSpeed(Driver Racer)
        {
            return Racer.Skill * Speed;
        }
    }
}
