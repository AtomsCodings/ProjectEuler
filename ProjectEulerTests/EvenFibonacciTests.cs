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
    public class EvenFibonacciTests
    {
        [TestMethod()]
        public void calcTest()
        {
            //Arrange
            int factualAnswer = 44;
            int calcAnswer = 0;

            //Act
            EvenFibonacci evenFibonacci = new EvenFibonacci();
            calcAnswer = evenFibonacci.calc();

            //Assert
            Assert.IsTrue(Equals(factualAnswer, calcAnswer));
        }
    }
}