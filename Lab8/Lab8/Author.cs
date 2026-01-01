namespace Lab8
{
    internal class Author
    {
        private string name;
        private string phone;
        private int age;

        public string Name { get { return name; } set { name = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Author(string name , string phone , int age)
        {
            this.name = name;
            this.phone= phone;
            this.age = age;
        }
    }
}
