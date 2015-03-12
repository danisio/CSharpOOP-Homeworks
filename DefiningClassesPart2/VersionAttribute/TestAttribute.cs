namespace VersionAttribute
{
    using System;

    [Version("2.11")]
    public class TestAttribute
    {
        public static void Main()
        {
            Type type = typeof(VersionAttribute);
            
            object[] allAttributes = typeof(TestAttribute).GetCustomAttributes(false);

            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("Version Attribute --> " + attr);
            }
        }
    }
}
