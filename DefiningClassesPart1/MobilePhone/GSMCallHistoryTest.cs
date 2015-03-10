namespace GSM
{
    using System;
    using System.Globalization;
    using System.Linq;

    public class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            // add new instance
            GSM testPhone = new GSM("Vibe Shot", "Lenovo");

            // add some calls
            testPhone.AddCalls(new Call(DateTime.Now.Subtract(new TimeSpan(24, 0, 0)), "+35912345678", new TimeSpan(0, 20, 15)));
            testPhone.AddCalls(new Call(DateTime.Now.AddDays(50), "+35912345679", new TimeSpan(0, 10, 39)));
            testPhone.AddCalls(new Call(DateTime.Now, "+35912345677", new TimeSpan(1, 05, 10)));

            // print calls in CallHistory and the sum of all calls
            Console.WriteLine("The \"{0}\" Call History:", testPhone.Model);
            foreach (var calls in testPhone.CallsHistory)
            {
                Console.WriteLine(calls.ToString());
                Console.WriteLine(new string('-', 20));
            }

            decimal sumOfAllCalls = testPhone.CallPrice(0.37M);
            Console.WriteLine("Total price of All calls: " + sumOfAllCalls.ToString("C2"));

            // find and remove the call with longest duration
            Call longestCall = testPhone.CallsHistory.OrderByDescending(x => x.Duration).FirstOrDefault();
            testPhone.RemoveCall(longestCall);

            // print calls in CallHistory and the sum of all calls AFTER deleting
            Console.WriteLine("\nThe \"{0}\" Call History:", testPhone.Model);
            foreach (var calls in testPhone.CallsHistory)
            {
                Console.WriteLine(calls.ToString());
                Console.WriteLine(new string('-', 20));
            }

            sumOfAllCalls = testPhone.CallPrice(0.37M);
            Console.WriteLine("Total price of All calls: " + sumOfAllCalls.ToString("C2"));

            // delete all calls
            testPhone.ClearCallHistory();

            // print all calls to see that the list is empty
            Console.WriteLine("The \"{0}\" Call History:", testPhone.Model);
            foreach (var calls in testPhone.CallsHistory)
            {
                Console.WriteLine(calls.ToString());
            }
        }
    }
}
