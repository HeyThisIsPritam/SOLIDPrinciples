using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.L___SOLID
{
    public class Intern : IEmployee
    {
        public int Id { get; set; }
        public string empName { get; set; }
        public Intern()
        {

        }
        public Intern(int id,string name)
        {
            this.Id = id;
            this.empName = name;
        }

        public decimal GetMinSalary()
        {
            return 3000;
        }
    }
}
