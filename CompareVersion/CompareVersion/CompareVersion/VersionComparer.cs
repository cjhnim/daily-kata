using System;

namespace CompareVersion
{
    public class VersionComparer
    {
        public VersionComparer()
        {
        }

        public int CompareVersion(string version1, string version2)
        {
            var verData1 = VersionData.Create(version1);
            var verData2 = VersionData.Create(version2);

            int result = CompareIntegerVersion(verData1.front, verData2.front);
            if (0 != result || (string.IsNullOrEmpty(verData1.rear) && string.IsNullOrEmpty(verData2.rear)))
            {
                return result;
            }
            else
            {
                return CompareVersion(verData1.rear, verData2.rear);
            }
        }

        private int CompareIntegerVersion(string version1, string version2)
        {
            int ver1 = string.IsNullOrEmpty(version1) ? 0 : int.Parse(version1);
            int ver2 = string.IsNullOrEmpty(version2) ? 0 : int.Parse(version2);

            if (ver1 == ver2)
                return 0;
            else if (ver1 > ver2)
                return 1;
            else
                return -1;
        }

        public class VersionData
        {
            public string front { set; get;}
            public string rear { set; get; }

            public VersionData()
            {
                front = "";
                rear = "";
            }

            static public VersionData Create(string version)
            {
                int dotPos = version.IndexOf('.');

                if (dotPos == -1)
                {
                    return new VersionData()
                    {
                        front = version
                    };
                }
                else
                {
                    return new VersionData()
                    {
                        front = version.Substring(0, dotPos),
                        rear = version.Substring(dotPos + 1)
                    };
                };
            }
        }
    }
}