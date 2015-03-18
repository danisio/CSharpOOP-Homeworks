namespace SchoolClasses
{
    using System;

    public abstract class People : ICommentable
    {
        private string firstName;
        private string lastName;
        private string comment;

        public People(string firstName, string lastName)
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

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid name");
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

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid name");
                }

                this.lastName = value;
            }
        }

        public string Comment
        {
            get
            {
                if (string.IsNullOrEmpty(this.comment))
                {
                    throw new NullReferenceException("Comments missing");
                }

                return this.comment;
            }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Comment is too short");
                }

                this.comment = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
