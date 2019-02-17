using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismLybrary 
{
    class PartTimeStudent : PartTimeEmployee, IStudent
    {
        public PartTimeStudent(string name, int hoursPerMonth, double hourlyWage) : base(name, hoursPerMonth, hourlyWage)
        {

        }

        public
    }
}
