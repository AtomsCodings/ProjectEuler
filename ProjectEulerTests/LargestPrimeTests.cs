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
    public class LargestPrimeTests
    {
        [TestMethod()]
        public void calcTest()
        {
            //Arrange
            int factualAnswer = 6857;
            int calcAnswer = 0;

            //Act
            LargestPrime largestPrime = new LargestPrime();
            calcAnswer = largestPrime.calc();

            //Assert
            Assert.IsTrue(Equals(factualAnswer, calcAnswer));
        }
    }
}