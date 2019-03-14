using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO:
// [ ] 한 프레임은 기본적으로 2번 던진다.
// [ ] strike 이면 한프레임은 한번 친다.
// [ ] 최대 10프레임이다.
// [ ] 한 프레임의 점수는 던진 점수의 합이다.
// [ ] open이면 보너스는 없다.
// [ ] spare이면 다음 프레임의 점수를 더한 값이 보너스이다.
// [ ] strike이면 다음 프레임의 두 점수를 더한 값이 보너스이다.
// [ ] 마지막 10프레임은 스트라이크던, 스페어이든 보너스 점수가 없다.(다음 프레임이 없으므로)


namespace BowlingGame.Test
{
    [TestClass]
    public class ScoreManagerTest
    {
        ScoreManager scoreManager;

        [TestInitialize]
        public void SetUp()
        {
            scoreManager = new ScoreManager();
        }

        [TestMethod]
        public void 아무것도_안친상태()
        {
            Assert.AreEqual(0, scoreManager.score());
        }

        [TestMethod]
        public void 한번굴렸으나_아무것도못침()
        {
            scoreManager.roll(pins: 0);

            Assert.AreEqual(0, scoreManager.score());
        }

        [TestMethod]
        public void 한번굴렸으나_핀한개쓰러트림()
        {
            scoreManager.roll(pins: 1);

            Assert.AreEqual(1, scoreManager.score());
        }

        [TestMethod]
        public void 모든프레임_오픈()
        {
            rollMany(count: 20, pins: 1);

            Assert.AreEqual(20, scoreManager.score());
        }

        [TestMethod]
        public void 한프레임만_스페어_보너스없음()
        {
            scoreManager.roll(pins: 9);
            scoreManager.roll(pins: 1);
            rollMany(count: 18, pins: 0);

            Assert.AreEqual(10, scoreManager.score());
        }

        [TestMethod]
        public void 한프레임만_스페어_보너스있음()
        {
            scoreManager.roll(pins: 9);
            scoreManager.roll(pins: 1);
            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 0);

            rollMany(count: 16, pins: 0);

            Assert.AreEqual(20, scoreManager.score());
        }

        [TestMethod]
        public void 한프레임만_스페어2개_보너스있음()
        {
            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 0);

            rollMany(count: 14, pins: 0);

            Assert.AreEqual(35, scoreManager.score());
        }

        [TestMethod]
        public void 한프레임만_스페어3개_보너스있음()
        {
            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 5);

            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 5);

            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 5);

            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 0);

            rollMany(count: 12, pins: 0);

            Assert.AreEqual(50, scoreManager.score());
        }

        [TestMethod]
        public void 마지막프레임만_스페어1개_보너스있음()
        {
            rollMany(count: 18, pins: 0);
            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 5);

            Assert.AreEqual(15, scoreManager.score());
        }

        [TestMethod]
        public void 스트라이크_보너스있음_하나()
        {
            scoreManager.roll(pins: 10);
            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 0);

            rollMany(count: 16, pins: 0);

            Assert.AreEqual(20, scoreManager.score());
        }

        [TestMethod]
        public void 스트라이크_보너스있음_둘()
        {
            scoreManager.roll(pins: 10);
            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 5);

            rollMany(count: 16, pins: 0);

            Assert.AreEqual(30, scoreManager.score());
        }

        [TestMethod]
        public void 스트라이크_스페어_혼합()
        {
            scoreManager.roll(pins: 10);
            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 5);
            scoreManager.roll(pins: 1);
            scoreManager.roll(pins: 0);

            rollMany(count: 14, pins: 0);

            Assert.AreEqual(32, scoreManager.score());
        }

        [TestMethod]
        public void 올스페어()
        {
            rollMany(count: 21, pins: 5);

            Assert.AreEqual(150, scoreManager.score());
        }

        [TestMethod]
        public void 올스트라이크()
        {
            rollMany(count: 12, pins: 10);

            Assert.AreEqual(300, scoreManager.score());
        }

        private void rollMany(int count, int pins)
        {
            for (int i = 0; i < count; i++)
                scoreManager.roll(pins);
        }
    }
}
