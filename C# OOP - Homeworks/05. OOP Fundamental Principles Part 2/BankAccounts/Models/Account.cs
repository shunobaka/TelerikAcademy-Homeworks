namespace BankAccounts.Models
{
    using Interfaces;

    public abstract class Account : IAccountable, IMonthable
    {
        private CustomerTypes customer;
        private double balance;
        private double interestRate;
        private int month;
        private string holderName;

        public Account(CustomerTypes customer, double balance, double interest, string holderName)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interest;
            this.HolderName = holderName;
            this.month = 0;
        }

        public string HolderName
        {
            get
            {
                return this.holderName;
            }
            set
            {
                this.holderName = value;
            }
        }

        public CustomerTypes Customer
        {
            get { return this.customer; }
            protected set { this.customer = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            protected set { this.balance = value; }
        }

        public double InterestRate
        {
            get { return this.interestRate; }
            protected set { this.interestRate = value; }
        }

        public abstract double CalcInterest(int period);

        public int Month
        {
            get { return this.month; }
            protected set { this.month = value; }
        }
    }
}
