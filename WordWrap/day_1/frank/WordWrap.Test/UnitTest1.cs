using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrap.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 클래스의_인스턴스를_생성할_수_있다()
        {
            var wordWrap = new WordWrapper();
        }

        [TestMethod]
        public void 한단어를_WordWrap_할_수_있다()
        {
            var wordWrap = new WordWrapper();
            string output = wordWrap.wrap("Hello", 7);

            Assert.AreEqual("Hello", output);
        }

        [TestMethod]
        public void 한단어를_WordWrap_할_수_있다2()
        {
            var wordWrap = new WordWrapper();
            string output = wordWrap.wrap("Hello ", 7);

            Assert.AreEqual("Hello ", output);
        }
    }
}
