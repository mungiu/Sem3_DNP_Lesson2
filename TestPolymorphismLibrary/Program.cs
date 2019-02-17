using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolymorphismLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            PolymorphismLybrary.Company company = new PolymorphismLybrary.Company();

            company.EmployNewEmployee("juan",1,10);
            company.EmployNewEmployee("rick", 10);
            company.EmployPartTimeStudent("andrei", 43, 122, 2018);
            company.GetMonthlySalaryTotal();

            Console.ReadKey();
        }
    }
}
