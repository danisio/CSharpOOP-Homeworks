namespace GSM
{
    using System;
    using System.Text;

    public class Call
    {
        private DateTime date;
        private TimeSpan duration;

        public Call(DateTime date, string number, TimeSpan duration)
        {
            this.Date = date;
            this.Number = number;
            this.Duration = duration;
        }

        ////no validation -> no field, only property
        public string Number { get; set; }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            private set
            {
                if (value <= DateTime.MinValue)
                {
                    throw new ArgumentNullException("Invalid date!");
                }

                this.date = value;
            }
        }

        public TimeSpan Duration
        {
            get
            {
                return this.duration;
            }

            private set
            {
                if (value <= TimeSpan.Zero)
                {
                    throw new ArgumentNullException("The duration must be greater than zero");
                }

                this.duration = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Called Number: " + this.Number));
            result.AppendLine(string.Format("Date: " + this.Date.ToString("dd.MM.yyyy")));
            result.Append(string.Format("Duration: " + this.Duration.TotalSeconds + " sec"));

            return result.ToString();
        }
    }
}
