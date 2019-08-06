using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompareVersion_otherway
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("1", "1", 0, DisplayName = "한자리같은값")]
        [DataRow("2", "1", 1, DisplayName = "한자리큰값")]
        [DataRow("1", "2", -1, DisplayName = "한자리작은값")]
        [DataRow("1.1", "1.1", 0, DisplayName = "두자리같은값")]
        [DataRow("1.2", "1.1", 1, DisplayName = "두자리큰값")]
        [DataRow("1.1", "1.2", -1, DisplayName = "두자리작은값")]
        [DataRow("1.1.0", "1.1", 0, DisplayName = "두자리와세자리같은값")]
        [DataRow("1", "1", 0, DisplayName = "SameVersion")]
        [DataRow("2", "1", 1, DisplayName = "GreaterVersion")]
        [DataRow("1", "2", -1, DisplayName = "LowerVersion")]
        [DataRow("0.1", "1.1", -1, DisplayName = "LowerVersionOfOneDot")]
        [DataRow("0.2", "0.1", 1, DisplayName = "GreaterVersionOfOneDot")]
        [DataRow("1.0.1", "1", 1, DisplayName = "GreaterVersionOfTwoDot")]
        [DataRow("7.5.2.4", "7.5.3", -1, DisplayName = "MultiDot")]
        [DataRow("1.01", "1.001", 0, DisplayName = "IgnoreZero")]
        [DataRow("1.0", "1.0.0", 0, DisplayName = "IgnoreTwoDot")]
        [DataRow("1.1", "1.10", -1, DisplayName = "NoIgnoreZero")]
        public void TestMethod1(string Version1, string Version2, int ExpectResult)
        {
            Assert.AreEqual(ExpectResult, MyVersion.MyVersion.CompareVersion(Version1, Version2));
        }
    }
}
