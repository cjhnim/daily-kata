using System;
using Island;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Island_tests
{
    [TestClass]
    public class RecursiveWay
    {
        [TestMethod]
        public void CanInitiate()
        {
            var islandFinder = new IslandFinder();
        }

        [TestMethod]
        public void NULL_Island()
        {
            int[][] grid = null;

            Assert.AreEqual(0, new IslandFinder().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void EmptyIsland()
        {
            int[][] grid = { };

            Assert.AreEqual(0, new IslandFinder().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void ZeroIsland()
        {
            var grid = new int[][]
            {
                new int[] { 0 }
            };

            Assert.AreEqual(0, new IslandFinder().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void OneIsland()
        {
            var grid = new int[][]
            {
                new int[] { 1 }
            };

            Assert.AreEqual(1, new IslandFinder().MaxAreaOfIsland(grid));
        }
        [TestMethod]
        public void IslandCheck()
        {
            var grid = new int[][]
            {
                new int[] { 0,0,0},
                new int[] { 0,1,0},
                new int[] { 0,0,0}
            };

            Assert.AreEqual(1, new IslandFinder().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void IslandLeftUpperConnerCheck()
        {
            var grid = new int[][]
            {
                new int[] { 1,0},
                new int[] { 0,0},
            };

            Assert.AreEqual(1, new IslandFinder().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void IslandRightBelowConnerCheck()
        {
            var grid = new int[][]
            {
                new int[] { 0,0},
                new int[] { 0,1},
            };

            Assert.AreEqual(1, new IslandFinder().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void IslandCheck1()
        {
            var grid = new int[][]
            {
                new int[] { 0,1,0},
                new int[] { 0,0,0},
            };

            Assert.AreEqual(1, new IslandFinder().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void IslandCheck3()
        {
            var grid = new int[][]
            {
                new int[] { 0,0,0},
                new int[] { 0,0,0},
                new int[] { 0,1,0},
                new int[] { 0,0,0},
            };

            Assert.AreEqual(1, new IslandFinder().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void IslandCheckSizeTwo_DownTo()
        {
            var grid = new int[][]
            {
                new int[] { 0,0,0},
                new int[] { 0,1,0},
                new int[] { 0,1,0},
                new int[] { 0,0,0},
            };

            Assert.AreEqual(2, new IslandFinder().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void IslandCheckSizeTwo_RightTo()
        {
            var grid = new int[][]
            {
                new int[] { 0,0,0,0},
                new int[] { 0,1,0,0},
                new int[] { 0,1,1,0},
                new int[] { 0,0,0,0},
            };

            Assert.AreEqual(3, new IslandFinder().MaxAreaOfIsland(grid));
        }
        [TestMethod]
        public void IslandCheckSizeTwo_LeftTo()
        {
            var grid = new int[][]
            {
                new int[] { 0, 0, 0, 0,0},
                new int[] { 0, 0, 1, 0,0},
                new int[] { 0, 1, 1, 1,0},
                new int[] { 0, 0, 0, 0,0},
            };

            Assert.AreEqual(4, new IslandFinder().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void IslandCheckSizeTwo_Final()
        {
            var grid = new int[][]
            {
                new int[] { 0, 0, 0, 0,0},
                new int[] { 0, 0, 1, 0,0},
                new int[] { 0, 1, 1, 1,0},
                new int[] { 0, 0, 1, 0,0},
                new int[] { 0, 0, 0, 0,0},
            };

            Assert.AreEqual(5, new IslandFinder().MaxAreaOfIsland(grid));
        }
        [TestMethod]
        public void TwoIslandCheck()
        {
            var grid = new int[][]
            {
                new int[] { 0, 0, 0, 0,0},
                new int[] { 0, 0, 1, 0,0},
                new int[] { 0, 0, 0, 0,0},
                new int[] { 0, 0, 1, 1,0},
                new int[] { 0, 0, 0, 0,0},
            };

            Assert.AreEqual(2, new IslandFinder().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void Leetcode2()
        {
            var grid = new int[][]
                {new int[] { 1,1,0,0,0},
                 new int[] { 1,1,0,0,0},
                 new int[] { 0,0,0,1,1},
                 new int[] { 0,0,0,1,1} };

            Assert.AreEqual(4, new IslandFinder().MaxAreaOfIsland(grid));

        }
        [TestMethod]
        public void Leetcode()
        {
            var grid = new int[][]
                {new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                 new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                 new int[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                 new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 },
                 new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                 new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                 new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                 new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 }};

            Assert.AreEqual(6, new IslandFinder().MaxAreaOfIsland(grid));

        }
    }
}
