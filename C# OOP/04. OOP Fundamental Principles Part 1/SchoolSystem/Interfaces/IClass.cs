namespace SchoolSystem.Interfaces
{
    using System.Collections.Generic;
    using Models;

    interface IClass
    {
        string Identifier { get; }
        List<Teacher> Teachers { get; }
        List<Student> Students { get; }
    }
}
