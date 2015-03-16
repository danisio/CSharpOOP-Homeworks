namespace Student
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class Program
    {
        public static void Main()
        {
            // add some test students
            List<Student> students = new List<Student>();
            students.Add(new Student("Teodor", "Simeonov", 25));
            students.Add(new Student("Petko", "Spasov", 30));
            students.Add(new Student("Dimityr", "Todorov", 29));
            students.Add(new Student("Aneliq", "Kostadinova", 23));
            students.Add(new Student("Petko", "Mihov", 20));
            
            // print all students
            Print(students);

            // find all students whose first name is before its last name alphabetically
            var names =
                from st in students
                where st.FirstName.CompareTo(st.LastName) < 0
                orderby st.FirstName
                select st;

            Console.WriteLine("\nProblem 3. First before last:");
            Print(names);

            // find the first name and last name of all students with age between 18 and 24.
            var ages =
                from st in students
                where st.Age >= 18 && st.Age <= 24
                select st.FirstName + " " + st.LastName;

            Console.WriteLine("\nProblem 4. Age range:");
            Print(ages);

            // Problem 5 = Order
            var orderedLambda = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            Console.WriteLine("\nProblem 5 with lambda expressions");
            Print(orderedLambda);

            var orderedLinq =
                from st in students
                orderby st.FirstName descending, st.LastName descending
                select st;
            Console.WriteLine("\nProblem 5 with LINQ query");
            Print(orderedLinq);
        }

        public static void Print<T>(T elements)
            where T : IEnumerable
        {
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
