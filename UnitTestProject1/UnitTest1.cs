using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using adilRouibet_s00189549;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Phone testPhone = new Phone();
            testPhone.Price = 500;

            decimal expectedPrice = 550;


            //Act
            testPhone.IncreasedPrice(10);

            decimal actual = testPhone.Price;


            //Assert
            Assert.AreEqual(expectedPrice , actual);



        }
    }
}
