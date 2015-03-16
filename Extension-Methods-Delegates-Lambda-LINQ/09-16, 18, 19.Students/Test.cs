namespace Students
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Test
    {
        public static void Main()
        {
            // add some test students
            List<Student> testStudents = new List<Student>();

            testStudents.Add(new Student("Petyr", "Petrov", "123405123", "0212345678", "pesho@gmail.com",
                new Group(2, "Mathematics"), 4, 2, 4, 4));
            testStudents.Add(new Student("Gosho", "Petrov", "432205123", "+35912345688", "gosho@abv.bg",
                new Group(1, "Informatics"), 3, 2, 3, 5));
            testStudents.Add(new Student("Iva", "Koleva", "763206123", "022345623", "iva@abv.bg",
                new Group(1, "Informatics"), 6, 6, 5, 5));
            testStudents.Add(new Student("Тosho", "Ivanov", "356806123", "0212345698", "tosho@gmail.com",
                new Group(1, "Informatics"), 6, 6, 6, 6, 6));
            testStudents.Add(new Student("Ivan", "Ivanov", "876506123", "+35912345608", "ivan@abv.bg",
                new Group(2, "Mathematics"), 2, 2, 4, 4));

            // select students that are from group number 2 using LINQ query
            var studentFromGroupLinq =
                from st in testStudents
                where st.Group.GroupNumber == 2
                orderby st.FirstName
                select st;

            // print the result
            Console.WriteLine("Problem 9. Student groups:\n" + string.Join("\n", studentFromGroupLinq));

            // the same using extension methods
            var studentFromGroupExtension = testStudents.Where(st => st.Group.GroupNumber == 2).OrderBy(st => st.FirstName);

            // print the result
            Console.WriteLine("\nProblem 10. Student groups extensions:\n" + string.Join("\n", studentFromGroupExtension));

            // extract students with abv.bg email/ LINQ
            var studentsByEmail =
                from st in testStudents
                where st.Email.Host == "abv.bg"
                select st;

            // print the result
            Console.WriteLine("\nProblem 11. Extract students by email using LINQ:\n" + string.Join("\n", studentsByEmail));

            // extract students with abv.bg email/ String
            Console.WriteLine("\nProblem 11. Extract students by email using string methods:");
            foreach (var st in testStudents)
            {
                if (st.Email.ToString().Contains("abv.bg"))
                {
                    Console.WriteLine(st);
                }
            }

            // extract students by phone
            var studentsByPhone =
                from st in testStudents
                where st.Phone.StartsWith("02")
                select st;

            Console.WriteLine("\nProblem 12. Extract students by phone:\n" + string.Join("\n", studentsByPhone));

            // extract all students with atleast one mark Excellent 6
            var studentsExcellent =
                from st in testStudents
                where st.Marks.Contains(6)
                select new { FullName = st.FirstName + " " + st.LastName, Marks = st.Marks };

            Console.WriteLine("\nProblem 13. Extract students by marks:");
            foreach (var st in studentsExcellent)
            {
                Console.WriteLine("Marks of {0} -> {1}", st.FullName, string.Join(", ", st.Marks));
            }

            // extracts the students with exactly two marks "2"
            var studentsWithTwoMarks = testStudents.Where(st => st.Marks.Count(x => x == 2) == 2);
            Console.WriteLine("\nProblem 14. Extract students with two marks \"2\":\n" + string.Join("\n", studentsWithTwoMarks));

            // extract all Marks of the students that enrolled in 2006
            var studentsIn2006 =
                from st in testStudents
                where st.FacNum.Substring(4, 2) == "06"
                select new { FacNum = st.FacNum, Marks = st.Marks };

            Console.WriteLine("\nProblem 15. Extract marks:");
            foreach (var st in studentsIn2006)
            {
                Console.WriteLine("Student Fac № {0} -> marks ({1})", st.FacNum, string.Join(", ", st.Marks));
            }

            // Extract all students from "Mathematics" department, using the Join operator.
            var studentsMathematics =
                from st in testStudents
                where st.Group.DepartmentName == "Mathematics"
                select st;

            Console.WriteLine("\nProblem 16.* Groups:\n" + string.Join("\n", studentsMathematics));

            // grouped by groupNumber using LINQ
            var studentsGroupedLinq =
                from st in testStudents
                group st by st.Group.GroupNumber into newGroup
                orderby newGroup.Key
                select newGroup;

            Console.WriteLine("\nProblem 18. Grouped by GroupNumber LINQ:");
            foreach (var group in studentsGroupedLinq)
            {
                Console.WriteLine("Group number " + group.Key);
                foreach (var st in group)
                {
                    Console.WriteLine("Student {0} {1} ", st.FirstName, st.LastName);
                }
            }

            // grouped by groupNumber using extension methods
            var studentsGroupedExtension = GetStudentsByGroup(testStudents);
            Console.WriteLine("\nProblem 19. Grouped by GroupNumber extensions:\n" + studentsGroupedExtension);
        }

        private static string GetStudentsByGroup(List<Student> testStudents)
        {
            var studentsGroupedExtension = testStudents.GroupBy(x => x.Group.GroupNumber).OrderBy(x => x.Key);

            StringBuilder result = new StringBuilder();

            foreach (var group in studentsGroupedExtension)
            {
                result.AppendFormat("Group number {0}\n", group.Key);
                foreach (var st in group)
                {
                    result.AppendFormat("Student {0} {1}\n", st.FirstName, st.LastName);
                }
            }

            return result.ToString();
        }
    }
}
