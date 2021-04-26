using SEDC.CSharpAdv.Class02.BonusHomework.Models;
using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class02.BonusHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Poster poster = new Poster("John", 10);
            Guest guest = new Guest("Smith", 321);
            Moderator moderator = new Moderator("Admin");

            poster.PostComment("comment 1");
            poster.PostComment("comment 2");
            poster.PostComment("comment 3");

            poster.PrintUser();
            poster.CheckStats();
            Console.WriteLine("=============================================");

            guest.PrintUser();
            guest.ReadComment("The comment from guest");
            Console.WriteLine("=============================================");

            moderator.PrintUser();
            moderator.BanUser(poster, "Too many comments!");


            /*moderator.Users = new List<User>();
            Console.WriteLine($"{moderator.Users.Count}");
            moderator.Users.Add(guest);
            Console.WriteLine($"{moderator.Users.Count}");*/

            Console.ReadLine();
        }
    }
}
