public class Rectangle
{
    // fields
    public int x;
    public int y;
    public double width;
    public double height;

    // constructor
    public Rectangle(int x , int y , double width , double height)
    {
        this.x = x;
        this.y = y;
        this.width =  width;
        this.height = height;
    }

    //methods
    public double Area()
    {
        return width * height;
    }

    public void display()
    {
        Console.WriteLine("============");
        Console.WriteLine("x        = "+x);
        Console.WriteLine("y        = "+y);
        Console.WriteLine("width    = "+width);
        Console.WriteLine("height   = "+height);
        Console.WriteLine("============");
    }
}