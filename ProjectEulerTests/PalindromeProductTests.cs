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
    public class PalindromeProductTests
    {
        [TestMethod()]
        public void calcTest()
        {
            //Arrange
            int factualAnswer = 906609;
            var tuple = new Tuple<int, int, int>(0, 0, 0);

            //Act
            PalindromeProduct palindromeProduct = new PalindromeProduct();
            tuple = palindromeProduct.calc();

            //Assert.Fail
            Assert.IsTrue(Equals(factualAnswer, tuple.Item3));
        }
    }
}