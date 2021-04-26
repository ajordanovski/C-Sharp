using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.BonusHomework.Interfaces
{
    public interface IUser
    {
        string Username { get; set; }
        Role Role { get; set; }
        List<string> Comments { get; set; }


        void PostComment(string comment);
        void PrintUser();

    }
}
