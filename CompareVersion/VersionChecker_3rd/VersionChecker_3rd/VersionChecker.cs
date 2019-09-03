using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionChecker_3rd
{
    public class VersionChecker
    {
        public int CompareVersion(string ver1, string ver2)
        {
            string[] versionArray1 = ver1.Split('.');
            string[] versionArray2 = ver2.Split('.');

            int result =0;

            for (int i = 0; i < versionArray1.Length || i < versionArray2.Length; i++)
            {
                result = IntegerStringCompare(GetVersionElement(versionArray1, i), GetVersionElement(versionArray2, i));
                if (result != 0)
                    break;
            }

            return result;
        }

        private static string GetVersionElement(string[] versionArray1, int i)
        {
            return i < versionArray1.Length ? versionArray1[i] : "0";
        }

        private int IntegerStringCompare(string value1, string value2)
        {
            return int.Parse(value1).CompareTo(int.Parse(value2));
        }
    }
}
