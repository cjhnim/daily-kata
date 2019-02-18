using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrap.Test
{
    [TestClass]
    public class UnitTest1
    {
        WordWrapper wordWrapper;

        [TestInitialize]
        public void Setup()
        {
            wordWrapper = new WordWrapper();
        }
        [TestMethod]
        public void 공백이나_0값을_입력하면_wrap할필요가없다()
        {
            string output = wordWrapper.DoWrap("", 0);

            Assert.AreEqual("", output);
        }

        [DataRow("word", "word", 4)]
        [DataRow("word", "word", 5)]
        [DataTestMethod]
        [TestMethod]
        public void 랩할것이없다(string Expected, string Actual, int col)
        {
            string output = wordWrapper.DoWrap(Actual, col);

            Assert.AreEqual(Expected, output);
        }

        [DataRow("w--ord", "word", 1)]
        [DataRow("wo--rd", "word", 2)]
        [DataRow("wor--d", "word", 3)]
        [DataTestMethod]
        [TestMethod]
        public void 한단어_랩(string Expected, string Actual, int col)
        {
            string output = wordWrapper.DoWrap(Actual, col);

            Assert.AreEqual(Expected, output);
        }

        [DataRow("word--word", "word word", 4)]
        [DataRow("word--word", "word word", 5)]
        [DataTestMethod]
        [TestMethod]
        public void 두단어_랩(string Expected, string Actual, int col)
        {
            string output = wordWrapper.DoWrap(Actual, col);

            Assert.AreEqual(Expected, output);
        }

        [DataRow("word--word", "word word", 6)]
        [DataTestMethod]
        [TestMethod]
        public void 가능하면_단어를자르지않고_랩한다(string Expected, string Actual, int col)
        {
            string output = wordWrapper.DoWrap(Actual, col);

            Assert.AreEqual(Expected, output);
        }
    }
}
