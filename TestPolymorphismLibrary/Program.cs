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

            company.employNewEmployee("juan",1,10);
            company.employNewEmployee("rick", 10);
            company.getMonthlySalaryTotal();

            Console.ReadKey();
        }
    }
}
