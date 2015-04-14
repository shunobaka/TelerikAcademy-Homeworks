namespace AnimalHierarchy.Interfaces
{
    using Models;

    interface IAnimal
    {
        string Name { get; }
        int Age { get; }
        Gender Sex { get; }
        AnimalType Type { get; }
    }
}
