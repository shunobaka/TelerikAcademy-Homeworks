namespace Attributes
{
    using System;
    using System.Reflection;

    [Version("2.11")]
    class TestAttribute
    {
        static void Main()
        {
            var version = typeof(TestAttribute).GetCustomAttributes<VersionAttribute>();

            foreach (var ver in version)
            {
                Console.WriteLine(ver.Version);
            }
        }
    }
}
