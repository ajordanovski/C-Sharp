using SEDC.CSharpAdv.Class02.BonusHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.BonusHomework.Models
{
    public class Poster : User, IPoster
    {
        public int Points { get; set; }
        public bool IsPosterOfTheWeek { get; set; }

        public Poster(string username, int points) : base (username, Role.Poster)
        {
            Username = username;
            Comments = new List<string>();
            Points = points;
        }

        public void CheckStats()
        {
            Console.WriteLine($"Number of points: {Points} and number of comments are {Comments.Count}");
        }

        public override void PrintUser()
        {
            Console.WriteLine($"UserName: {Username} and Role: {Role}"); 
        }
    }
}
