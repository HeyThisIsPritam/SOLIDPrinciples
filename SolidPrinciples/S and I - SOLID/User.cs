using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.S_and_I__SOLID
{
    public class User:IUser
    {
        public bool Login(string userID,string pass)
        {
            bool status = false;
            if(userID != null && pass != null)
            {
                status = true;
                return status;
            }
            else
            {
                return status;
            }
                
        }

        public bool Registration(string name, string email, string password)
        {
            bool status = false;
            if (name != null && email != null && password != null)
            {
                status = true;
                return status;
            }
            else
            {
                return status;
            }

        }




    }
}
