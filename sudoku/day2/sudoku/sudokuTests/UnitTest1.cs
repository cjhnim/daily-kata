﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sudoku;

namespace sudokuTests
{
    [TestClass]
    public class SudokuTest
    {



        [TestMethod]
        public void 풀이_할_칸이_없다()
        {
            string expectSolution =
        "5         3         4         6         7         8         9         1         2        \n" +
        "6         7         2         1         9         5         3         4         8        \n" +
        "1         9         8         3         4         2         5         6         7        \n" +
        "8         5         9         7         6         1         4         2         3        \n" +
        "4         2         6         8         5         3         7         9         1        \n" +
        "7         1         3         9         2         4         8         5         6        \n" +
        "9         6         1         5         3         7         2         8         4        \n" +
        "2         8         7         4         1         9         6         3         5        \n" +
        "3         4         5         2         8         6         1         7         9        \n";

            var sudoku = new Sudoku
            {
                Puzzle = new int[] {
               5,3,4,6,7,8,9,1,2,
               6,7,2,1,9,5,3,4,8,
               1,9,8,3,4,2,5,6,7,
               8,5,9,7,6,1,4,2,3,
               4,2,6,8,5,3,7,9,1,
               7,1,3,9,2,4,8,5,6,
               9,6,1,5,3,7,2,8,4,
               2,8,7,4,1,9,6,3,5,
               3,4,5,2,8,6,1,7,9}
            };

            Assert.AreEqual(expectSolution, sudoku.Solve());
        }

        [TestMethod]
        public void 퍼즐의칸은81이다()
        {
            var sudoku = new Sudoku
            {
                Puzzle = new int[] {
               5,3,4,6,7,8,9,1,2,
               6,7,2,1,9,5,3,4,8,
               1,9,8,3,4,2,5,6,7,
               8,5,9,7,6,1,4,2,3,
               4,2,6,8,5,3,7,9,1,
               7,1,3,9,2,4,8,5,6,
               9,6,1,5,3,7,2,8,4,
               2,8,7,4,1,9,6,3,5,
               3,4,5,2,8,6,1,7,9}
            };

            Assert.AreEqual(81, sudoku.Size());
        }

        [TestMethod]
        public void 풀수있는칸이없다()
        {
            string expectSolution =
        "123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n";

            var sudoku = new Sudoku
            {
                Puzzle = new int[] {
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0
                }
            };

            Assert.AreEqual(expectSolution, sudoku.Solve());
        }

        [TestMethod]
        public void 숫자하나를할당해본다()
        {
            string expectSolution =
        "3         12456789  12456789  12456789  12456789  12456789  12456789  12456789  12456789 \n" +
        "12456789  12456789  12456789  123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "12456789  12456789  12456789  123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "12456789  123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "12456789  123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "12456789  123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "12456789  123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "12456789  123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n" +
        "12456789  123456789 123456789 123456789 123456789 123456789 123456789 123456789 123456789\n";

            var sudoku = new Sudoku
            {
                Puzzle = new int[] {
                3,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0
                }
            };

            Assert.AreEqual(expectSolution, sudoku.Solve());
        }

        [TestMethod]
        public void replace연습()
        {
            string text = "123456789";
            Assert.AreEqual("12456789", text.Replace("3", ""));
        }
    }
}
