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
            Assert.AreEqual("", wrapper.Do("", 0));
        }

        [DataRow("word", "word", 5)]
        [DataTestMethod]
        public void 한단어(string Expected, string Actual, int ActualLen)
        {
            Assert.AreEqual(Expected, wrapper.Do(Actual, ActualLen));
        }

        [DataRow("word--word", "word word", 5)]
        [DataRow("word--word--word", "word word word", 5)]
        [DataTestMethod]
        public void 딱떨어짐(string Expected, string Actual, int ActualLen)
        {
            Assert.AreEqual(Expected, wrapper.Do(Actual, ActualLen));
        }

        //[DataRow("word word--word", "word word word", 10)]
        //[DataTestMethod]
        //public void 세단어(string Expected, string Actual, int ActualLen)
        //{
        //    Assert.AreEqual(Expected, wrapper.Do(Actual, ActualLen));
        //}
    }
}
