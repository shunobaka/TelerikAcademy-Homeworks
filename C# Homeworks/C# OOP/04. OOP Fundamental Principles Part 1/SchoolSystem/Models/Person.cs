namespace SchoolSystem.Models
{
    using Interfaces;

    public class Person : IPerson
    {
        private string name;
        private string comment;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, string comment)
            : this(name)
        {
            this.Comment = comment;
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
    }
}
