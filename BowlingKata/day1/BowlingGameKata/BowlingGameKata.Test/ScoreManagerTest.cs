using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameKata.Test
{
    [TestClass]
    public class ScoreManagerTest
    {
        ScoreManager scoreMgr;

        [TestInitialize]
        public void SetUp()
        {
            scoreMgr = new ScoreManager();
        }

        [TestMethod]
        public void 빵점()
        {
            scoreMgr.roll(0);
            Assert.AreEqual(0, scoreMgr.score());
        }

        [TestMethod]
        public void 모두빵점()
        {
            rolls(20, 0);

            Assert.AreEqual(0, scoreMgr.score());
        }

        [TestMethod]
        public void 모두오픈()
        {
            rolls(20, 1);

            Assert.AreEqual(20, scoreMgr.score());
        }

        [TestMethod]
        public void 스페어하나_그리고빵점()
        {
            scoreMgr.roll(5);
            scoreMgr.roll(5);

            rolls(18, 0);

            Assert.AreEqual(10, scoreMgr.score());
        }

        [TestMethod]
        public void 스페어하나_다음친점수를합산한다()
        {
            scoreMgr.roll(5);
            scoreMgr.roll(5);
            scoreMgr.roll(5);

            rolls(17, 0);

            Assert.AreEqual(20, scoreMgr.score());
        }

        [TestMethod]
        public void 스페어하나_다음친점수를합산한다2()
        {
            scoreMgr.roll(5);
            scoreMgr.roll(5);
            scoreMgr.roll(5);
            scoreMgr.roll(5);

            rolls(16, 0);

            Assert.AreEqual(25, scoreMgr.score());
        }

        [TestMethod]
        public void 스페어하나_다음친점수를합산한다3()
        {
            scoreMgr.roll(5);
            scoreMgr.roll(5);
            scoreMgr.roll(5);
            scoreMgr.roll(5);
            scoreMgr.roll(5);

            rolls(16, 0);

            Assert.AreEqual(35, scoreMgr.score());
        }

        [TestMethod]
        public void 스트라이크하나()
        {
            scoreMgr.roll(10);
            scoreMgr.roll(0);

            rolls(18, 0);

            Assert.AreEqual(10, scoreMgr.score());
        }

        [TestMethod]
        public void 스트라이크하나_다음점수합산()
        {
            scoreMgr.roll(10);
            scoreMgr.roll(5);
            scoreMgr.roll(0);

            rolls(16, 0);

            Assert.AreEqual(20, scoreMgr.score());
        }

        [TestMethod]
        public void 스트라이크하나_다음두점수합산()
        {
            scoreMgr.roll(10);
            scoreMgr.roll(5);
            scoreMgr.roll(4);

            rolls(16, 0);

            Assert.AreEqual(20, scoreMgr.score());
        }



        private void rolls(int rollCount, int pins)
        {
            for (int i = 0; i < rollCount; i++)
                scoreMgr.roll(pins);
        }
    }
}
