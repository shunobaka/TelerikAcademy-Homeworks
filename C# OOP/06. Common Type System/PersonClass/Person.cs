namespace PersonClass
{
    using System.Text;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age)
            : this(name)
        {
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public int? Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendLine(string.Format("Name: {0}", this.Name));
            toString.Append(string.Format("Age: {0}", this.Age == null ? "not specified" : this.age.ToString()));
            return toString.ToString();
        }
    }
}
