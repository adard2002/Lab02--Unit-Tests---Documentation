using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests;
using Xunit;

namespace BankTests
{
    public class ProgramTests
    {

        [Fact]
        public void adding_money_into_balance()
        {
            // Arrange
            Program.Balance = 500;

            // Act
            decimal result = Program.ViewBalance();

            // Assert
            Assert.Equal(500, result);
        }


    }
}
