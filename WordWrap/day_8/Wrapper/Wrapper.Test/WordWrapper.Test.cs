using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wrapper.Test
{
    [TestClass]
    public class UnitTest1
    {
        WordWrapper wrapper;

        [TestInitialize]
        public void Setup()
        {
            wrapper = new WordWrapper();
        }

        [TestMethod]
        public void 예외처리()
        {
            string wrapped = wrapper.Do("", 0);
            Assert.AreEqual("", wrapped);
        }

        [DataRow("word", "word", 6)]
        [DataRow("word", "word", 5)]
        [DataRow("word", "word", 4)]
        [DataRow("wor--d", "word", 3)]
        [DataTestMethod]
        public void 한단어(string Expected, string Given, int Length)
        {
            Assert.AreEqual(Expected, wrapper.Do(Given, Length));
        }

        [DataRow("word--word", "word word", 5)]
        [DataRow("word--word", "word word", 7)]
        [DataTestMethod]
        public void 두단어(string Expected, string Given, int Length)
        {
            Assert.AreEqual(Expected, wrapper.Do(Given, Length));
        }

        [DataRow("word word--word", "word word word", 10)]
        [DataRow("word word--word", "word word word", 12)]
        [DataRow("word--word--word", "word word word", 5)]
        [DataTestMethod]
        public void 세단어(string Expected, string Given, int Length)
        {
            Assert.AreEqual(Expected, wrapper.Do(Given, Length));
        }

        [DataRow("a lot of--words for--a single--line", "a lot of words for a single line", 10)]
        [DataTestMethod]
        public void 종합테스트(string Expected, string Given, int Length)
        {
            Assert.AreEqual(Expected, wrapper.Do(Given, Length));
        }

        //[DataRow("test", "test", 7)]
        //[DataRow("hello--world", "hello world", 7)]
        //[DataRow("a lot of--words for--a single--line", "a lot of words for a single line", 10)]
        //[DataRow("this--is a--test", "this is a test", 4)]
        //[DataRow("a long--word", "a longword", 6)]
        //[DataRow("areall--ylongw--ord", "areallylongword", 6)]
        //[DataTestMethod]
        //public void 종합테스트(string Expected, string Given, int Length)
        //{
        //    Assert.AreEqual(Expected, wrapper.Do(Given, Length));
        //}
    }
}
