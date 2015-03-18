namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private byte grade;

        public Student(string firstName, string lastName, byte grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public byte Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value != 2 && value != 3 && value != 4 && value != 5 && value != 6)
                {
                    throw new ArgumentException("Invalid grade");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", base.ToString(), " --> Grade:", this.Grade);
        }
    }
}
