namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private static GSM IPhone4s = new GSM(
            "IPhone4s",
            "Apple",
            new Battery(BatteryType.Li_Poly, 200, 14),
            new Display(3.5, 16000000));

        private string model;
        private string manufacturer;
        private decimal price;
        private Battery battery;
        private Display display;
        private List<Call> callsHistory = new List<Call>();

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, Battery battery)
            : this(model, manufacturer)
        {
            this.Battery = battery;
        }

        public GSM(string model, string manufacturer, Display display)
            : this(model, manufacturer)
        {
            this.Display = display;
        }

        public GSM(string model, string manufacturer, Battery battery, Display display)
            : this(model, manufacturer)
        {
            this.Battery = battery;
            this.Display = display;
        }

        public static GSM IPhone_4s
        {
            get { return IPhone4s; }
        }

        public string Owner { get; set; }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be null!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer cannot be null!");
                }

                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0 || value > decimal.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Price is too big or less than zero.");
                }

                this.price = value;
            }
        }


        public Battery Battery
        {
            get
            {
                if (this.battery.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                if (this.display.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.display;
            }

            set
            {
                this.display = value;
            }
        }

        public List<Call> CallsHistory
        {
            get { return this.callsHistory; }
        }

        public void AddCalls(Call currentCall)
        {
            this.CallsHistory.Add(currentCall);
        }

        public void RemoveCall(Call currentCall)
        {
            this.CallsHistory.Remove(currentCall);
        }

        public void ClearCallHistory()
        {
            this.callsHistory = new List<Call>();
        }

        public decimal CallPrice(decimal PricePerMinute)
        {
            decimal sum = 0;
            foreach (var duration in this.CallsHistory)
            {
                sum += (decimal)duration.Duration.TotalSeconds;
            }

            decimal result = PricePerMinute * (sum / 60);

            return result;
        }

        public override string ToString()
        {
            StringBuilder mobileInfo = new StringBuilder();

            mobileInfo.AppendLine("---Mobile Phone Info---");
            mobileInfo.AppendLine("Model: " + this.model);
            mobileInfo.AppendLine("Manufacturer: " + this.manufacturer);

            if (this.Owner != null)
            {
                mobileInfo.AppendLine("Owner: " + this.Owner);
            }

            if (this.price != 0)
            {
                mobileInfo.AppendLine(string.Format("Price: {0:C}", this.price));
            }

            if (this.battery != null)
            {
                mobileInfo.Append(this.battery.ToString());
            }

            if (this.display != null)
            {
                mobileInfo.Append(this.display.ToString());
            }

            return mobileInfo.ToString();
        }
    }
}
