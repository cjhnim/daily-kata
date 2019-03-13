﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void 모든프레임_핀한개쓰러트림()
        {
            rollMany(count: 20, pins: 1);

            Assert.AreEqual(20, scoreManager.score());
        }

        [TestMethod]
        public void 한프레임만_스페어_보너스없음()
        {
            scoreManager.roll(pins: 9);
            scoreManager.roll(pins: 1);
            rollMany(count:18, pins:0);

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
        public void 스트라이크_보너스있음()
        {
            scoreManager.roll(pins: 10);

            scoreManager.roll(pins: 5);

            rollMany(count: 18, pins: 0);

            Assert.AreEqual(20, scoreManager.score());
        }

        private void rollMany(int count, int pins)
        {
            for (int i = 0; i < count; i++)
                scoreManager.roll(pins);
        }
    }
}
