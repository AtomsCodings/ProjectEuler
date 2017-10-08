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
    public class SmallestMultipleTests
    {
        [TestMethod()]
        public void calcTest()
        {
            //Arrange
            long factualAnswer = 232792560;
            long answer = 0;

            //Act
            SmallestMultiple smallestMultiple = new SmallestMultiple();
            answer = smallestMultiple.calc();

            //Assert.Fail
            Assert.IsTrue(Equals(factualAnswer, answer));
        }
    }
}