using Lab9;
using System.Collections;

namespace lab9
{
    public class Program
    {
        static void Main(string[] args)
        {
            SalariedEmployee s = new SalariedEmployee(1,"mohammed",33,100000,20000,5000);
            //Console.WriteLine("Salaried Emp : "+s.getSalary());
            //Console.WriteLine("=============================");
            HourlEmployee h = new HourlEmployee(2,"Ahmed",22,100,10);
            //Console.WriteLine("Hourly Emp : " + h.getSalary());

            ArrayList a = new ArrayList();
            a.Add(s);
            a.Add(h);

            //for (int i = 0; i < a.Count; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            foreach (SalariedEmployee element in a){
                Console.WriteLine(element.getSalary());
            }
        }
    }
}