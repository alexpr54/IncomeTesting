using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseTool.BL;

namespace IncomeBlTest
{
    [TestClass]
    public class IncomeTests
    {
        [TestMethod]
        public void AddIncomeValidEntries()
        {
            //Arrange
            var totalIncome = new Income()
            {
                LsgIncome = 30,
                JulianaDeposit = 30,
                UnexpectedIncome = 3,
                FamilyGift = 5,
                RolloverAmount = 10
            };
            var expected = 78;

            //Act
            var actual = totalIncome.AddIncomes(); 

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MissingLsgIncome()
        {
            //Arrange
            var totalIncome = new Income()
            {
                JulianaDeposit = 20,
                RolloverAmount = 50
            };
            var expected = 70;

            //Act
            var actual = totalIncome.AddIncomes();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MissingJulianaDeposit()
        {
            //Arrange
            var totalIncome = new Income()
            {
                LsgIncome = 20,
                RolloverAmount = 10,
                FamilyGift = 3,
                UnexpectedIncome =4
            };
            var expected = 37;

            //Act
            var actual = totalIncome.AddIncomes();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingUpdateAmountMethod()
        {
            //Arrange
            var currentIncome = new Income()
            {
                LsgIncome = 10,
                JulianaDeposit = 5,
                RolloverAmount = 1,
                UnexpectedIncome = 1,
                FamilyGift = 1,
            };
            var expected = 19;

            //Act
            var actual = currentIncome.UpdateBalanceAmount(1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
