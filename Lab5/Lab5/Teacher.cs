namespace Lab5
{
    public class Teacher : Person
    {
        private double salary;

        public double Salary { get { return salary; } set { salary = value; } }

        public Teacher(int id , string name , int age , double salary) : base(id,name,age)
        {
            this.salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nSalary : " + Salary;
        }

    }
}
