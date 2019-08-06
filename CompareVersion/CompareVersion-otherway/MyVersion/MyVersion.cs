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
                int v1, v2;
                try
                {
                    v1 = int.Parse(versionArray1[i]);
                } catch(IndexOutOfRangeException)
                {
                    v1 = 0;
                }

                try
                {
                    v2 = int.Parse(versionArray2[i]);
                } catch(IndexOutOfRangeException)
                {
                    v2 = 0;
                }

                if (v1 == v2)
                    continue;
                else if (v1 > v2)
                    return 1;
                else
                    return -1;
            }

            return 0;
        }
    }
}