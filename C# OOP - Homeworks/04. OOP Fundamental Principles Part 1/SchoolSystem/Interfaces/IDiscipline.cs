namespace SchoolSystem.Interfaces
{
    interface IDiscipline
    {
        string Name { get; }
        int NumberOfLectures { get; }
        int NumberOfExercises { get; }
    }
}
