using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrap.Test
{
    [TestClass]
    public class Wrapper_Test
    {
        [TestMethod]
        public void 예외처리()
        {
            Assert.AreEqual("", Wrapper.DoWrap("", 0));
        }

        [DataRow("word", "word", 5)]
        [DataTestMethod]
        public void 한단어(string Expected, string Given, int Length)
        {
            Assert.AreEqual(Expected, Wrapper.DoWrap(Given, Length));
        }

        [DataRow("word--word", "word word", 4)]
        [DataRow("word--word", "word word", 5)]
        [DataRow("word--word", "word word", 7)]
        [DataRow("word--word", "word word", 7)]
        [DataTestMethod]
        public void 두단어(string Expected, string Given, int Length)
        {
            Assert.AreEqual(Expected, Wrapper.DoWrap(Given, Length));
        }

        [DataRow("word--word--word", "word word word", 5)]
        [DataRow("word--word--word", "word word word", 7)]
        [DataTestMethod]
        public void 세단어(string Expected, string Given, int Length)
        {
            Assert.AreEqual(Expected, Wrapper.DoWrap(Given, Length));
        }

        //[DataRow(8, "longword")]
        //[DataTestMethod]
        //public void 한단어길이구하기_공백없음(int Expected, string Given)
        //{
        //    Assert.AreEqual(8, Wrapper.WordLength(Given));
        //}

        //[DataRow(8, "longword ddd")]
        //[DataTestMethod]
        //public void 한단어길이구하기_공백있음(int Expected, string Given)
        //{
        //    Assert.AreEqual(8, Wrapper.WordLength(Given));
        //}

        [DataRow("a long--word", "a longword", 6)]
        [DataTestMethod]
        public void 한단어자르기(string Expected, string Given, int Length)
        {
            Assert.AreEqual(Expected, Wrapper.DoWrap(Given, Length));
        }


        [DataRow("test", "test", 7)]
        [DataRow("hello--world", "hello world", 7)]
        [DataRow("a lot of--words for--a single--line", "a lot of words for a single line", 10)]
        [DataRow("this--is a--test", "this is a test", 4)]
        [DataRow("areall--ylongw--ord", "areallylongword", 6)]
        [DataTestMethod]
        public void 종합테스트(string Expected, string Given, int Length)
        {
            Assert.AreEqual(Expected, Wrapper.DoWrap(Given, Length));
        }

    }
}
