using System;
using diamond_kata._20200120;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace diamond_kata.tests._20200120
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void A_is_A()
        {
            var sol = new Solution('A');

            Assert.AreEqual("A\n",sol.print());
        }

        [TestMethod]
        public void B_is_Small_Diamond()
        {
            var sol = new Solution('B');
            string expected =
                " A\n" + 
                "B B\n" + 
                " A\n";
            Assert.AreEqual(expected, sol.print());
        }

        [TestMethod]
        public void C_is_Larger_Diamond()
        {
            var sol = new Solution('C');
            string expected =
                "  A\n" +
                " B B\n" +
                "C   C\n" +
                " B B\n" +
                "  A\n";
            Assert.AreEqual(expected, sol.print());
        }

        [TestMethod]
        public void D_is_MoreLarger_Diamond()
        {
            var sol = new Solution('D');
            string expected =
                "   A\n" +
                "  B B\n" +
                " C   C\n" +
                "D     D\n" +
                " C   C\n" +
                "  B B\n" +
                "   A\n";
            Assert.AreEqual(expected, sol.print());
        }
    }
}
