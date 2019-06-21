using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rex_matcher.test
{
    [TestClass]
    public class RegexMatcher2
    {


        [TestMethod]
        public void 한문자는한문자와대응한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch("a", "a"));
        }

        [TestMethod]
        public void 두문자는두문자와대응한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch("aa", "aa"));
        }

        [TestMethod]
        public void 세문자는세문자와대응한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch("aaa", "aaa"));
        }

        [TestMethod]
        public void 두문자는한문자와대응하지않는다()
        {
            Assert.IsFalse(RegexMatcher.IsMatch("a", "aa"));
        }

        [TestMethod]
        public void 두문자는한문자와대응하지않는다2()
        {
            Assert.IsFalse(RegexMatcher.IsMatch("aaa", "aa"));
        }

        [TestMethod]
        public void 점은한문자와매칭이다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch("a", "."));
        }

        [TestMethod]
        public void 점은두문자와매칭하지않는다()
        {
            Assert.IsFalse(RegexMatcher.IsMatch("aa", "."));
        }

        [TestMethod]
        public void 점은적어도한문자를포함해야한다()
        {
            Assert.IsFalse(RegexMatcher.IsMatch("", "."));
        }

        [TestMethod]
        public void 점두개는두문자와매칭한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch("aa", ".."));
        }

        [TestMethod]
        public void 점세개는세문자와매칭한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch("aaa", "..."));
        }

        [TestMethod]
        public void 점세개는네문자와매칭하지않는다()
        {
            Assert.IsFalse(RegexMatcher.IsMatch("aaaa", "..."));
        }

        [TestMethod]
        public void 별은공백과대응한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch("", "a*"));
        }

        [TestMethod]
        public void 별은공백과대응하고한글자는한글자와대응한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch("b", "a*b"));
        }

        [TestMethod]
        public void 별은한문자와대응한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch("a", "a*"));
        }

        [DataTestMethod]
        [DataRow("aa", "a*", true)]
        [DataRow("ab", ".*", true)]
        [DataRow("aab", "c*a*b", true)]
        [DataRow("aa", "a", false)]
        [DataRow("mississippi", "mis*is*p*.", false)]
        public void LeeCodeDemoTests(string Text, string Pattern, bool ExpectedResult)
        {
            Assert.AreEqual(ExpectedResult, RegexMatcher.IsMatch(Text, Pattern));
        }

        [DataTestMethod]
        [DataRow("", "", true)]
        [DataRow("aaa", "a*a", true)]
        [DataRow("a", "ab*", true)]
        [DataRow("ab", ".*..", true)]
        [DataRow("aaa", "ab*a*c*a", true)]
        [DataRow("aasdfasdfasdfasdfas", "aasdf.*asdf.*asdf.*asdf.*s", true)]
        [DataRow("abcd", "d*", false)]
        [DataRow("", "a", false)]
        [DataRow("ab", ".*c", false)]
        public void LeetCodeTestCases(string Text, string Pattern, bool ExpectedResult)
        {
            Assert.AreEqual(ExpectedResult, RegexMatcher.IsMatch(Text, Pattern));
        }
    }
}
