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
        public void WorkWrap을_수행하는_함수를_실행할수_있다()
        {
            var wordWrap = new WordWrapper();
            string output = wordWrap.wrap("test", 7);

            Assert.AreEqual("test", output);
        }
    }
}
