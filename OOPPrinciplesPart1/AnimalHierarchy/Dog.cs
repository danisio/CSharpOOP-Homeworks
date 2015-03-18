namespace AnimalHierarchy
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Sex sex)
            : base(name, age, sex)
        {
        }

        public override string MakeSound()
        {
            return "Bauuuuuuu";
        }
    }
}
