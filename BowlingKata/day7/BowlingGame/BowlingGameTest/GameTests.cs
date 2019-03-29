using System;
using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTest
{
    [TestClass]
    public class GameTests
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
            {
                g.Roll(pins);
            }
        }

        [TestMethod]
        public void TestAllGuterGame()
        {
            RollMany(rollCount: 20, pins: 0);

            Assert.AreEqual(0, g.Score());
        }

       
        [TestMethod]
        public void TestAllOnePinGame()
        {
            RollMany(rollCount: 20, pins: 1);

            Assert.AreEqual(20, g.Score());
        }

        [TestMethod]
        public void TestSpareGame()
        {
            g.Roll(5);
            g.Roll(5);
            g.Roll(5);

            RollMany(rollCount: 17, pins: 0);

            Assert.AreEqual(20, g.Score());
        }

        [TestMethod]
        public void TestStrikeGame()
        {
            g.Roll(10);
            g.Roll(5);
            g.Roll(4);

            RollMany(rollCount: 16, pins: 0);

            Assert.AreEqual(28, g.Score());
        }

        [TestMethod]
        public void TestPerfectGame()
        {
            RollMany(rollCount: 12, pins: 10);

            Assert.AreEqual(300, g.Score());
        }
    }
}
