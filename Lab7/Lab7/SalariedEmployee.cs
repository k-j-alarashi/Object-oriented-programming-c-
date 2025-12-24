
namespace Lab9
{
    internal class SalariedEmployee : Employee
    {
        private double bouns;
        private double dedection;

        public SalariedEmployee(int id, string name, int age, double salary , double bouns , double dedection) : base(id,name,age,salary)
        {
            this.bouns = bouns;
            this.dedection = dedection;

        }

        public override double getSalary()
        {
            return base.getSalary() + bouns - dedection;
        }
    }
}
