namespace Lab5
{
    public class Person
    {
        private int id;
        private string name;
        private int age;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Person(int id , string name , int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return "ID     : "+Id+
                  "\nName   : "+Name+
                  "\nAge    : "+Age;
        }
    }
}
