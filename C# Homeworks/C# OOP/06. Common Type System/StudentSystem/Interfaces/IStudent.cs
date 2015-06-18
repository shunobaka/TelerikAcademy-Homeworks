namespace StudentSystem.Interfaces
{
    using Enumarations;

    interface IStudent
    {
        string FirstName { get; }
        string MiddleName { get; }
        string LastName { get; }
        int SSN { get; }
        string Address { get; }
        int Phone { get; }
        string Email { get; }
        string Course { get; }
        Speciality Speciality { get; }
        Faculty Faculty { get; }
        University Univerity { get; }
    }
}
