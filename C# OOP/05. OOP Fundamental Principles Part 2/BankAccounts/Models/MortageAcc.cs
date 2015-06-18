namespace BankAccounts.Models
{
    using System;
    using Interfaces;

    public class MortgageAcc : Account, IDepositable, IAccountable, IMonthable
    {
        public MortgageAcc(CustomerTypes customer, double balance, double interest, string holder)
            : base(customer, balance, interest, holder)
        {

        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.Balance += amount;
        }

        public override double CalcInterest(int period)
        {
            if (base.Customer == CustomerTypes.Company)
            {
                if (base.Month < 12)
                {
                    return ((base.InterestRate * (12 - base.Month)) / 2 + (base.InterestRate * (period - 12 + base.Month)));
                }
            }
            else
            {
                if (base.Month < 6)
                {
                    return (base.InterestRate * (period - base.Month));
                }
            }
            return (base.InterestRate * period);
        }
    }
}
