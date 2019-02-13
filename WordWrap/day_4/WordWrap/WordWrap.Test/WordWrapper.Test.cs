using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrap.Test
{
    [TestClass]
    public class WordWrapperTest
    {
        WordWrapper wordWrapper;

        [TestInitialize]
        public void Setup()
        {
            wordWrapper = new WordWrapper();
        }

        [TestMethod]
        public void 공백을_넣으면_랩할필요가없다()
        {
            Assert.AreEqual("", wordWrapper.DoWrap("", 0));
        }

        [TestMethod]
        public void 스트링을_넣었으나_랩할것이없다()
        {
            Assert.AreEqual("test", wordWrapper.DoWrap("test", 7));
        }

        [TestMethod]
        public void 스트링을_넣었으나_랩할것이없다_케이스2()
        {
            Assert.AreEqual("test", wordWrapper.DoWrap("test", 4));
        }

        //[TestMethod]
        //public void 스트링을_넣었으나_랩할것이없다_케이스3()
        //{
        //    Assert.AreEqual("tes\nt", wordWrapper.DoWrap("test", 3));
        //}

        [TestMethod]
        public void 두번째단어에_걸칠경우_랩을한다()
        {
            Assert.AreEqual("hello\nworld", wordWrapper.DoWrap("hello world", 12));
        }
    }
}
