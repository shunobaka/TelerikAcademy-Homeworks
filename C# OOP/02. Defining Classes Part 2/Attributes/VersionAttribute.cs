namespace Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Interface |
        AttributeTargets.Class | AttributeTargets.Enum |
        AttributeTargets.Method, AllowMultiple = true)]
    public class VersionAttribute : System.Attribute
    {
        public string Version { get; set; }

        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }
}
