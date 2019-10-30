using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace merge_intervals.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanInstantiate()
        {
            new IntervalMerger();
        }

        [TestMethod]
        public void EmptyInput()
        {
            int[][] input = new int[][] { };

            Assert.AreEqual(0, new IntervalMerger().Merge(input).Length);
        }

        [TestMethod]
        public void OneInput()
        {
            int[][] input = new int[][] {
                new int[] { 1,2 }
            };

            Assert.AreEqual(1, new IntervalMerger().Merge(input).Length);
            CollectionAssert.AreEqual(input[0], new IntervalMerger().Merge(input)[0]);
        }

        [TestMethod]
        public void TwoInputWithoutOverlapped()
        {
            int[][] input = new int[][] {
                new int[] { 1,2 },
                new int[] { 3,4 }
            };

            int[][] expect = new int[][] {
                new int[] { 1,2 },
                new int[] { 3,4 }
            };

            int[][] result = new IntervalMerger().Merge(input);
            Assert.AreEqual(expect.Length, result.Length);
            for(int i=0; i< input.Length; i++)
                CollectionAssert.AreEqual(expect[i], result[i]);
        }

        [TestMethod]
        public void TwoInputWithoutOverlappedNeedSort()
        {
            int[][] input = new int[][] {
                new int[] { 3,4 },
                new int[] { 1,2 }
            };

            int[][] expect = new int[][] {
                new int[] { 1,2 },
                new int[] { 3,4 }
            };

            int[][] result = new IntervalMerger().Merge(input);
            Assert.AreEqual(expect.Length, result.Length);
            for (int i = 0; i < input.Length; i++)
                CollectionAssert.AreEqual(expect[i], result[i]);
        }

        [TestMethod]
        public void ThreeInputWithoutOverlappedNeedSort()
        {
            int[][] input = new int[][] {
                new int[] { 3,4 },
                new int[] { 5,6 },
                new int[] { 1,2 }
            };

            int[][] expect = new int[][] {
                new int[] { 1,2 },
                new int[] { 3,4 },
                new int[] { 5,6 }
            };

            int[][] result = new IntervalMerger().Merge(input);
            Assert.AreEqual(expect.Length, result.Length);
            for (int i = 0; i < input.Length; i++)
                CollectionAssert.AreEqual(expect[i], result[i]);
        }

        [TestMethod]
        public void TwoInputWithOverlapped()
        {
            int[][] input = new int[][] {
                new int[] { 1,3 },
                new int[] { 2,4 }
            };

            int[][] expect = new int[][] {
                new int[] { 1,4 },
            };

            int[][] result = new IntervalMerger().Merge(input);
            Assert.AreEqual(expect.Length, result.Length);
            CollectionAssert.AreEqual(expect[0], result[0]);
        }

        [TestMethod]
        public void LeetCode1()
        {
            int[][] input = new int[][] {
                new int[] { 1,3 },
                new int[] { 2,6 },
                new int[] { 8, 10 },
                new int[] { 15, 18 }
            };

            int[][] expect = new int[][] {
                new int[] { 1,6 },
                new int[] { 8,10 },
                new int[] { 15,18 }
            };

            int[][] result = new IntervalMerger().Merge(input);
            Assert.AreEqual(expect.Length, result.Length);
            CollectionAssert.AreEqual(expect[0], result[0]);
            CollectionAssert.AreEqual(expect[1], result[1]);
            CollectionAssert.AreEqual(expect[2], result[2]);
        }

        [TestMethod]
        public void LeetCode2()
        {
            int[][] input = new int[][] {
                new int[] { 1,4 },
                new int[] { 4,5 }
            };

            int[][] expect = new int[][] {
                new int[] { 1,5 },
            };

            int[][] result = new IntervalMerger().Merge(input);
            Assert.AreEqual(expect.Length, result.Length);
            CollectionAssert.AreEqual(expect[0], result[0]);
        }
    }
}
