using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace diamond_kata.tests
{
    [TestClass]
    public class UnitTest1
    {
        Solution sol;

        [TestInitialize]
        public void SetUp()
        {
            sol = new Solution();
        }

        [TestMethod]
        public void NonLetter()
        {
            char input = '0';
            string actual = sol.DrawDiamond(input);

            Assert.AreEqual("", actual);
        }

        [TestMethod]
        public void Input_A()
        {
            char input = 'A';
            string actual = sol.DrawDiamond(input);

            Assert.AreEqual("A\n", actual);
        }

        [TestMethod]
        public void Input_B()
        {
            char input = 'B';
            string actual = sol.DrawDiamond(input);

            string expected =
                " A\n"+
                "B B\n"+
                " A\n";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_C()
        {
            char input = 'C';
            string actual = sol.DrawDiamond(input);

            string expected =
                "  A\n" +
                " B B\n" +
                "C   C\n" +
                " B B\n" +
                "  A\n";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_D()
        {
            char input = 'D';
            string actual = sol.DrawDiamond(input);

            string expected =
                "   A\n" +
                "  B B\n" +
                " C   C\n" +
                "D     D\n" +
                " C   C\n" +
                "  B B\n" +
                "   A\n";

            Assert.AreEqual(expected, actual);
        }
    }
}
