namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Test
    {
        public static void Main()
        {
            // add some test animals
            var animals = new List<Animal>();

            animals.Add(new Cat("Kloe", 10, Sex.Female));
            animals.Add(new Dog("Bary", 6, Sex.Male));
            animals.Add(new Frog("Maq", 2, Sex.Female));
            animals.Add(new Cat("Su", 3, Sex.Female));
            animals.Add(new Frog("Kermit", 12, Sex.Male));
            animals.Add(new Frog("Mrs. Appleby", 50, Sex.Male));
            animals.Add(new Dog("Rita", 15, Sex.Female));

            // sort the animals by type - Cat, Dog... and print
            var sortedAnimals = animals.OrderBy(x => x.GetType().Name);
            foreach (var item in sortedAnimals)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAverage age:");
            Console.WriteLine("of cats: {0:F2}", Animal.Calculate(animals, typeof(Cat)));
            Console.WriteLine("of dogs: {0:F2}", Animal.Calculate(animals, typeof(Dog)));
            Console.WriteLine("of frogs: {0:F2}", Animal.Calculate(animals, typeof(Frog)));
        }
    }
}
