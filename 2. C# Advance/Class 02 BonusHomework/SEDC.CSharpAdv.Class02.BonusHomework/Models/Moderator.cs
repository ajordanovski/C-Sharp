using SEDC.CSharpAdv.Class02.BonusHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.BonusHomework.Models
{
    public class Moderator : User, IModerator
    {
        public List<User> Users { get; set; }

        public Moderator(string username) : base(username, Role.Moderator)
        {
            Username = username;
            Comments = new List<string>();
        }

        public void BanUser(User user, string reason)
        {
            Console.WriteLine($"The user {user.Username} is banned for {reason}");
        }

        public override void PrintUser()
        {
            Console.WriteLine($"UserName: {Username} and Role: {Role}");
        }
    }
}
