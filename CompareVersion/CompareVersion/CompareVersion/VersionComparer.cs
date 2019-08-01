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
            var versionElements1 = VersionElements.Create(version1);
            var versionElements2 = VersionElements.Create(version2);

            int result = IntegerCompare(versionElements1.Major, versionElements2.Major);
            if (0 == result && AreThereMoreElementsToCompare(versionElements1, versionElements2))
                return CompareVersion(versionElements1.Minors, versionElements2.Minors);
            else
                return result;
        }

        private bool AreThereMoreElementsToCompare(VersionElements verData1, VersionElements verData2)
        {
            return !string.IsNullOrEmpty(verData1.Minors) || !string.IsNullOrEmpty(verData2.Minors);
        }

        private int IntegerCompare(string valueString1, string valueString2)
        {
            int ver1 = ParseToInt(valueString1);
            int ver2 = ParseToInt(valueString2);

            if (ver1 == ver2)
                return 0;
            else if (ver1 > ver2)
                return 1;
            else
                return -1;
        }

        private int ParseToInt(string valueString)
        {
            return string.IsNullOrEmpty(valueString) ? 0 : int.Parse(valueString);
        }

        public class VersionElements
        {
            public string Major { set; get; } = "";
            public string Minors { set; get; } = "";

            public VersionElements()
            {
            }

            static public VersionElements Create(string version)
            {
                int versionSeparatorIndex = version.IndexOf('.');

                if (versionSeparatorIndex == -1)
                {
                    return new VersionElements()
                    {
                        Major = version
                    };
                }
                else
                {
                    return new VersionElements()
                    {
                        Major = version.Substring(0, versionSeparatorIndex),
                        Minors = version.Substring(versionSeparatorIndex + 1)
                    };
                };
            }
        }
    }
}