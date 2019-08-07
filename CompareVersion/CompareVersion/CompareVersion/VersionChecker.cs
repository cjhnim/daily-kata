using System;

namespace MyVersion
{
    public class VersionChecker
    {
        public VersionChecker()
        {
        }

        public int CompareVersion(string version1, string version2)
        {
            var versionElements1 = VersionElements.Create(version1);
            var versionElements2 = VersionElements.Create(version2);

            int result = IntegerStringCompare(versionElements1.Major, versionElements2.Major);
            if (0 == result && AreThereMoreElementsToCompare(versionElements1, versionElements2))
                return CompareVersion(versionElements1.Minors, versionElements2.Minors);
            else
                return result;
        }

        private bool AreThereMoreElementsToCompare(VersionElements verData1, VersionElements verData2)
        {
            return !string.IsNullOrEmpty(verData1.Minors) || !string.IsNullOrEmpty(verData2.Minors);
        }

        private int IntegerStringCompare(string valueString1, string valueString2)
        {
            return ParseToInt(valueString1).CompareTo(ParseToInt(valueString2));
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