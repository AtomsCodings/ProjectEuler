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
    public class LargestProductTests
    {
        [TestMethod()]
        public void calcTest()
        {
            //Arrange
            long factualAnswer = 23514624000;
            long answer = 0;

            //Act
            LargestProduct largestProduct = new LargestProduct();
            answer = largestProduct.calc();

            //Assert.Fail
            Assert.IsTrue(Equals(factualAnswer, answer));

            //Arrange
            answer = 0;

            //Act
            answer = largestProduct.calc();

            //Assert
            Assert.IsTrue(Equals(factualAnswer, answer));
        }
    }
}
