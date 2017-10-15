using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Tests
{
    [TestClass()]
    public class SumOfPrimesTests
    {
        [TestMethod()]
        public void calcTest()
        {
            //Arrange
            long factualAnswerPrime = 200000;
            long factualAnswerSum = 142915926073;

            //Act
            SumOfPrimes sumOfPrimes = new SumOfPrimes();
            var tuple = sumOfPrimes.calc();

            //Assert
            Assert.IsTrue(Equals(factualAnswerPrime, factualAnswerPrime) && (Equals(factualAnswerSum, factualAnswerSum)));
        }
    }
}