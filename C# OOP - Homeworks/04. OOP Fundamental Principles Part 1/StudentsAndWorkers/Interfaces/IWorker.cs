namespace StudentsAndWorkers.Interfaces
{
    interface IWorker
    {
        int WeekSalary { get; }
        int WorkHoursPerDay { get; }
        double MoneyPerHour();
    }
}
