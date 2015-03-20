namespace StudentClass
{
    using System;

    public class TestStudent
    {
        public static void Main()
        {
            // add test student 1
            Student student1 = new Student("Ivan", "Ivanov", "Ivanov");
            student1.University = University.TelerikAcademy;
            student1.Faculty = Faculty.Fac1;
            student1.Speciality = Speciality.OOP;
            student1.Course = "FG2015";
            student1.SSN = 123454;
            student1.Address = "Sofia";
            student1.Email = "test@test.com";
            student1.MobilePhone = "12345677";

            // add test student 2
            Student student2 = new Student("Petur", "Petrov", "Petrov");
            student2.University = University.Other;
            student2.Faculty = Faculty.Fac2;
            student2.Speciality = Speciality.CSharp2;
            student2.Course = "FG2015";
            student2.SSN = 123455;
            student2.Address = "Sofia";
            student2.Email = "test2@test.com";
            student2.MobilePhone = "4322345";

            // print the 2 students
            Console.WriteLine(student1);
            Console.WriteLine();
            Console.WriteLine(student2);
            Console.WriteLine();

            // test the overriden methods
            Console.WriteLine("Equal {0}", student1.Equals(student1));
            Console.WriteLine("Equal {0}", student1.Equals(student2));
            Console.WriteLine("Operator == {0}", student1 == student2);
            Console.WriteLine("Operator == {0}", student1 != student2);
            Console.WriteLine("HashCode of student1: {0}", student1.GetHashCode());
            Console.WriteLine("HashCode of student2: {0}", student2.GetHashCode());

            // test The Clone() method
            var newStudent = (Student)student1.Clone();
            
            // check cloning
            Console.WriteLine("\nBefore cloning {0}", student1 == newStudent);
            newStudent.SSN = 999999999;
            Console.WriteLine("After cloning {0}", student1 == newStudent);
            Console.WriteLine();

            // test CompareTo() method
            newStudent = student2.Clone() as Student;
            Console.WriteLine(student2.CompareTo(newStudent));
            Console.WriteLine(student2.CompareTo(student1));
        }
    }
}
