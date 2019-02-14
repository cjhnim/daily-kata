using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParkProblem.Test
{
    [TestClass]
    public class UnitTest1
    {
        MathMachine mathMachine;

        [TestInitialize]
        public void setUp()
        {
            mathMachine = new MathMachine();
        }

        [TestMethod]
        public void 데이터_없음_조합_없음()
        {
            int[] nums = {};

            string expected = "{}";

            Assert.AreEqual(expected, mathMachine.numOfCombination(nums, 7));
        }

        [TestMethod]
        public void 데이터_하나_조합_하나()
        {
            int[] nums = { 7 };

            string expected = "{7}";

            Assert.AreEqual(expected, mathMachine.numOfCombination(nums, 7));
        }

        [TestMethod]
        public void 데이터_하나_조합_없음()
        {
            int[] nums = { 6 };

            string expected = "{}";

            Assert.AreEqual(expected, mathMachine.numOfCombination(nums, 7));
        }

        [TestMethod]
        public void 데이터_하나_조합_없음_v1()
        {
            int[] nums = { 1 };

            string expected = "{1,1}";

            Assert.AreEqual(expected, mathMachine.numOfCombination(nums, 2));
        }

        [TestMethod]
        public void 데이터_둘_조합_없음()
        {
            int[] nums = { 5, 6 };

            string expected = "{}";

            Assert.AreEqual(expected, mathMachine.numOfCombination(nums, 7));
        }

        [TestMethod]
        public void 데이터_둘_조합_하나()
        {
            int[] nums = { 1, 6 };

            string expected = "{1,6}";

            Assert.AreEqual(expected, mathMachine.numOfCombination(nums, 7));
        }

        [TestMethod]
        public void 데이터_둘_조합_둘_v2()
        {
            int[] nums = { 7, 0 };

            string expected = "{7}, {7,0}";

            Assert.AreEqual(expected, mathMachine.numOfCombination(nums, 7));
        }

        [TestMethod]
        public void 데이터_둘_조합_둘_v3()
        {
            int[] nums = { 0, 7 };

            string expected = "{7}, {0,7}";

            Assert.AreEqual(expected, mathMachine.numOfCombination(nums, 7));
        }

        [TestMethod]
        public void 데이터_둘_조합_둘_v4()
        {
            int[] nums = { 3, 4 };

            string expected = "{3,3}";

            Assert.AreEqual(expected, mathMachine.numOfCombination(nums, 6));
        }

        [TestMethod]
        public void 데이터_둘_조합_둘_v5()
        {
            int[] nums = { 7, 7 };

            string expected = "{7}";

            Assert.AreEqual(expected, mathMachine.numOfCombination(nums, 7));
        }

        [TestMethod]
        public void 데이터_둘_조합_둘_v6()
        {
            int[] nums = { 4, 3 };

            string expected = "{3,3}";

            Assert.AreEqual(expected, mathMachine.numOfCombination(nums, 6));
        }

        [TestMethod]
        public void 데이터_둘_조합_둘_v7()
        {
            int[] nums = { 3, 1 };

            string expected = "{1,1}";

            Assert.AreEqual(expected, mathMachine.numOfCombination(nums, 2));
        }



    }
}
