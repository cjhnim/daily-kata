using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordWrap;

namespace WordWrap.Test
{
    [TestClass]
    public class WordWrapTest
    {
        [TestMethod]
        public void 예외처리()
        {
            Assert.AreEqual("", Wrapper.DoWrap("", 0));
        }

        [DataRow("word", 4, "word")]
        [DataRow("word", 5, "word")]
        [DataRow("word", 6, "word")]
        [DataTestMethod]
        public void 한단어_랩크키가단어보다크면_랩하지않는다(string given, int givenLimit, string expected)
        {
            Assert.AreEqual(expected, Wrapper.DoWrap(given, givenLimit));
        }

        [DataRow("word", 1, "w--o--r--d")]
        [DataRow("word", 2, "wo--rd")]
        [DataRow("word", 3, "wor--d")]
        [DataTestMethod]
        public void 한단어_랩크키가단어보다작으면_랩한다(string given, int givenLimit, string expected)
        {
            Assert.AreEqual(expected, Wrapper.DoWrap(given, givenLimit));
        }

        [DataRow("word word", 4, "word--word")]
        [DataTestMethod]
        public void 두단어_공백을기준으로_뒷부분을_트림하여_랩한다(string given, int givenLimit, string expected)
        {
            Assert.AreEqual(expected, Wrapper.DoWrap(given, givenLimit));
        }

        [DataRow("word word", 5, "word--word")]
        [DataRow("word word", 7, "word--word")]
        [DataTestMethod]
        public void 두단어_공백을찾아_랩한다(string given, int givenLimit, string expected)
        {
            Assert.AreEqual(expected, Wrapper.DoWrap(given, givenLimit));
        }

        [DataRow("word wordword", 7, "word wo--rdword")]
        [DataRow("word word word", 7, "word--word--word")]
        [DataRow("word is a word", 5, "word--is a--word")]
        [DataTestMethod]
        public void 두단어_뒷부분의길이가_랩크기보다크다면_뒷부분을_랩한다(string given, int givenLimit, string expected)
        {
            Assert.AreEqual(expected, Wrapper.DoWrap(given, givenLimit));
        }

        [DataRow("word word word", 5, "word--word--word")]
        [DataTestMethod]
        public void 여러단어_여러단어를랩할수있다(string given, int givenLimit, string expected)
        {
            Assert.AreEqual(expected, Wrapper.DoWrap(given, givenLimit));
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
