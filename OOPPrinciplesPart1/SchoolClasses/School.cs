namespace SchoolClasses
{
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private List<Class> classes;

        public School(string name)
        {
            this.Name = name;
            this.classes = new List<Class>();
        }

        public string Name { get; set; }

        public List<Class> Classes
        {
            get
            {
                return new List<Class>(this.classes);
            }

            set
            {
                this.classes = value;
            }
        }

        public void AddClass(Class currentClass)
        {
            this.classes.Add(currentClass);
        }

        public void RemoveClass(Class currentClass)
        {
            this.classes.Remove(currentClass);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("----{0}----", this.Name);
            result.AppendLine();

            foreach (var clasS in this.classes)
            {
                result.Append(clasS.ToString());
                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
