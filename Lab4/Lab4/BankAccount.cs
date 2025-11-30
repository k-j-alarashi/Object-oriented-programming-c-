
namespace Lab4
{
    public class BankAccount
    {
        private int accountId;
        private string accountName;
        private double amount;

        public int AccountId { get { return accountId; } set { accountId = value; } }

        public string AccountName { get { return accountName;} set { accountName = value; } }

        public double Amount { get { return amount; } }

        // overloading - first constructor
        public BankAccount(int accountId, string accountName)
        {
            this.accountId = accountId;
            this.accountName = accountName;
            this.amount = 0.0;
        }
        
        // overloading - second constructor
        public BankAccount(int accountId , string accountName , double amount)
        {
            this.accountId = accountId;
            this.accountName = accountName;
            this.amount = amount;
        }

        public void deposite(double amount)
        {
            this.amount = this.amount + amount;
            Console.WriteLine("Deposite Amount : "+amount);
            Console.WriteLine("Total    Amount : "+this.amount);
        }

        public void withdraw(double amount)
        {
            if(amount > 0 && amount <= this.amount)
            {
                this.amount = this.amount - amount;
                Console.WriteLine("Withdraw Amount : " + amount);
                Console.WriteLine("Total    Amount : " + this.amount);
            }
            else
            {
                Console.WriteLine("Sorry , You don't have enough CASH ...!");
            }
        }

        public void displayDetails()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("ID       : "+AccountId);
            Console.WriteLine("NAME     : "+AccountName);
            Console.WriteLine("AMOUNT   : "+Amount);
            Console.WriteLine("=============================");
        }
    }
}
