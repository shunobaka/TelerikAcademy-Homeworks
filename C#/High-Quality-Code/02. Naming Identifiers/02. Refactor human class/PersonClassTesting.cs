namespace PersonCreator
{
    using System;

    public class PersonClassTesting
    {
        public static void Main()
        {
            Person newPerson = new Person(52);

            Console.WriteLine(newPerson.Name);
            Console.WriteLine(newPerson.Gender);
            Console.WriteLine(newPerson.Age);
        }
    }
}
