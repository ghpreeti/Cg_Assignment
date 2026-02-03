using NUnit.Framework;

using System;
using NUnit_Banking;

namespace TestingBank
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDepositValidAmount()
        {
            Program account = new Program(100);
            account.Deposit(50);

            Assert.That(account.Balance,Is.EqualTo(150));
        }

        [Test]
        public void TestDepositNegativeAmount()
        {
            Program account = new Program(100);

            Exception ex = Assert.Throws<Exception>(() => account.Deposit(-20));
            Assert.That(ex.Message, Is.EqualTo("Deposit amount cannot be negative"));

        }

        [Test]

        public void TestWithdrawValidAmount()
        {
            Program account = new Program(200);
            account.Withdraw(50);

            Assert.That(account.Balance,Is.EqualTo(150));
        }

        [Test]
        public void TestWithdrawInsufficientFunds()
        {
            Program account = new Program(100);

            Exception ex = Assert.Throws<Exception>(() => account.Withdraw(200));
            Assert.That(ex.Message, Is.EqualTo("Insufficient funds."));
        }
    }
}
