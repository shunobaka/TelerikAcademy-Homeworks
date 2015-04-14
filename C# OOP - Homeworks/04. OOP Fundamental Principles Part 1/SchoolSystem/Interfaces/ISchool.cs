namespace SchoolSystem.Interfaces
{
    using Models;
    using System.Collections.Generic;

    interface ISchool
    {
        List<SchoolClass> Classes { get; }
    }
}
