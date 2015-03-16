namespace DivisibleBy7And3
{
    using System;
    using System.Linq;

    public class Test
    {
        public static void Main()
        {
            int[] numbers = new int[] { 2, 63, 8, 42, 21, 4, 78, 30, 3, 56, 7, 4, 234 };

            var resultLambda = numbers.Where(x => x % 21 == 0);

            Console.WriteLine("Lambda:");
            foreach (var num in resultLambda)
            {
                Console.WriteLine(num);
            }

            var resultLinq =
                from num in numbers
                where num % 21 == 0
                select num;

            Console.WriteLine("\nLINQ");
            foreach (var num in resultLambda)
            {
                Console.WriteLine(num);
            }
        }
    }
}
