namespace StudentsAndWorkers.Models
{
    using Interfaces;

    public class Worker : Human, IWorker, IHuman
    {
        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary
        {
            get 
            { 
                return this.weekSalary; 
            }
            private set
            {
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get 
            { 
                return this.workHoursPerDay; 
            }
            private set
            {
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            double result = new double();

            result = this.weekSalary / (this.workHoursPerDay * 5.0);

            return result;
        }

        public override string ToString()
        {
            string toString = string.Format("{0, -17} - Money per hour: {1:F2}", base.fullName, this.MoneyPerHour());
            return toString;
        }
    }
}
