namespace Bitarray
{
    using System;

    public class Test
    {
        public static void Main()
        {
            // add some test instances
            var testBit = new BitArray64(234567);
            var newTest = new BitArray64(9999999999999999);

            // print them
            Console.WriteLine(testBit);
            Console.WriteLine(newTest);

            // test the methods
            Console.WriteLine(testBit == newTest);
            Console.WriteLine(testBit != newTest);
            Console.WriteLine(testBit.Equals(newTest));

            Console.WriteLine();
            Console.WriteLine(testBit.GetHashCode());
            Console.WriteLine(newTest.GetHashCode());
        }
    }
}
