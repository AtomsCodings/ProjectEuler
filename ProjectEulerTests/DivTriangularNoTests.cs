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
    public class DivTriangularNoTests
    {
        [TestMethod()]
        public void calcTest()
        {
            //Arrange
            int factualAnswer = 76576500;
            int calcAnswer = 0;

            //Act
            DivTriangularNo divTriangularNo = new DivTriangularNo();
            calcAnswer = divTriangularNo.calc();

            //Assert
            Assert.IsTrue(Equals(factualAnswer, calcAnswer));
        }
    }
}