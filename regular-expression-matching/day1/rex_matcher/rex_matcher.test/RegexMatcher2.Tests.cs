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
            Assert.IsTrue(RegexMatcher.IsMatch(Pattern: "a", Text: "a"));
        }

        [TestMethod]
        public void 두문자는두문자와대응한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch(Pattern: "aa", Text: "aa"));
        }

        [TestMethod]
        public void 세문자는세문자와대응한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch(Pattern: "aaa", Text: "aaa"));
        }

        [TestMethod]
        public void 두문자는한문자와대응하지않는다()
        {
            Assert.IsFalse(RegexMatcher.IsMatch(Pattern: "aa", Text: "a"));
        }

        [TestMethod]
        public void 두문자는한문자와대응하지않는다2()
        {
            Assert.IsFalse(RegexMatcher.IsMatch(Pattern: "aa", Text: "aaa"));
        }

        [TestMethod]
        public void 점은한문자와매칭이다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch(Pattern: ".", Text: "a"));
        }

        [TestMethod]
        public void 점은두문자와매칭하지않는다()
        {
            Assert.IsFalse(RegexMatcher.IsMatch(Pattern: ".", Text: "aa"));
        }

        [TestMethod]
        public void 점은적어도한문자를포함해야한다()
        {
            Assert.IsFalse(RegexMatcher.IsMatch(Pattern: ".", Text: ""));
        }

        [TestMethod]
        public void 점두개는두문자와매칭한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch(Pattern: "..", Text: "aa"));
        }

        [TestMethod]
        public void 점세개는세문자와매칭한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch(Pattern: "...", Text: "aaa"));
        }

        [TestMethod]
        public void 점세개는네문자와매칭하지않는다()
        {
            Assert.IsFalse(RegexMatcher.IsMatch(Pattern: "...", Text: "aaaa"));
        }

        [TestMethod]
        public void 별은공백과대응한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch(Pattern: "a*", Text: ""));
        }

        [TestMethod]
        public void 별은공백과대응하고한글자는한글자와대응한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch(Pattern: "a*b", Text: "b"));
        }

        [TestMethod]
        public void 별은한문자와대응한다()
        {
            Assert.IsTrue(RegexMatcher.IsMatch(Pattern: "a*", Text: "a"));
        }

        [DataTestMethod]
        [DataRow("a", "aa")]
        [DataRow("mis*is*p*.", "mississippi")]
        public void FinalExam_ShouldFalse(string Pattern, string Text)
        {
            Assert.IsFalse(RegexMatcher.IsMatch(Pattern, Text));
        }

        [DataTestMethod]
        [DataRow("a*", "aa")]
        [DataRow(".*", "ab")]
        [DataRow("c*a*b", "aab")]
        public void FinalExam_ShouldTrue(string Pattern, string Text)
        {
            Assert.IsTrue(RegexMatcher.IsMatch(Pattern, Text));
        }

        [DataTestMethod]
        [DataRow("", "")]
        [DataRow("a*a", "aaa")]
        [DataRow("ab*", "a")]
        [DataRow(".*..", "ab")]
        [DataRow("ab*a*c*a", "aaa")]
        [DataRow("aasdf.*asdf.*asdf.*asdf.*s", "aasdfasdfasdfasdfas")]
        public void LeetCode_ShouldTrue(string Pattern, string Text)
        {
            Assert.IsTrue(RegexMatcher.IsMatch(Pattern, Text));
        }

        [DataTestMethod]
        [DataRow("d*", "abcd")]
        [DataRow("a", "")]
        [DataRow(".*c", "ab")]
        public void LeetCode_ShouldFalse(string Pattern, string Text)
        {
            Assert.IsFalse(RegexMatcher.IsMatch(Pattern, Text));
        }
    }
}
