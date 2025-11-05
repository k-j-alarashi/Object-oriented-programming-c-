using System;
namespace FirstProject
{
    public class Lab1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your ID : ");
            string id = Console.ReadLine();

            Console.WriteLine("Enter Your NAME : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your AGE : ");
            string age = Console.ReadLine();

            Console.WriteLine("Enter Your MAJOR : ");
            string major = Console.ReadLine();

            if(int.TryParse(id , out int correctId) && int.TryParse(age , out int correctAge))
            {
                Console.WriteLine("=================");
                Console.WriteLine("ID       : "+id);
                Console.WriteLine("NAME     : "+name);
                Console.WriteLine("AGE      : "+age);
                Console.WriteLine("MAJOR    : "+major);
                Console.WriteLine("=================");

                //Formatted String --> another way to print data.
                /*Console.WriteLine("ID       : {0} \nNAME     : {1} \nAGE      : {2} \nMAJOR    : {3}",
                    id , name , age , major);*/
            }
            else
            {
                Console.WriteLine("=================");
                Console.WriteLine("Invaild Input ..!");
                Console.WriteLine("=================");
            }

        }
    }
}