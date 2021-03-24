using System;
using Xunit;

namespace Lab2.Tests
{
    public class TestAddBalance
    {
        [Fact]
        public void Test_Add_Balance()
        {
           BankAccount empty = new("empty","00000-0",AccountType.ContaCorrente);

           empty.AddBalance(100);

           Assert.Equal(100, empty.CurrentBalace());
        }
    }

    public class TestTransference
    {
        [Fact]
        public void Transference_Balance_To_Other_Account()
        {
            BankAccount sander = new("sander","00000-0",AccountType.ContaCorrente, 1000);
            BankAccount recever = new("recever","00000-0",AccountType.ContaCorrente);

            sander.TransfereTo(recever, 100);

            bool result () =>
                sander.CurrentBalace() == 900.1 && recever.CurrentBalace() == 100;

            Assert.True(result());
        }

        [Fact]
        public void Empty_Account_Try_To_Transference()
        {
            BankAccount sander = new("sander","00000-0",AccountType.ContaCorrente);
            BankAccount recever = new("recever","00000-0",AccountType.ContaCorrente);

            var result = sander.TransfereTo(recever, 100);

            Assert.False(result);
        }
    }

    public class WithdrawalTest
    {
        [Fact]
        public void Withdrawal_Some_Balance()
        {
            BankAccount test = new("test", "00000-0", AccountType.ContaPoupanca, 1000);

            test.Withdrawl(500);

            Assert.Equal(500.2, test.CurrentBalace());
        }

        [Fact]
        public void Try_Withdrawl_Empty_Account()
        {
            BankAccount empty = new("empty","00000-0",AccountType.ContaCorrente);

            var result = empty.Withdrawl(100);

            Assert.False(result);
        }
    }
}
