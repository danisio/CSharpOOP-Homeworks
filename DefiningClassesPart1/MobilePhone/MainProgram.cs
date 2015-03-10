namespace GSM
{
    public class MainProgram
    {
        public static void Main()
        {
            GSMTest.TestAddingNewPhones();
            
            System.Console.WriteLine(new string('#', 50));
            
            GSMCallHistoryTest.TestCallHistory();
        }
    }
}
