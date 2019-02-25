using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrap.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 잘못된파라미터()
        {
            Assert.AreEqual("", Wrapper.DoWrap("", 0));
        }

        [DataRow("word", "word", 4)]
        [DataRow("word", "word", 5)]
        [DataTestMethod]
        public void 한단어(String Expected, String Given, int Length)
        {
            Assert.AreEqual(Expected, Wrapper.DoWrap(Given, Length));
        }

        [DataRow("wor--d", "word", 3)]
        [DataRow("wor--dwo--rd", "wordword", 3)]
        [DataRow("wor--dwo--rdw--ord", "wordwordword", 3)]
        [DataTestMethod]
        public void 한단어_자르기(String Expected, String Given, int Length)
        {
            Assert.AreEqual(Expected, Wrapper.DoWrap(Given, Length));
        }

        [DataRow("word--word", "word word", 4)]
        [DataRow("word--word", "word word", 5)]
        [DataTestMethod]
        public void 두단어(String Expected, String Given, int Length)
        {
            Assert.AreEqual(Expected, Wrapper.DoWrap(Given, Length));
        }

        [DataRow("word w--ordwor--d", "word wordword", 6)]
        [DataTestMethod]
        public void 두단어_뒷단어자르기(String Expected, String Given, int Length)
        {
            Assert.AreEqual(Expected, Wrapper.DoWrap(Given, Length));
        }

        [DataRow("word--word", "word word", 6)]
        [DataTestMethod]
        public void 두단어_뒷단어자르지않기(String Expected, String Given, int Length)
        {
            Assert.AreEqual(Expected, Wrapper.DoWrap(Given, Length));
        }

        [DataRow("word word--word", "word word word", 10)]
        [DataRow("word word--word", "word word word", 12)]
        [DataRow("word--word--word", "word word word", 5)]
        [DataTestMethod]
        public void 세단어(String Expected, String Given, int Length)
        {
            Assert.AreEqual(Expected, Wrapper.DoWrap(Given, Length));
        }

        [DataRow("a lot of--words", "a lot of words", 10)]
        [DataRow("a lot of--words for--a single", "a lot of words for a single", 10)]
        public void 더많은단어(string Expected, string Given, int Length)
        {
            Assert.AreEqual(Expected, Wrapper.DoWrap(Given, Length));
        }

        //[DataRow("test", "test", 7)]
        //[DataRow("hello--world", "hello world", 7)]
        //[DataRow("a lot of--words for--a single--line", "a lot of words for a single line", 10)]
        [DataRow("this--is a--test", "this is a test", 4)]
        //[DataRow("a long--word", "a longword", 6)]
        //[DataRow("areall--ylongw--ord", "areallylongword", 6)]
        [DataTestMethod]
        public void 종합테스트(string Expected, string Given, int Length)
        {
            Assert.AreEqual(Expected, Wrapper.DoWrap(Given, Length));
        }
    }
}
