using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorWrap;

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
        public void 공백()
        {
            string output = wordWrapper.DoWrap("", 0);

            Assert.AreEqual("", output);
        }

        [TestMethod]
        public void 한단어_랩필요없음()
        {
            string output = wordWrapper.DoWrap("word", 5);

            Assert.AreEqual("word", output);
        }

        [TestMethod]
        public void 한단어_랩필요없음_단어경계()
        {
            string output = wordWrapper.DoWrap("word", 4);

            Assert.AreEqual("word", output);
        }

        [TestMethod]
        public void 한단어_랩_단어자르기()
        {
            string output = wordWrapper.DoWrap("word", 2);

            Assert.AreEqual("wo\nrd", output);
        }

        [TestMethod]
        public void 한단어_랩필요없음_카운트0()
        {
            string output = wordWrapper.DoWrap("word", 0);

            Assert.AreEqual("word", output);
        }

        [TestMethod]
        public void 두단어_랩_단어경계_뒷단어공백제거()
        {
            string output = wordWrapper.DoWrap("word word", 4);

            Assert.AreEqual("word\nword", output);
        }

        [TestMethod]
        public void 두단어_랩_공백경계_앞단어공백제거()
        {
            string output = wordWrapper.DoWrap("word word", 5);

            Assert.AreEqual("word\nword", output);
        }

        [TestMethod]
        public void 두단어_두번째단어_랩_단어중()
        {
            string output = wordWrapper.DoWrap("word word", 7);

            Assert.AreEqual("word wo\nrd", output);
        }

        [TestMethod]
        public void 두단어_랩없음()
        {
            string output = wordWrapper.DoWrap("word word", 9);

            Assert.AreEqual("word word", output);
        }

        [TestMethod]
        public void 세단어_두번째단어랩_두번째단어경계()
        {
            string output = wordWrapper.DoWrap("word word word", 9);

            Assert.AreEqual("word word\nword", output);
        }

        [DataRow("word\nword\nword", "word word word", 4)]
        [DataRow("word\nword\nword", "word word word", 5)]
        [DataRow("word w\nord wo\nrd", "word word word", 6)]
        [DataRow("word wo\nrd word", "word word word", 7)]
        [DataTestMethod]
        public void 세단어_첫번째단어랩_첫번째단어끝(string Expected, string Actual, int Count)
        {
            string output = wordWrapper.DoWrap(Actual, Count);

            Assert.AreEqual(Expected, output);
        }
        //[DataRow("test", "test", 7)]
        //[DataRow("hello\nworld", "hello world", 7)]
        //[DataRow("a lot of\nwords for--a single--line", "a lot of words for a single line", 10)]
        //[DataRow("this\nis a\ntest", "this is a test", 4)]
        //[DataRow("a long\nword", "a longword", 6)]
        //[DataRow("areall\nylongw\nord", "areallylongword", 6)]
        //[DataTestMethod]
        //public void 종합테스트(string Expected, string Actual, int Count)
        //{
        //    string output = wordWrapper.DoWrap(Actual, Count);

        //    Assert.AreEqual(Expected, output);
        //}
    }
}
