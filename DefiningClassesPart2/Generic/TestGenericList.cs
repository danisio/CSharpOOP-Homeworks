namespace Generic
{
    using System;

    public class TestGenericList
    {
        public static void Main()
        {
            // add an instance of GenericList and add some elements
            GenericList<int> testInt = new GenericList<int>(4);
            testInt.Add(300);
            testInt.Add(200);
            testInt.Add(100);

            // print the initial list, min and max elements, count and capacity
            Console.WriteLine("Initial List: \n" + testInt.ToString());
            int min = testInt.Min();
            int max = testInt.Max();
            Console.WriteLine("Min = {0} and Max = {1}", min, max);
            Console.WriteLine("Count = {0}\nCapacity = {1}", testInt.Count, testInt.Capacity);

            // test method IndexOf()
            int index = testInt.IndexOf(100);
            Console.WriteLine("Index of number 100 = {0}", index);
            
            // test method InsertAt()
            testInt.InsertAt(5, 1);
            Console.WriteLine("\nAfter inserting: \n" + testInt.ToString());
           
            // test method RemoveAt()
            testInt.RemoveAt(1);
            Console.WriteLine("After removing: \n" + testInt.ToString());

            // add 2 more elements, print the list, count and capacity(the list is resized)
            testInt.Add(400);
            testInt.Add(500);
            Console.WriteLine("Added 2 more elements: \n" + testInt.ToString());
            Console.WriteLine("Count = {0}\nCapacity = {1}", testInt.Count, testInt.Capacity);

            // test method Clear()
            testInt.Clear();
            Console.WriteLine("\nClear the list --> Count = " + testInt.Count);
          
            // add new instance of GenericList
            GenericList<string> testString = new GenericList<string>(5);
            testString.Add("tested");
            testString.Add("testing");
            testString.Add("test");

            // test methods Min() and Max()
            string min2 = testString.Min();
            string max2 = testString.Max();

            Console.WriteLine("\nInitial list:\n" + testString.ToString());
            Console.WriteLine("Min = {0}; Max = {1}", min2, max2);
        }
    }
}
