using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VersionChecker.Tests
{
    [TestClass]
    public class VersionCheckerTests
    {
        [TestMethod]
        public void CanInstantiate()
        {
            new VersionChecker_3rd.VersionChecker();
        }

        [TestMethod]
        [DataRow("1","1", 0, DisplayName = "한자리수비교")]
        [DataRow("2","1", 1, DisplayName = "한자리수_앞이크다")]
        [DataRow("1","2", -1, DisplayName = "한자리수_뒤가크다")]
        [DataRow("123","1", 1, DisplayName = "한자리수_앞이크다2")]
        [DataRow("1", "01", 0, DisplayName = "한자리수_같다")]
        public void 한자리수비교하는테스트들(string ver1, string ver2, int expectResult)
        {
            int result = new VersionChecker_3rd.VersionChecker().CompareVersion(ver1, ver2);
            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        [DataRow("1.1", "1.1", 0, DisplayName = "두자리수비교")]
        [DataRow("1.2", "1.1", 1, DisplayName = "두자리수비교_앞이더크다")]
        [DataRow("1.1.3", "1.1.1", 1, DisplayName = "세자리수비교_앞이더크다")]
        [DataRow("1.1.1.4", "1.1.1", 1, DisplayName = "네자리수비교_앞이더크다")]
        public void 두자리수이상비교하는테스트들(string ver1, string ver2, int expectResult)
        {
            int result = new VersionChecker_3rd.VersionChecker().CompareVersion(ver1, ver2);
            Assert.AreEqual(expectResult, result);
        }
    }
}
