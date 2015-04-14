namespace BankAccounts.Models
{
    using System.Collections.Generic;

    public class Bank
    {
        private List<Account> accounts;

        public Bank()
        {
            this.Accounts = new List<Account>();
        }

        public Bank(List<Account> accounts)
        {
            this.Accounts = accounts;
        }

        public List<Account> Accounts
        {
            get { return this.accounts; }
            set { this.accounts = value;}
        }

        public void AddAccount(Account account)
        {
            this.Accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            this.Accounts.Remove(account);
        }

        public Account this[int index]
        {
            get
            {
                return this.accounts[index];
            }
        }
    }
}
