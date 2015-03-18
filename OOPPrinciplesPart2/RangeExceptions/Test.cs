namespace RangeExceptions
{
    using System;

    public class Test
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter an integer [1..100]:");
                int number = int.Parse(Console.ReadLine());

                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>(1, 100);
                }
                else
                {
                    Console.WriteLine("Good job!");
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                DateTime date = DateTime.Now;
                if (date.Year < 1980 || date.Year > 2013)
                {
                    throw new InvalidRangeException<DateTime>(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
