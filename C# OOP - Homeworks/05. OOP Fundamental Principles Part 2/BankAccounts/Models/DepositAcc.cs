namespace BankAccounts.Models
{
    using System;
    using Interfaces;

    public class DepositAcc: Account, IWithdrawable, IDepositable, IAccountable, IMonthable
    {
        public DepositAcc(CustomerTypes customer, double balance, double interest, string holder)
            : base(customer, balance, interest, holder)
        {

        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            base.Balance -= amount;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            base.Balance += amount;
        }

        public override double CalcInterest(int period)
        {
            if (period <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (base.Balance >= 0 && base.Balance < 1000)
            {
                return 0;
            }

            return (period * base.InterestRate);
        }
    }
}
