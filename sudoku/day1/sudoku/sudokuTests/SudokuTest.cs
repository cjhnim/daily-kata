using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sudoku;

namespace sudokuTests
{
    [TestClass]
    public class SudokuTest
    {
        [TestMethod]
        public void Solve_and_Validator()
        {
            Sudoku sudoku = new Sudoku();

            int[,] question = new int[9, 9];
            int[,] answer = sudoku.solve(question);

            Assert.IsFalse(sudoku.validate(answer));
        }
    }
}
