namespace P_03_GenericList
{
    using System;

    [AttributeUsage(
        AttributeTargets.Class|
        AttributeTargets.Enum|
        AttributeTargets.Struct|
        AttributeTargets.Interface|
        AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        public VersionAttribute(int majorVersion, int minorVersion)
        {
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
        }

        public int MajorVersion { get; private set; }

        public int MinorVersion { get; private set; }

        public override string ToString()
        {
            string result = string.Format(
                "Version {0}.{1}",
                this.MajorVersion,
                this.MinorVersion.ToString("X2"));

            return result;
        }
    }
}