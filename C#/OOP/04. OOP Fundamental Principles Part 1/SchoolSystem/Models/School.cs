namespace SchoolSystem.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public class School : ISchool
    {
        private List<SchoolClass> classes;
        private string name;

        public School(string name, List<SchoolClass> classes)
        {
            this.Name = name;
            this.Classes = classes;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public List<SchoolClass> Classes
        {
            get
            {
                return this.classes;
            }
            private set
            {
                this.classes = value;
            }
        }

        public void AddClass(SchoolClass newClass)
        {
            this.classes.Add(newClass);
        }

        public override string ToString()
        {
            string output = string.Format("School: {0}\n\n{1}", this.Name, string.Join("\n\n", classes));
            return output;
        }
    }
}
