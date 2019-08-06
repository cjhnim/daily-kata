using System;

namespace MyVersion
{
    public class MyVersion
    {
        public static int CompareVersion(string version1, string version2)
        {
            string[] versionArray1 = version1.Split('.');
            string[] versionArray2 = version2.Split('.');

            for (int i = 0; i < versionArray1.Length || i < versionArray2.Length; i++)
            {
                int value1 = 0, value2 = 0;
                int.TryParse(GetString(versionArray1, i), out value1) ;
                int.TryParse(GetString(versionArray2, i), out value2) ;

                if (value1 > value2)
                    return 1;
                else if( value1 < value2)
                    return -1;
            }

            return 0;
        }

        static string GetString(string[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (System.IndexOutOfRangeException e)  // CS0168
            {
                return "";
            }
        }
    }
}