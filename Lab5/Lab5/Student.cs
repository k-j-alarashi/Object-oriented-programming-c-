namespace Lab5
{
    internal class Student : Person
    {
        private int id;
        private string name;
        private int age;
        private string major;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Major { get { return major; } set { major = value; } }

        
        public Student(int id , string name , int age , string major) : base(id,name,age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.major = major;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nMajor  : " + Major;
        }

    }
}
