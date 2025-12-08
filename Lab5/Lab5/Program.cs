namespace Lab5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(203,"khaled",24,"IS");
            Console.WriteLine("Student  ");
            Console.WriteLine(s.ToString());
            Console.WriteLine("=========================");
            Teacher t = new Teacher(1, "Ahmed", 30, 200000);
            Console.WriteLine("Teacher  ");
            Console.WriteLine(t.ToString());
        }
    }
}