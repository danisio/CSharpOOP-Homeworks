namespace SchoolClasses
{
    using System.Collections.Generic;
    using System.Text;

    public class Class : Course, ICommentable
    {
        private List<Teacher> teachers;
        private List<Student> students;

        public Class(string identifier)
        {
            this.Identifier = identifier;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }

        public string ClassID { get; private set; }

        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }
        }

        public List<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public Class AddStudents(params Student[] students)
        {
            foreach (var st in students)
            {
                this.students.Add(st);
            }

            return this;
        }

        public Class RemoveStudent(Student currentStudent)
        {
            this.students.Remove(currentStudent);
            return this;
        }

        public Class AddTeachers(params Teacher[] teachers)
        {
            foreach (var teacher in teachers)
            {
                this.teachers.Add(teacher);
            }

            return this;
        }

        public Class RemoveTeacher(Teacher currentTeacher)
        {
            this.teachers.Remove(currentTeacher);
            return this;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("\nClass ID: {0}", this.Identifier);

            result.Append("\n---Teachers");

            foreach (var teacher in this.Teachers)
            {
                result.AppendFormat("\n\tTeacher: {0}", teacher.ToString());
            }

            result.Append("\n---Students:");

            foreach (var stud in this.Students)
            {
                result.AppendFormat("\n\tStudent: {0}", stud.ToString());
            }

            return result.ToString();
        }
    }
}
