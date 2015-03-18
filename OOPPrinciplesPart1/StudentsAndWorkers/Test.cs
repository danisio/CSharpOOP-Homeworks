namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Test
    {
        public static void Main()
        {
            // Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            List<Student> students = new List<Student>();
            students.Add(new Student("Petyr", "Petrov", 5));
            students.Add(new Student("Stoqn", "Ivanov", 3));
            students.Add(new Student("Ivan", "Ivanov", 4));
            students.Add(new Student("Katq", "Stoqnova", 6));
            students.Add(new Student("Mitko", "Kostadinov", 5));
            students.Add(new Student("Aleks", "Petrov", 3));
            students.Add(new Student("Mariq", "Petrova", 4));
            students.Add(new Student("Georgi", "Miladinov", 6));
            students.Add(new Student("Maq", "Simeonova", 6));
            students.Add(new Student("Pavel", "Neikov", 2));

            // print the initial list
            Console.WriteLine("List of Students");
            Print(students);

            // sort students by grade in ascending order and print again
            var sortedStudents = students.OrderBy(st => st.Grade).ToList();
            Console.WriteLine("\nSorted list:");
            Print(sortedStudents);

            // Initialize a list of 10 workers and sort them by money per hour in descending order.
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Aleksandra", "Filipova", 100, 4, 5));
            workers.Add(new Worker("Mitko", "Todorov", 200, 2.5m, 5));
            workers.Add(new Worker("Plamen", "Mihailov", 150, 3.5m, 5));
            workers.Add(new Worker("Karolina", "Petrova", 75, 2, 5));
            workers.Add(new Worker("Iva", "Kostova", 110, 4.5m, 5));
            workers.Add(new Worker("Teodor", "Aleksandrov", 120, 4, 5));
            workers.Add(new Worker("Ivailo", "Spasov", 150, 3.4m, 5));
            workers.Add(new Worker("Tanq", "Kostova", 80, 3, 5));
            workers.Add(new Worker("Petyr", "Sokolov", 250, 8, 5));
            workers.Add(new Worker("Nikolay", "Simeonov", 200, 8, 5));

            // print the initial list
            Console.WriteLine("\nList of Workers");
            Print(workers);

            // sort them by money per hour in descending order and print again
            var sortedWorkers = workers.OrderByDescending(wk => wk.MoneyPerHour()).ToList();
            Console.WriteLine("\nSorted list:");
            Print(sortedWorkers);

            // Merge the 2 lists and sort them by first name and last name
            var result = new List<Human>();
            result.AddRange(students);
            result.AddRange(workers);
            result = result.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            // print the merged list
            Console.WriteLine("\nMerged List:");
            Print(result);
        }

        private static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
