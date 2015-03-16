namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Net.Mail;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fn;
        private string phone;
        private MailAddress email;
        private Group group;
        private List<int> marks;

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, string facNum, string phone, string email, Group group, params int[] marks)
            : this(firstName, lastName)
        {
            this.FacNum = facNum;
            this.Phone = phone;
            this.Email = new MailAddress(email);
            this.Marks = new List<int>(marks);
            this.Group = group;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.lastName = value;
            }
        }

        public string FacNum
        {
            get
            {
                if (string.IsNullOrEmpty(this.fn))
                {
                    throw new ArgumentException();
                }

                return this.fn;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.fn = value;
            }
        }

        public string Phone
        {
            get
            {
                if (string.IsNullOrEmpty(this.phone))
                {
                    throw new ArgumentException();
                }

                return this.phone;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                this.phone = value;
            }
        }

        public MailAddress Email
        {
            get
            {
                if (this.email == null)
                {
                    throw new ArgumentException();
                }

                return this.email;
            }

            set
            {
                this.CheckEmail(value.Address);

                this.email = value;
            }
        }

        public Group Group
        {
            get
            {
                if (this.group.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.group;
            }

            set
            {
                this.group = value;
            }
        }

        public List<int> Marks
        {
            get { return new List<int>(this.marks); }

            set { this.marks = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} {1}", this.firstName, this.lastName);

            if (!string.IsNullOrEmpty(this.fn))
            {
                result.AppendFormat(", {0}", this.fn);
            }

            if (!string.IsNullOrEmpty(this.phone))
            {
                result.AppendFormat(", {0}", this.phone);
            }

            if (this.email != null)
            {
                result.AppendFormat(", {0}", this.email);
            }

            if (this.group != null)
            {
                result.AppendFormat(", {0}", this.group);
            }

            if (this.marks != null)
            {
                result.Append(", Marks: ");
                result.AppendFormat(string.Join(", ", this.marks));
            }

            return result.ToString();
        }

        private void CheckEmail(string email)
        {
            if (!Regex.IsMatch(email,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                throw new ArgumentException("Invalid email!");
            }
        }
    }
}
