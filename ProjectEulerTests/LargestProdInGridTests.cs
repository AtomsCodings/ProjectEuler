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
    public class LargestProdInGridTests
    {
        [TestMethod()]
        public void calcTest()
        {
            //Arrange
            int factualAnswer = 70600674;
            int calcAnswer = 0;

            //Act
            LargestProdInGrid largestProdInGrid = new LargestProdInGrid();
            calcAnswer = largestProdInGrid.calc();

            //Assert
            Assert.IsTrue(Equals(factualAnswer, calcAnswer));
        }
    }
}