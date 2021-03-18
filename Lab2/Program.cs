using System;

namespace Lab2
{
    public static class Program
    {
        public static void Main()
        {
            var bobNelson = new BankAccount("Bob Nelson", "12345-6", AccountType.ContaCorrente);
            var testolfoRocha = new BankAccount("Testolfo Rocha", "71717-1", AccountType.ContaPoupanca);
            var lisaLeite = new BankAccount("Lisa Leite", "65432-1", AccountType.ContaCorrente);

            bobNelson.AddBalance(5000);
            lisaLeite.AddBalance(2000);
            testolfoRocha.AddBalance(1500);

            bobNelson.TransfereTo(testolfoRocha, 600);
            lisaLeite.Withdrawl(250);
            lisaLeite.TransfereTo(testolfoRocha,400);

            testolfoRocha.TransfereTo(bobNelson, 1000);
            bobNelson.Withdrawl(900000);
            bobNelson.TransfereTo(lisaLeite, 1500);

            testolfoRocha.TransfereTo(lisaLeite, 1200);
            bobNelson.Withdrawl(2000);
            lisaLeite.AddBalance(100);

            testolfoRocha.TransfereTo(bobNelson, 700);
        }
    }
}