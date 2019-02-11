using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrap.Test
{
    [TestClass]
    public class UnitTest1
    {
        WordWrapper wordWrapper;
        [TestInitialize]
        public void setUp()
        {
            wordWrapper = new WordWrapper();
        }

        [TestMethod]
        public void 한단어를_wrap_할_수_있다()
        {
            string output = wordWrapper.stringWrap("test", 7);

            Assert.AreEqual("test", output);
        }

        [TestMethod]
        public void 두단어를_wrap_할_수_있다()
        {
            string output = wordWrapper.stringWrap("hello world", 7);

            Assert.AreEqual("hello\nworld", output);
        }
    }
}
