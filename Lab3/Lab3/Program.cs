namespace OOP
{
    public class Test
    {
        static void Main(string[] args)
        {
            Rectangle b = new Rectangle(5, 10, 20, 30);
            b.display();
            Console.WriteLine("Area = "+b.Area());
            b.x = 100;
            b.display();
        }
    }
}