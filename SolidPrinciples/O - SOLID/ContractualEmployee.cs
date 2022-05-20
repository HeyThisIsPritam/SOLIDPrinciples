using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.O___SOLID
{
    public class ContractualEmployee : Employee
    {
        public ContractualEmployee()
        {

        }
        public ContractualEmployee(int id, string name) : base(id, name)
        {

        }
        public override decimal CalculateBonus(int salary)
        {
            return salary * .05M;
        }
    }
}
