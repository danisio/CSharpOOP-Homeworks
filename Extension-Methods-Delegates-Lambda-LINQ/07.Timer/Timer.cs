namespace Timer
{
    using System;

    public delegate void Ticker();

    public static class Timer
    {
        public static readonly Action Action = new Action(() => Console.WriteLine("Test {0}", ++Seconds));

        public static int Seconds { get; private set; }
    }
}
