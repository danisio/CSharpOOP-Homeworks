namespace GSM
{
    using System;
    using System.Text;

    public class Battery
    {
        private double hoursIdle;
        private double hoursTalk;

        public Battery(BatteryType model)
        {
            this.Model = model;
        }

        public Battery(BatteryType model, double hoursIdle, double hoursTalk)
            : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public BatteryType Model { get; private set; }

        public double HoursIdle
        {
            get
            {
                if (this.hoursIdle == 0)
                {
                    throw new NullReferenceException();
                }

                return this.hoursIdle;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than zero");
                }

                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                if (this.hoursTalk == 0)
                {
                    throw new NullReferenceException();
                }

                return this.hoursTalk;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than zero");
                }

                this.hoursTalk = value;
            }
        }

        public override string ToString()
        {
            StringBuilder batteryInfo = new StringBuilder();

            batteryInfo.AppendLine("------Battery Info-----");
            batteryInfo.AppendLine("Type: " + this.Model);
            if (this.hoursIdle != 0)
            {
                batteryInfo.AppendLine("Stand-by: " + this.HoursIdle + " hours");
            }

            if (this.hoursTalk != 0)
            {
                batteryInfo.AppendLine("Talk time: " + this.HoursTalk + " hours");
            }

            return batteryInfo.ToString();
        }
    }

    public enum BatteryType
    {
        Li_Ion,
        Li_Poly,
        NiCd,
        NiMH
    }
}
