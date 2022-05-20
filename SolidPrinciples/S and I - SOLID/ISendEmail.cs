using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.S_and_I__SOLID
{
    public interface ISendEmail
    {
        bool SendEMail(string mail);
    }
    // This Interface is only responsible only for sending Email.
}
