namespace StudentClass
{
    using System;
    using System.Text;

    public class Student : ICloneable , IComparable<Student>
    {
        public Student(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }

        public Student(string firstName, string middleName, string lastName, ulong SSN, string address, string mobilePhone, string email, string course, Speciality speciality, Faculty faculty, University university)
            : this(firstName, middleName, lastName)
        {
            this.SSN = SSN;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Speciality = speciality;
            this.Faculty = faculty;
            this.University = university;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ulong SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Speciality Speciality { get; set; }
        public Faculty Faculty { get; set; }
        public University University { get; set; }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !Student.Equals(student1, student2);
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student == null)
            {
                return false;
            }

            if (this.SSN != student.SSN)
            {
                return false;
            }

            if (!object.Equals(this.FirstName, student.FirstName) && !object.Equals(this.LastName, student.LastName))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.Email.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Full name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            result.AppendFormat("\nUniversity: {0}", this.University);
            result.AppendFormat("\nFaculty: {0}", this.Faculty);
            result.AppendFormat("\nSpeciality: {0}", this.Speciality);
            result.AppendFormat("\nCourse: {0}", this.Course);
            result.AppendFormat("\nSSN: {0}", this.SSN);
            result.AppendFormat("\nAddress: {0}", this.Address);
            result.AppendFormat("\nPhone/Mobile: {0}/{1}", this.MobilePhone, this.Email);

            return result.ToString();
        }

        public object Clone()
        {
            return new Student(
                    this.FirstName,
                    this.MiddleName,
                    this.LastName,
                    this.SSN,
                    this.Address,
                    this.MobilePhone,
                    this.Email,
                    this.Course,
                    this.Speciality,
                    this.Faculty,
                    this.University);
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) != 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            if (this.MiddleName.CompareTo(other.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }

            if (this.LastName.CompareTo(other.LastName) != 0)
            {
                return this.LastName.CompareTo(other.LastName);
            }

            return this.SSN.CompareTo(other.SSN);
        }
    }
}
