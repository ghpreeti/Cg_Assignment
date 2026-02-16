using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ValidationBankingNUnit
{
    [TestClass]   // 1) Test attribute for class
    public class UnitTest
    {
        [TestMethod]   // 2) Test attribute for method
        public void Test_Deposit_ValidAmount()
        {
            // Arrange
            Program account = new Program(1000m);

            // Act
            account.Deposit(500m);
            decimal actual = account.Balance;

            // Assert
            Assert.AreEqual(1500m, actual);
        }

        [TestMethod]
        public void Test_Deposit_NegativeAmount()
        {
            // Arrange
            Program account = new Program(1000m);

            // Act + Assert
            Assert.ThrowsException<Exception>(() => account.Deposit(-100m));
        }

        [TestMethod]
        public void Test_Withdraw_ValidAmount()
        {
            // Arrange
            Program account = new Program(1000m);

            // Act
            account.Withdraw(300m);
            decimal actual = account.Balance;

            // Assert
            Assert.AreEqual(700m, actual);
        }

        [TestMethod]
        public void Test_Withdraw_InsufficientFunds()
        {
            // Arrange
            Program account = new Program(500m);

            // Act + Assert
            Assert.ThrowsException<Exception>(() => account.Withdraw(1000m));
        }
    }
}
