using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sudoku;

namespace sudokuTests
{
    [TestClass]
    public class SudokuTest
    {
        int[,] expected = new int[9, 9] {
                {5,3,4,6,7,8,9,1,2},
                {6,7,2,1,9,5,3,4,8},
                {1,9,8,3,4,2,5,6,7},
                {8,5,9,7,6,1,4,2,3},
                {4,2,6,8,5,3,7,9,1},
                {7,1,3,9,2,4,8,5,6},
                {9,6,1,5,3,7,2,8,4},
                {2,8,7,4,1,9,6,3,5},
                {3,4,5,2,8,6,1,7,9}
                };

        [TestInitialize]
        public void SetUp()
        {
        }

        [TestMethod]
        public void 답()
        {
            var sudoku = new Sudoku {
                question = new int[9, 9] {
                {5,3,4,6,7,8,9,1,2},
                {6,7,2,1,9,5,3,4,8},
                {1,9,8,3,4,2,5,6,7},
                {8,5,9,7,6,1,4,2,3},
                {4,2,6,8,5,3,7,9,1},
                {7,1,3,9,2,4,8,5,6},
                {9,6,1,5,3,7,2,8,4},
                {2,8,7,4,1,9,6,3,5},
                {3,4,5,2,8,6,1,7,9}
                }
            };

            CollectionAssert.AreEqual(expected, sudoku.Solve());
        }

        [TestMethod]
        public void 수평검색_1개()
        {
            var sudoku = new Sudoku
            {
                question = new int[9, 9] {
                {0,3,4,6,7,8,9,1,2},
                {6,7,2,1,9,5,3,4,8},
                {1,9,8,3,4,2,5,6,7},
                {8,5,9,7,6,1,4,2,3},
                {4,2,6,8,5,3,7,9,1},
                {7,1,3,9,2,4,8,5,6},
                {9,6,1,5,3,7,2,8,4},
                {2,8,7,4,1,9,6,3,5},
                {3,4,5,2,8,6,1,7,9}
                }
            };

            Assert.AreEqual(expected[0, 0], sudoku.Solve()[0, 0]);
        }

        [TestMethod]
        public void 수평수직검색()
        {
            var sudoku = new Sudoku
            {
                question = new int[9, 9] {
                {0,3,4,0,7,8,9,1,2},
                {6,7,2,1,9,5,3,4,8},
                {1,9,8,3,4,2,5,6,7},
                {8,5,9,7,6,1,4,2,3},
                {4,2,6,8,5,3,7,9,1},
                {7,1,3,9,2,4,8,5,6},
                {9,6,1,5,3,7,2,8,4},
                {2,8,7,4,1,9,6,3,5},
                {3,4,5,2,8,6,1,7,9}
                }
            };

            Assert.AreEqual(expected[0, 0], sudoku.Solve()[0, 0]);
        }

        [TestMethod]
        public void 수평수직검색2()
        {
            var sudoku = new Sudoku
            {
                question = new int[9, 9] {
                {0,3,4,0,7,8,9,1,2},
                {6,7,2,1,9,5,3,4,8},
                {1,9,8,3,4,2,5,6,7},
                {0,5,9,7,6,1,4,2,3},
                {4,2,6,8,5,3,7,9,1},
                {7,1,3,9,2,4,8,5,6},
                {9,6,1,5,3,7,2,8,4},
                {2,8,7,4,1,9,6,3,5},
                {3,4,5,2,8,6,1,7,9}
                }
            };

            Assert.AreEqual(expected[0, 0], sudoku.Solve()[0, 0]);
        }

        [TestMethod]
        public void 수평수직센터검색()
        {
            var sudoku = new Sudoku
            {
                question = new int[9, 9] {
                {0,3,4,6,0,8,9,1,2},
                {6,7,2,1,9,5,3,4,8},
                {1,9,8,3,4,2,5,6,7},
                {8,5,9,7,6,1,4,2,3},
                {4,2,6,8,5,3,7,9,1},
                {0,1,3,9,2,4,8,5,6},
                {9,6,1,5,3,7,2,8,4},
                {2,8,7,4,1,9,6,3,5},
                {3,4,5,2,8,6,1,7,9}
                }
            };

            Assert.AreEqual(expected[0, 0], sudoku.Solve()[0, 0]);
        }


        [TestMethod]
        public void 임의좌표()
        {
            var sudoku = new Sudoku
            {
                question = new int[9, 9] {
                {5,3,4,6,7,8,9,1,2},
                {6,0,2,1,9,5,3,4,8},
                {1,9,8,3,4,2,5,6,7},
                {8,5,9,7,6,1,4,2,3},
                {4,2,6,8,5,3,7,9,1},
                {7,1,3,9,2,4,8,5,6},
                {9,6,1,5,3,7,2,8,4},
                {2,8,7,4,1,9,6,3,5},
                {3,4,5,2,8,6,1,7,9}
                }
            };

            CollectionAssert.AreEqual(expected, sudoku.Solve());
        }



        //[TestMethod]
        //public void 수평수직검색_두개의해에서답찾기()
        //{
        //    int[,] question = new int[9, 9] {
        //        {0,0,4,6,7,8,9,1,2},
        //        {6,7,2,1,9,5,3,4,8},
        //        {1,9,8,3,4,2,5,6,7},
        //        {8,5,9,7,6,1,4,2,3},
        //        {4,2,6,8,5,3,7,9,1},
        //        {7,1,3,9,2,4,8,5,6},
        //        {9,6,1,5,3,7,2,8,4},
        //        {2,8,7,4,1,9,6,3,5},
        //        {3,4,5,2,8,6,1,7,9}
        //        };

        //    CollectionAssert.AreEqual(expected, sudoku.solve(question));
        //}
    }
}
