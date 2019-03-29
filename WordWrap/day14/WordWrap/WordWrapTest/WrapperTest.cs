using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordWrap;

namespace WordWrapTest
{
    [TestClass]
    public class WrapperTest
    {
        [DataRow("", "", 0)]
        [DataTestMethod]
        public void 예외처리(string Expected, string Given, int GivenLimit)
        {
            Assert.AreEqual(Expected, Wrapper.Wrap(Given, GivenLimit));
        }

        [DataRow("word", "word", 4)]
        [DataRow("word", "word", 5)]
        [DataTestMethod]
        public void 텍스트의길이가한계값보다같거나작으면랩하지않는다(string Expected, string Given, int GivenLimit)
        {
            Assert.AreEqual(Expected, Wrapper.Wrap(Given, GivenLimit));
        }

        [TestMethod]
        public void 공백을기준으로랩한다()
        {
            Assert.AreEqual("word--word", Wrapper.Wrap("word word", 4));
        }

        [TestMethod]
        public void 단어가길경우공백이아닌단어를랩한다()
        {
            Assert.AreEqual("wordword--word", Wrapper.Wrap("wordwordword", 8));
        }

        [TestMethod]
        public void 뒷단어가한계값보다크다면공백이아닌한계값을기준으로자른다()
        {
            Assert.AreEqual("word wo--rdword", Wrapper.Wrap("word wordword", 7));
        }

        [TestMethod]
        public void 여러단어()
        {
            Assert.AreEqual("word--word--word", Wrapper.Wrap("word word word", 4));
        }

        [TestMethod]
        public void 뒷문장에공백이포함된경우앞단어길이만계산한다()
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
