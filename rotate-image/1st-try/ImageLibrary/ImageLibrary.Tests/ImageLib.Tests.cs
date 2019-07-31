using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImageLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        ImageLib imageLib;

        [TestInitialize]
        public void SetUp()
        {
            imageLib = new ImageLib();
        }

        [TestMethod]
        public void demension_2_no_need_to_rotate()
        {
            int[,] given = new int[2, 2] { { 1, 1 }, { 1, 1 } };
            int[,] expected = new int[2, 2] { { 1, 1 }, { 1, 1 } };

            CollectionAssert.AreEqual(expected, imageLib.Rotate(given));
        }

        [TestMethod]
        public void demension_2()
        {
            int[,] given = new int[2, 2] {
                { 1, 2 },
                { 4, 5 } };
            int[,] expected = new int[2, 2] {
                { 4, 1 },
                { 5, 2 } };

            CollectionAssert.AreEqual(expected, imageLib.Rotate(given));
        }

        [TestMethod]
        public void demension_3()
        {
            int[,] given = new int[,] {
      {1, 2, 3},
      {4, 5, 6},
      {7, 8, 9}
                };
            int[,] expected = new int[,] {
     {7, 4, 1},
     {8, 5, 2 },
     { 9, 6, 3 }
                };

            CollectionAssert.AreEqual(expected, imageLib.Rotate(given));
        }

        //       [TestMethod]
        //       public void demension_4()
        //       {
        //           int[,] given = new int[,] {
        //               { 5,   1,  9, 11 },
        //               { 2,   4,  8, 10 },
        //               { 13,  3,  6,  7 },
        //               { 15, 14, 12, 16 }
        //           };
        //           int[,] expected = new int[,] {
        //                 {15, 13, 2,  5 },
        //                 {14,  3, 4,  1 },
        //                 {12,  6, 8,  9 },
        //                 {16, 7, 10, 11 }
        //           };

        //           CollectionAssert.AreEqual(expected, imageLib.Rotate(given));
        //       }
    }
}
