using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismLybrary
{
    class FullTimeEmployee : Employee
    {
        public double monthlySalary;
        public FullTimeEmployee (double monthlySalary, string name) : base(name)
        {
            this.monthlySalary = monthlySalary;
        }

        public override double GetMonthlySalary()
        {
            return monthlySalary;
        }
    }
}
