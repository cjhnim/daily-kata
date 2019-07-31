using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompareVersion.Tests
{
    [TestClass]
    public class VersionComparerTests
    {
        public void CanInitiate()
        {
            var versionComparer = new VersionComparer();
        }

        [TestMethod]
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
        public void CompreVersion(string version1, string version2, int compareResult)
        {
            Assert.AreEqual(compareResult, new VersionComparer().CompareVersion(version1, version2));
        }
    }
}
