﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Tests
{
    [TestClass()]
    public class MutiplesofTests
    {
        [TestMethod()]
        public void calcTest()
        {
            //Arrange
            int factualAnswer = 233168;
            int calcAnswer = 0;

            //Act
            Mutiplesof multiplesOf = new Mutiplesof();
            calcAnswer = multiplesOf.calc();

            //Assert.Fail
            Assert.IsTrue(Equals(factualAnswer, calcAnswer));
        }
    }
}