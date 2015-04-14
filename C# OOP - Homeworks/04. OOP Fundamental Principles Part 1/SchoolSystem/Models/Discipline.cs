namespace SchoolSystem.Models
{
    using Interfaces;

    public class Discipline : IDiscipline, ICommentable
    {
        private string comment;
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfExercises = numberOfExercises;
            this.NumberOfLectures = numberOfLectures;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comment)
            : this(name, numberOfLectures, numberOfExercises)
        {
            this.Comment = comment;
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length > 2)
                {
                    this.name = value;
                }
            }
        }

        public int NumberOfLectures
        {
            get 
            {
                return this.numberOfLectures;
            }
            private set
            {
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            private set
            {
                this.numberOfExercises = value;
            }
        }
    }
}
