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
    }
}
