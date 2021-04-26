using SEDC.CSharpAdv.Class02.BonusHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.BonusHomework.Models
{
    public class Guest : User, IGuest
    {
        public int Id { get; set; }

        public Guest(string username, int id) : base(username, Role.Guest)
        {
            Username = username;
            Comments = new List<string>();
            Id = id;
        }

        public override void PrintUser()
        {
            Console.WriteLine($"UserName: {Username} and Role: {Role}");
        }

        public void ReadComment(string comment)
        {
            Console.WriteLine($"The {Username} with Id: {Id} read this comment: {comment}");
        }
    }
}
