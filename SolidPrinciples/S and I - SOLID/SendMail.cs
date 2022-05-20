using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.S_and_I__SOLID
{
    public class SendMail : ISendEmail
    {
        public bool SendEMail(string mail)
        {
            var status = false;
            if(mail != null)
            {
                status = true;
            }
            return status;
        }
    }
}
