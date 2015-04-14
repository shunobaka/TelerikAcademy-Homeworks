namespace BankAccounts.Interfaces
{
    using Models;

    interface IAccountable
    {
        CustomerTypes Customer { get; }
        double Balance { get; }
        double InterestRate { get; }
        double CalcInterest(int period);
        string HolderName { get; }
    }
}
