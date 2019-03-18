using System;
using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTests
{
    [TestClass]
    public class ScoreBoardTests
    {
        private Game g;

        [TestInitialize]
        public void Setup()
        {
            g = new Game();
        }

        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                g.Roll(pins);
        }

        [TestMethod]
        public void TestGutterGame()
        {
            rollMany(20, 0);

            Assert.AreEqual(0, g.Score());
        }

        [TestMethod]
        public void TestAllOnes()
        {
            rollMany(20, 1);

            Assert.AreEqual(20, g.Score());
        }

        [TestMethod]
        public void TestOneSpare()
        {
            rollSpare();
            g.Roll(3);
            rollMany(17, 0);

            Assert.AreEqual(16, g.Score());
        }

        [TestMethod]
        public void TestOneStrike()
        {
            rollStrike();
            g.Roll(3);
            g.Roll(4);
            rollMany(16, 0);

            Assert.AreEqual(24, g.Score());
        }

        [TestMethod]
        public void TestAllRolls()
        {
            rollMany(18, 1);
            g.Roll(5);
            g.Roll(5);
            g.Roll(2);

            Assert.AreEqual(30, g.Score());
        }

        [TestMethod]
        public void TestPerfectGame()
        {
            rollMany(12, 10);

            Assert.AreEqual(300, g.Score());
        }

        private void rollStrike()
        {
            g.Roll(10);
        }

        private void rollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }
    }
}
