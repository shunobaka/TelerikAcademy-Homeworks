namespace BankAccounts.Models
{
    using System;
    using Interfaces;

    class LoanAcc : Account, IAccountable, IDepositable, IMonthable
    {
        public LoanAcc(CustomerTypes customer, double balance, double interest, string holder)
            : base(customer, balance, interest, holder)
        {

        }

        public override double CalcInterest(int period)
        {
            if (period <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (base.Customer == CustomerTypes.Company)
            {
                if (base.Month >= 2)
                {
                    return (base.InterestRate * period);
                }
                else
                {
                    return (base.InterestRate * (period - 2 + base.Month));
                }
            }
            else
            {
                if (base.Month >= 3)
                {
                    return (base.InterestRate * period);
                }
                else
                {
                    return (base.InterestRate * (period - 3 + base.Month));
                }
            }
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            base.Balance += amount;
        }
    }
}
