namespace SchoolSystem.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public class Teacher : Person, ITeacher, ICommentable
    {
        private List<Discipline> disciplines;

        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }

        public Teacher(string name, List<Discipline> disciplines, string comment)
            : base(name, comment)
        {
            this.Disciplines = disciplines;
        }

        public List<Discipline> Disciplines
        {
            get 
            {
                return this.disciplines;
            }
            private set
            {
                this.disciplines = value;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public override string ToString()
        {
            string output = this.Name;
            return output;
        }
    }
}
