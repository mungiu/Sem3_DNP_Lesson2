using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismLybrary
{
    public class Company
    {
        double totalSalary;
        List<Employee> employeeList = new List<Employee>();

        public void GetMonthlySalaryTotal()
        {
            foreach (Employee employee in employeeList)
                totalSalary += employee.GetMonthlySalary();

            Console.WriteLine(totalSalary);
        }

        public void EmployNewEmployee(string name, double monthlySalary)
        {
            employeeList.Add(new FullTimeEmployee(monthlySalary, name));
        }

        public void EmployNewEmployee(string name, int hoursPerMonth, double hourlyWage)
        {
            employeeList.Add(new PartTimeEmployee(name, hoursPerMonth, hourlyWage));
        }

        public void EmployPartTimeStudent(string name, int hoursPerMonth, double hourlyWage, int year)
        {
            employeeList.Add(new PartTimeStudent(name, hoursPerMonth, hourlyWage, year));
        }
    }
}
