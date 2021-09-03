using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankAccountNS;

namespace BankTests
{
    [TestClass]
    public class BasicBankTests
    {
        [TestMethod]
        public void Debit_WithValidAmound_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr Bean", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert

        }
    }
}
