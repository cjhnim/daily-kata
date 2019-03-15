using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class ScoreBoardTests
    {
        ScoreBoard scoreBoard;

        [TestInitialize]
        public void SetUp()
        {
            scoreBoard = new ScoreBoard();
        }

        [TestMethod]
        public void 모두0점을친다()
        {
            rollMany(count: 20, pins: 0);

            Assert.AreEqual(0, scoreBoard.score());
        }

        [TestMethod]
        public void 모두1점을친다()
        {
            rollMany(count: 20, pins: 1);

            Assert.AreEqual(20, scoreBoard.score());
        }

        [TestMethod]
        public void 스페어를친다()
        {
            scoreBoard.roll(5);
            scoreBoard.roll(5);
            scoreBoard.roll(5);
            scoreBoard.roll(0);

            rollMany(count: 16, pins: 0);

            Assert.AreEqual(20, scoreBoard.score());
        }

        [TestMethod]
        public void 모두스페어를친다()
        {
            rollMany(count: 21, pins: 5);

            Assert.AreEqual(150, scoreBoard.score());
        }

        [TestMethod]
        public void 스트라이크를친다()
        {
            scoreBoard.roll(10);
            scoreBoard.roll(5);
            scoreBoard.roll(4);

            rollMany(count: 16, pins: 0);

            Assert.AreEqual(28, scoreBoard.score());
        }

        [TestMethod]
        public void 올스트라이크()
        {
            rollMany(count: 12, pins: 10);

            Assert.AreEqual(300, scoreBoard.score());
        }

        private void rollMany(int count, int pins)
        {
            for (int i = 0; i < count; i++)
                scoreBoard.roll(pins);
        }
    }
}
