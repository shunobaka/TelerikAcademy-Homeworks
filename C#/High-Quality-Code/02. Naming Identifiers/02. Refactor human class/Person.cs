namespace PersonCreator
{
    public class Person
    {
        public Person(int age)
        {
            this.Age = age;

            if (age % 2 == 0)
            {
                this.Name = "John";
                this.Gender = Gender.Male;
            }
            else
            {
                this.Name = "Jane";
                this.Gender = Gender.Female;
            }
        }

        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
