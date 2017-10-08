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
    public class SumSquareDifTests
    {
        [TestMethod()]
        public void calcTest()
        {
            //Arrange
            long factualAnswer = 25164150;
            long answer = 0;

            //Act
            SumSquareDif sumSquareDif = new SumSquareDif();
            answer = sumSquareDif.calc();

            //Assert.Fail
            Assert.IsTrue(Equals(factualAnswer, answer));

            //Arrange
            answer = 0;

            //Act
            answer = sumSquareDif.calcUsingMath();

            //Assert.Fail
            Assert.IsTrue(Equals(factualAnswer, answer));
        }
    }
}