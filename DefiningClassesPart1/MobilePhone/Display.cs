namespace GSM
{
    using System;
    using System.Text;

    public class Display
    {
        private double sizeInches;
        private int numberOfColors;

        public Display(double sizeInches, int numberOfColors)
        {
            this.SizeInches = sizeInches;
            this.NumberOfColors = numberOfColors;
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value cannot be less than zero.");
                }

                this.numberOfColors = value;
            }
        }

        public double SizeInches
        {
            get
            {
                return this.sizeInches;
            }

            private set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("Value cannot be less than zero.");
                }

                this.sizeInches = value;
            }
        }

        public override string ToString()
        {
            StringBuilder displayInfo = new StringBuilder();

            displayInfo.AppendLine("-----Display Info------");
            displayInfo.AppendLine("Size: " + this.SizeInches + "inches");
            displayInfo.AppendLine("Colors: " + (this.NumberOfColors / 1000000) + " M");

            return displayInfo.ToString();
        }
    }
}
