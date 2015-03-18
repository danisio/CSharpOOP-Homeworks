namespace StudentsAndWorkers
{
    using System;
    using System.Collections;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Name cannot be empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Name cannot be empty");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0,-20}", this.FirstName + " " + this.LastName);
        }
    }
}
