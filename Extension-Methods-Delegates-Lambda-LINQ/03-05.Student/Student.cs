namespace Student
{
    public class Student
    {
        public Student()
        {
        }

        public Student(string firstName, string lastName, byte age)
            : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte Age { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.Age;
        }
    }
}
