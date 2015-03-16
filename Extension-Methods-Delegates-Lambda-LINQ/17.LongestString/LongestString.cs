/* Problem 17. Longest string
Write a program to return the string with maximum length from an array of strings.
Use LINQ.
 */
namespace LongestString
{
    using System;
    using System.Linq;

    public class LongestString
    {
        public static void Main()
        {
            string[] longestString = new string[] { "Problem", " 17.", " Longest", " string", " Write", "a ", "program", " to", " return ", "the ", "string ", "with ", "maximum ", "length ", "from ", "an ", "array ", "of ", "strings" };

            var result = longestString.OrderByDescending(word => word.Length).First();

            Console.WriteLine("The result -->{0} = {1} symbols", result, result.Length);
        }
    }
}
