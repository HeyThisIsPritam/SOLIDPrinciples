using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.O___SOLID
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        {

        }
        public PermanentEmployee(int id,string name): base(id,name)
        {

        }
        public override decimal CalculateBonus(int salary)
        {
            return salary * .1M;
        }
    }
}
