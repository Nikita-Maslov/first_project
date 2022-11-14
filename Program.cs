using System;

namespace prog1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Account account = new Account(100.65);
            account.add(10);
            account.add(10.10);
            Console.WriteLine(account.getBalance());
            Console.WriteLine("Первый коммит");
        }
    }

    public class Account
    {
        private double balance;

        public Account(double balance)
        {
            this.balance = balance;
        }

        public void add(int money)
        {
            balance = balance + money;
        }

        //добавьте метод для работы с дробными числами
        public void add(double money)
        {
            balance = balance + money;
        }

        public double getBalance()
        {
            return balance;
        }
    }
}        