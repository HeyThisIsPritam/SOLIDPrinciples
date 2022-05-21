using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.D___SOLID
{
    public class DataAccessLayer : IRepository // DataAccessLAyer is a lower level module
    {
        public void save(Object details)
        {
            // Some code for saving.
        }
    }
}
