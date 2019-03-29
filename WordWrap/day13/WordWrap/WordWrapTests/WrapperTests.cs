using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordWrap;

namespace WordWrapTests
{
    [TestClass]
    public class WrapperTests
    {
        [TestMethod]
        public void 예외처리()
        {
            Assert.AreEqual("", Wrapper.wrap("", 0));
        }

        [TestMethod]
        public void Wrap필요없음()
        {
            Assert.AreEqual("word", Wrapper.wrap("word", 5));
        }

        [TestMethod]
        public void 공백기준Wrap()
        {
            Assert.AreEqual("word--word", Wrapper.wrap("word word", 5));
        }

        [TestMethod]
        public void 단어잘라서Wrap()
        {
            Assert.AreEqual("a long--word", Wrapper.wrap("a longword", 6));
        }

        [TestMethod]
        public void 여러단어Wrap()
        {
            Assert.AreEqual("word--word--word", Wrapper.wrap("word word word", 5));
        }
    }
}
