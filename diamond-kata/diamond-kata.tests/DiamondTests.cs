using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace diamond_kata.tests
{
    [TestClass]
    public class DiamondTests
    {
        [TestMethod]
        public void A()
        {
            Diamond diamond = new Diamond('A');
            string expected = "A\n";

            Assert.AreEqual(expected, diamond.Print());
        }

        [TestMethod]
        public void B()
        {
            Diamond diamond = new Diamond('B');
            string expected = 
                " A\n" +
                "B B\n" +
                " A\n";

            Assert.AreEqual(expected, diamond.Print());
        }

        [TestMethod]
        public void C()
        {
            Diamond diamond = new Diamond('C');
            string expected =
                "  A\n" +
                " B B\n" +
                "C   C\n" +
                " B B\n" +
                "  A\n";

            Assert.AreEqual(expected, diamond.Print());
        }

        [TestMethod]
        public void D()
        {
            Diamond diamond = new Diamond('D');
            string expected =
                "   A\n" +
                "  B B\n" +
                " C   C\n" +
                "D     D\n" +
                " C   C\n" +
                "  B B\n" +
                "   A\n";

            Assert.AreEqual(expected, diamond.Print());
        }
    }
}
