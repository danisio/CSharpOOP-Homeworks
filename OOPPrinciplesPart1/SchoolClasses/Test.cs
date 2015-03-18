namespace SchoolClasses
{
    using System;
    using System.Text;

    public class Test
    {
        public static void Main()
        {
            School newSchool = new School("Telerik Academy");

            newSchool.AddClass(
                new Class("2015")
                    .AddStudents(
                        new Student("Ivan", "Ivanov", 10015100),
                        new Student("Petyr", "Petrov", 10015101),
                        new Student("Todor", "Todorov", 10001502))
                    .AddTeachers(
                        new Teacher("Ivailo", "Kenov")
                            .AddDiscipline(new Discipline("OOP", 7, 7), new Discipline("C#2", 8, 8)),
                        new Teacher("Evlogi", "Hristov")
                            .AddDiscipline(new Discipline("C#1", 6, 6), new Discipline("OOP", 7, 7)),
                        new Teacher("Nikolay", "Kostov"),
                        new Teacher("Doncho", "Minkov")));

            newSchool.AddClass(
                new Class("2014")
                    .AddTeachers(
                        new Teacher("Svetlin", "Nakov")
                            .AddDiscipline(new Discipline("HTML", 5, 5)))
                    .AddStudents(new Student("Nov", "Student", 10014100)));

            Console.WriteLine(newSchool);
        }
    }
}
