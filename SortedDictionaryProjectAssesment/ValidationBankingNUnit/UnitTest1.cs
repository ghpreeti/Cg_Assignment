using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace ValidationBankingNUnit
{
    [TestFixture]   // 1) Test attribute for class
    public class UnitTest
    {
        [Test]   // 2) Test attribute for method
        public void Test_Deposit_ValidAmount()
        {
            // Arrange
            Program account = new Program(1000m);

            // Act
            account.Deposit(500m);
            decimal actual = account.Balance;

            // Assert
            Assert.That(actual,Is.EqualTo(1500m));
        }

        [Test]
        public void Test_Deposit_NegativeAmount()
        {
            // Arrange
            Program account = new Program(1000m);

            // Act + Assert
            Assert.Throws<Exception>(() => account.Deposit(-100m));
        }

        [Test]
        public void Test_Withdraw_ValidAmount()
        {
            // Arrange
            Program account = new Program(1000m);

            // Act
            account.Withdraw(300m);
            decimal actual = account.Balance;

            // Assert
            Assert.That(actual,Is.EqualTo(700m));
        }

        [Test]
        public void Test_Withdraw_InsufficientFunds()
        {
            // Arrange
            Program account = new Program(500m);

            // Act + Assert
            Assert.Throws<Exception>(() => account.Withdraw(1000m));
        }
    }
}
