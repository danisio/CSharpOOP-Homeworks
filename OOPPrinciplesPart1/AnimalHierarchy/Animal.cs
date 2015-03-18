namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public Sex Sex { get; set; }

        public static double Calculate(List<Animal> animals, Type type)
        {
            if (type == typeof(Cat))
            {
                return animals.OfType<Cat>().Average(x => x.Age);
            }
            else if (type == typeof(Dog))
            {
                return animals.OfType<Dog>().Average(x => x.Age);
            }
            else
            {
                return animals.OfType<Frog>().Average(x => x.Age);
            }
        }

        public abstract string MakeSound();

        public override string ToString()
        {
            return string.Format("{0,-5}: name {1,-12}: age {2,3}, {3,7}, say: {4}",
                    this.GetType().Name, this.Name, this.Age, this.Sex, this.MakeSound());
        }
    }
}
