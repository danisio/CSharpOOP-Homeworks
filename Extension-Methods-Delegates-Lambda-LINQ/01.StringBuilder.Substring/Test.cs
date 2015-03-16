namespace StringBuilder.Substring
{
    using System;
    using System.Text;

    public class Test
    {
        public static void Main()
        {
            StringBuilder test = new StringBuilder("Test the SubstringMethod - OK?");
            var result = test.Substring(27, 2);
            
            Console.WriteLine(result);
        }
    }
}
