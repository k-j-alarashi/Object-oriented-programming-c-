using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Student
    {
        public int id ;
        public string name;
        public int age;
        public const string major = "IS";
        public static int count = 1;

        public Student(string name , int age)
        {
            id = count;
            this.name = name;
            this.age = age;
            count++;
        }

        public void display()
        {
            
            Console.WriteLine("ID        : "+id);
            Console.WriteLine("NAME      : "+name);
            Console.WriteLine("AGE       : "+age);
            Console.WriteLine("MAJOR     : "+major);
            Console.WriteLine("==================");
        }

        public static void print()
        {
            for (int row = 1; row <=4; row++)
            {
                for (int col = 1; col <=row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
