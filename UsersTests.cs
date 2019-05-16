using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseTool.BL;

namespace Users.Biz.Test
{
    [TestClass]
    public class UsersTests
    {
        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var husband = new ExpenseTool.BL.Users()
            {
                FirstName = "Raymond",
                MiddleInitial = "A",
                LastName = "Rosado",
            };
            var expected = "Raymond A. Rosado";

            //Act
            var actual = husband.GetFullName();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MissingLastName()
        {
            //Arrange
            var wife = new ExpenseTool.BL.Users()
            {
                FirstName = "Juliana",
                MiddleInitial = "A"
            };
            var expected = false;

            //Act
            var actual = wife.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
