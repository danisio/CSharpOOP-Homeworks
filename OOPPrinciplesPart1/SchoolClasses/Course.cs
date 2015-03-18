namespace SchoolClasses
{
    using System;

    public abstract class Course : ICommentable
    {
        private string id;
        private string comment;

        public string Identifier
        {
            get
            {
                if (string.IsNullOrEmpty(this.id))
                {
                    throw new NullReferenceException();
                }

                return this.id;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name is too short");
                }

                this.id = value;
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
    }
}
