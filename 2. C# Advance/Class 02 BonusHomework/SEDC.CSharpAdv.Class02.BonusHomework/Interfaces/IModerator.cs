using SEDC.CSharpAdv.Class02.BonusHomework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.BonusHomework.Interfaces
{
    public interface IModerator
    {
        public List<User> Users { get; set; }
        void BanUser(User user, string reason);
    }
}
