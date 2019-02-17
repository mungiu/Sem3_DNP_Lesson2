using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismLybrary 
{
    class PartTimeEmployee : Employee
    {
        public int hoursPerMonth;
        public double hourlyWage;
        public PartTimeEmployee(string name, int hoursPerMonth, double hourlyWage) : base(name)
        {
            this.hoursPerMonth = hoursPerMonth;
            this.hourlyWage = hourlyWage;
        }

        public override double GetMonthlySalary()
        {
            return hourlyWage * hoursPerMonth;
        }
    }
}
