using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrap.Test
{
    [TestClass]
    public class WordwrapTest
    {
        [DataRow("", 0, "")]
        [DataRow("word", 0, "word")]
        [DataTestMethod]
        public void 공백예외처리(string given, int limit, string expected)
        {
            Assert.AreEqual(expected, Wrapper.DoWrap(given, limit));
        }

        [DataRow("word", 4, "word")]
        [DataRow("word", 5, "word")]
        [DataRow("word", 6, "word")]
        [DataTestMethod]
        public void 한단어처리(string given, int limit, string expected)
        {
            Assert.AreEqual(expected, Wrapper.DoWrap(given, limit));
        }

        [DataRow("word", 2, "wo--rd")]
        [DataRow("word wordwor", 6, "word w--ordwor")]
        [DataTestMethod]
        public void 랩크기가_단어보다_작으면_랩한다(string given, int limit, string expected)
        {
            Assert.AreEqual(expected, Wrapper.DoWrap(given, limit));
        }

        [DataRow("word word", 5, "word--word")]
        [DataRow("word word", 4, "word--word")]
        [DataTestMethod]
        public void 두단어인경우_공백기준으로_랩한다(string given, int limit, string expected)
        {
            Assert.AreEqual(expected, Wrapper.DoWrap(given, limit));
        }

        [DataRow("word word word", 5, "word--word--word")]
        [DataTestMethod]
        public void 세단어도_동일한_규칙이_적용되어야한다(string given, int limit, string expected)
        {
            Assert.AreEqual(expected, Wrapper.DoWrap(given, limit));
        }

        [DataRow("test", "test", 7)]
        [DataRow("hello--world", "hello world", 7)]
        [DataRow("a lot of--words for--a single--line", "a lot of words for a single line", 10)]
        [DataRow("this--is a--test", "this is a test", 4)]
        [DataRow("a long--word", "a longword", 6)]
        [DataRow("areall--ylongw--ord", "areallylongword", 6)]
        [DataTestMethod]
        public void 종합테스트(string Expected, string Given, int Length)
        {
            Assert.AreEqual(Expected, Wrapper.DoWrap(Given, Length));
        }

    }
}
