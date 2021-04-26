using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.BonusHomework.Interfaces
{
    public interface IGuest
    {
        int Id { get; set; }
        void ReadComment(string comment);
    }
}
