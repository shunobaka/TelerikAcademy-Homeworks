namespace SchoolSystem.Interfaces
{
    using System.Collections.Generic;
    using Models;

    interface ITeacher
    {
        List<Discipline> Disciplines { get; }
    }
}
