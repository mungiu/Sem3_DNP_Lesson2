namespace PolymorphismLybrary
{
    internal abstract class Employee :IStudent
    {
        public string name;

        public Employee(string name)
        {
            this.name = name;
        }

        public abstract double GetMonthlySalary();
    }
}