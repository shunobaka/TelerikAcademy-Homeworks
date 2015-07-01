namespace StudentsAndWorkers.Models
{
    using Interfaces;

    public abstract class Human : IHuman
    {
        private string firstName;
        private string lastName;
        protected string fullName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.fullName = firstName + " " + lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                this.lastName = value;
            }
        }
    }
}
