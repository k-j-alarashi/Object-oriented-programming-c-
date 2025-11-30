namespace Lab4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Counter c = new Counter();
            //Console.WriteLine("Count : "+c.Count);
            //c.increment();
            //Console.WriteLine("Count : "+c.Count);
            //c.increment();
            //Console.WriteLine("Count : "+c.Count);
            //c.increment();
            //Console.WriteLine("Count : "+c.Count);
            //c.reset();
            //Console.WriteLine("Count : "+c.Count);


            BankAccount account = new BankAccount(20384, "Khaled", 10000);
            Console.WriteLine("amount : "+account.Amount);
            Console.WriteLine("===========================");
            account.deposite(2000);
            Console.WriteLine("===========================");
            account.withdraw(80000);
            Console.WriteLine("===========================");
        }
    }
}