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
    public class _10001stPrimeTests
    {
        [TestMethod()]
        public void calcTest()
        {
            //Arrange
            long factualAnswer = 104743;
            long answer = 0;

            //Act
            _10001stPrime prime = new _10001stPrime();
            answer = prime.calc();

            //Assert.Fail
            Assert.IsTrue(Equals(factualAnswer, answer));

            //Arrange
            answer = 0;

            //Act
            answer = prime.calc();

            //Assert
            Assert.IsTrue(Equals(factualAnswer, answer));
        }
    }
}