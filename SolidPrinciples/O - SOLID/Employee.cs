using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.O___SOLID
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string empName { get; set; }

        public Employee()
        {

        }
        public Employee(int id,string name)
        {
            this.Id = id;
            this.empName = name;
        }
        public abstract decimal CalculateBonus(int salary);

    }
}
