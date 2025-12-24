namespace Lab9
{
    internal class HourlEmployee : Employee
    {
        private int hourNum ;

        public HourlEmployee(int id, string name, int age, double hourRate , int hourNum) : base(id , name, age, hourRate)
        {
            this.hourNum = hourNum;
        }

        public override double getSalary()
        {
            return base.getSalary() * hourNum;
        }
    }
}
