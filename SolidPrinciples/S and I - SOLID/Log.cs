using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.S_and_I__SOLID
{
    public class Log : ILogger
    {
        public bool ErrorLog(string error)
        {
            var status = false;
            if(error != null)
            {
                status = true;
            }
            return status;
        }
    }
}
