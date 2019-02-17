using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismLybrary
{
    class PartTimeStudent : PartTimeEmployee, IStudent
    {
        int year;

        public PartTimeStudent(string name, int hoursPerMonth, double hourlyWage, int year) : base(name, hoursPerMonth, hourlyWage)
        {
            Register(year);
        }

        public void Register(int year) { this.year = year; }
    }
}
