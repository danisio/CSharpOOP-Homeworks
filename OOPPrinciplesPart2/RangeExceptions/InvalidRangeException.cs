namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string msg) :
            base(msg)
        {
        }

        public InvalidRangeException(string msg, Exception innerEx)
            : base(msg, innerEx)
        {
        }

        public InvalidRangeException(T min, T max)
        {
            this.Min = min;
            this.Max = max;
        }

        public InvalidRangeException(string msg, T min, T max)
            : base(msg)
        {
            this.Min = min;
            this.Max = max;
        }

        public InvalidRangeException(string msg, Exception innerEx, T min, T max)
            : base(msg, innerEx)
        {
            this.Min = min;
            this.Max = max;
        }

        public T Min { get; set; }

        public T Max { get; set; }

        public override string Message
        {
            get
            {
                return string.Format("Sorry! Out of this range {0}-{1}!", this.Min, this.Max);
            }
        }
    }
}
