namespace SchoolClasses
{
    public class Discipline : Course, ICommentable
    {
        public Discipline(string identifier, uint numberOfLectures, uint numberOfExercises)
        {
            this.Identifier = identifier;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public uint NumberOfLectures { get; set; }

        public uint NumberOfExercises { get; set; }

        public override string ToString()
        {
            return string.Format("Discipline {0} --> Lectures {1}, Exercises {2}", this.Identifier, this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}
