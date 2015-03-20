namespace Person
{
    public class Person
    {
        public Person(string name, byte? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public byte? Age { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, age: {1}", this.Name, this.Age == null ? "not specified" : this.Age.ToString());
        }
    }
}
