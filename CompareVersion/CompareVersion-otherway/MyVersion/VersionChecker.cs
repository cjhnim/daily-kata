using System;

namespace MyVersion
{
    public class VersionChecker
    {
        public int CompareVersion(string version1, string version2)
        {
            string[] versionArray1 = version1.Split('.');
            string[] versionArray2 = version2.Split('.');

            for (int i = 0; i < versionArray1.Length || i < versionArray2.Length; i++)
            {
                int value1 = 0, value2 = 0;
                int.TryParse(GetStringByIndex(versionArray1, i), out value1) ;
                int.TryParse(GetStringByIndex(versionArray2, i), out value2) ;

                int result = value1.CompareTo(value2);
                if (result != 0)
                    return result;
            }

            return 0;
        }

        string GetStringByIndex(string[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (System.IndexOutOfRangeException)  // CS0168
            {
                return "";
            }
        }
    }
}