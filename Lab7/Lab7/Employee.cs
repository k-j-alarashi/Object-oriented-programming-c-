namespace Lab9
{
    internal class Employee
    {
        private int id;
        private string name;
        private int age;
        private double salary;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public double Salary { get { return salary; } set { salary = value; } }

        public Employee(int id , string name , int age , double salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public virtual double getSalary()
        {
            return salary;
        }
    }
}
