namespace SchoolClasses
{
    public class Student : People, ICommentable
    {
        private uint classNumber;

        public Student(string firstName, string lastName, uint classID)
            : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ClassNumber = classID;
        }

        public uint ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            private set
            {
                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} ID {1}", base.ToString(), this.classNumber);
        }
    }
}
