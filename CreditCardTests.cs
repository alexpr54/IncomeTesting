using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseTool.BL;

namespace CreditCard.Biz.Test
{
    [TestClass]
    public class CreditCardTests
    {
        [TestMethod]
        public void TestingUpdateCardName()
        {
            //Arrange
            var currentName = new CreditCards()
            {
                CardName = "Chase"
            };
            var expected = "Blackcard";

            //Act
            var actual = currentName.UpdateCardName("Blackcard");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
