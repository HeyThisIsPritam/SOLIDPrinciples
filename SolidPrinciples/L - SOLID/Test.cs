using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.L___SOLID
{
    public class Test
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1107652, "Pritam"));
            employees.Add(new ContractualEmployee(1107699, "Rony"));
            foreach (var emp in employees)
            {
                Console.WriteLine("ID : {0} \n  Name : {1} \n  Min Salary : {2} \n   Bonus : {3} \n ", emp.Id, emp.empName,emp.GetMinSalary(), emp.CalculateBonus(403000));
                Console.WriteLine("\n----------------------------\n");
            }

            Console.WriteLine("\n--------------------------------------\n");
            List<IEmployee> intern = new List<IEmployee>();
            intern.Add(new Intern(1234, "Pritam-Intern"));
            intern.Add(new Intern(4321, "Rony-Intern"));
            foreach (var emp in intern)
            {
                Console.WriteLine("ID : {0} \n  Name : {1} \n  Min Salary : {2} \n", emp.Id, emp.empName, emp.GetMinSalary());
                Console.WriteLine("\n----------------------------\n");
            }

            Console.Read();
        }
    }
}
