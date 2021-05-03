using SEDC.CSharpAdv.Class03.Exercise01.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class03.Exercise01.Helpers
{
    public static class Validate
    {
        public static void ValidateHelper(Dog dog)
        {
            if (dog.Id != 0 && dog.Name != string.Empty && dog.Color != string.Empty)
            {
                if (dog.Id >= 0 && dog.Name.Length > 2)
                {
                    Console.WriteLine("The dog has all parameters!");
                }
                else
                {
                    Console.WriteLine("The dog Id or Name is not valid!");
                }
            }
            else 
            {
                Console.WriteLine("The dog miss some parameters!");
            }
        }
    }
}
