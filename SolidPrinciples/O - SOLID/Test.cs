using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.O___SOLID
{
    public class Test
    {
        static void Main()
        {
            PermanentEmployee emp1 = new PermanentEmployee(1107652,"Pritam");
            Console.WriteLine("ID : {0}  Name : {1}  Bonus : {2}", emp1.Id, emp1.empName,emp1.CalculateBonus(403000));

            ContractualEmployee emp2 = new ContractualEmployee(1107699, "Rony");
            Console.WriteLine("ID : {0}  Name : {1}  Bonus : {2}", emp2.Id, emp2.empName, emp2.CalculateBonus(148000));

            Console.Read();
        }
    }
}
