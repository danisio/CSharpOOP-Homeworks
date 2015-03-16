namespace Students
{
    using System;
    using System.Text;

    public class Group
    {
        private byte groupNumber;
        private string departmentName;

        public Group(byte groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        public byte GroupNumber
        {
            get
            {
                if (this.groupNumber == 0)
                {
                    throw new NullReferenceException();
                }

                return this.groupNumber;
            }

            private set
            {
                this.groupNumber = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                if (string.IsNullOrEmpty(this.departmentName))
                {
                    throw new NullReferenceException();
                }

                return this.departmentName;
            }

            private set
            {
                this.departmentName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Gr.№ {0} ({1})", this.groupNumber, this.departmentName);

            return result.ToString();
        }
    }
}
