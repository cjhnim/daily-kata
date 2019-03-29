using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordWrap;

namespace WordWrapTest
{
    [TestClass]
    public class WrapperTest
    {
        [TestMethod]
        public void 예외처리()
        {
            Assert.AreEqual("", Wrapper.Wrap(null, 0));
        }

        [TestMethod]
        public void 한단어()
        {
            Assert.AreEqual("word", Wrapper.Wrap("word", 4));
        }

        [TestMethod]
        public void 두단어_공백을찾아랩하기()
        {
            Assert.AreEqual("word--word", Wrapper.Wrap("word word", 4));
        }

        [TestMethod]
        public void 두단어_문장중간을랩하기()
        {
            Assert.AreEqual("word wo--rdword", Wrapper.Wrap("word wordword", 7));
        }

        [TestMethod]
        public void 세번랩하기()
        {
            Assert.AreEqual("word--word--word", Wrapper.Wrap("word word word", 4));
        }

        [TestMethod]
        public void 뒷부분에_여러단어가있을때_앞에_한단어만_길이구하기()
        {
            Assert.AreEqual("word--word--word", Wrapper.Wrap("word word word", 5));
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
            Assert.AreEqual(Expected, Wrapper.Wrap(Given, Length));
        }
    }
}
