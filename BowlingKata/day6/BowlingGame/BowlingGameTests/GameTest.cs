using System;
using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTests
{
    [TestClass]
    public class GameTest
    {
        Game g;

        [TestInitialize]
        public void Setup()
        {
            g = new Game();
        }

        private void RollMany(int rollCount, int pins)
        {
            for (int i = 0; i < rollCount; i++)
                g.Roll(pins);
        }

        [TestMethod]
        public void TestGutterGame()
        {
            RollMany(20, 0);

            Assert.AreEqual(0, g.Score());
        }

        [TestMethod]
        public void TestAllInOneGame()
        {
            RollMany(20, 1);

            Assert.AreEqual(20, g.Score());
        }

        [TestMethod]
        public void TestOneSpare()
        {
            g.Roll(5);
            g.Roll(5);
            g.Roll(3);

            RollMany(17, 0);

            Assert.AreEqual(16, g.Score());
        }

        [TestMethod]
        public void TestOneStrike()
        {
            g.Roll(10);
            g.Roll(5);
            g.Roll(3);

            RollMany(16, 0);

            Assert.AreEqual(26, g.Score());
        }

        [TestMethod]
        public void TestPerfectGame()
        {
            RollMany(12, 10);

            Assert.AreEqual(300, g.Score());
        }
    }
}
