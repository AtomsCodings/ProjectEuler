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
    public class PythagoreanTripletTests
    {
        [TestMethod()]
        public void calcTest()
        {
            //Arrange
            int factualAnswerA = 200;
            int factualAnswerB = 375;
            int factualAnswerC = 425;

            //Act
            PythagoreanTriplet pythagoreanTriplet = new PythagoreanTriplet();
            var tuple = pythagoreanTriplet.calc();

            //Assert
            Assert.IsTrue(Equals(tuple.Item1, factualAnswerA) && (Equals(tuple.Item2, factualAnswerB)) && (Equals(tuple.Item3, factualAnswerC)));
        }
    }
}