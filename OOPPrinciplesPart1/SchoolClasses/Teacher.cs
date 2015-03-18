namespace SchoolClasses
{
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : People, ICommentable
    {
        private List<Discipline> disciplines;

        public Teacher(string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Disciplines = new List<Discipline>();
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(this.disciplines);
            }

            private set
            {
                this.disciplines = value;
            }
        }

        public Teacher AddDiscipline(params Discipline[] disciplines)
        {
            foreach (var dsp in disciplines)
            {
                this.disciplines.Add(dsp);
            }

            return this;
        }

        public Teacher RemoveDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);

            return this;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            if (this.disciplines.Count > 0)
            {
                foreach (var dsp in this.disciplines)
                {
                    result.AppendFormat("\n{0}", dsp.ToString());
                }
            }

            return result.ToString();
        }
    }
}
