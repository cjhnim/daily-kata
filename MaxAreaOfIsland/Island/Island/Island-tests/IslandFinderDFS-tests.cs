using System;
using Island;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Island_tests
{
    [TestClass]
    public class DFSWay
    {
        [TestMethod]
        public void CanInitialize()
        {
            var finder = new IslandFinderDFS();
        }

        [TestMethod]
        public void NullIsland()
        {
            Assert.AreEqual(0, new IslandFinderDFS().MaxAreaOfIsland(null));
        }

        [TestMethod]
        public void EmptyIsland()
        {
            int[][] grid = { };

            Assert.AreEqual(0, new IslandFinderDFS().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void OneLengthIsland()
        {
            int[][] grid = new int[][] {
                new int []{ 1 }
            };

            Assert.AreEqual(1, new IslandFinderDFS().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void ZeroIsland()
        {
            int[][] grid = new int[][] {
                new int []{ 0 }
            };

            Assert.AreEqual(0, new IslandFinderDFS().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void AllIsland()
        {
            int[][] grid = new int[][] {
                new int []{ 1,1,1 },
                new int []{ 1,1,1 },
                new int []{ 1,1,1 }
             };

            Assert.AreEqual(9, new IslandFinderDFS().MaxAreaOfIsland(grid));
        }

        [TestMethod]
        public void TwoIsland()
        {
            int[][] grid = new int[][] {
                new int []{ 1,0,1,1 },
             };

            Assert.AreEqual(2, new IslandFinderDFS().MaxAreaOfIsland(grid));
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
