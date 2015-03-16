namespace Timer
{
    using System.Threading;

    public class Program
    {
        public static void Main()
        {
            Ticker ticker = new Ticker(Timer.Action);

            while (true)
            {
                Thread.Sleep(1000);
                ticker();
            }
        }
    }
}
