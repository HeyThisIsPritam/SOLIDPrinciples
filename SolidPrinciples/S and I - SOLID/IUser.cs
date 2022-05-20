using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.S_and_I__SOLID
{
    public interface IUser
    {
        bool Login(string userId, string password);
        bool Registration(string name, string email, string password);
    }
    // This Interface is only responsible only for creating Login/Registration.
    
}
