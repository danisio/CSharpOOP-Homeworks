namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public static void Main()
        {
            var test = new List<int> { 13, 8, 25, 6, 7 };
            Console.WriteLine("Min = " + test.Min());
            Console.WriteLine("Max = " + test.Max());
            Console.WriteLine("Average = " + test.Average());
            Console.WriteLine("Sum = " + test.Sum());
            Console.WriteLine("Product = " + test.Product());
        }
    }
}
