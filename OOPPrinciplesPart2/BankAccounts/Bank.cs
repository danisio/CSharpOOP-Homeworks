namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Bank
    {
        private string name;
        private List<Account> accounts;

        public Bank(string name)
        {
            this.Name = name;
            this.accounts = new List<Account>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 1)
                {
                    throw new ArgumentException("Invalid name");
                }

                this.name = value;
            }
        }

        public List<Account> Accounts
        {
            get
            {
                return new List<Account>(this.accounts);
            }

            private set
            {
                this.accounts = value;
            }
        }

        public void AddDepositAccount(Customer customer, decimal interestRate)
        {
            this.accounts.Add(new Deposit(customer, interestRate));
        }

        public void AddLoanAccount(Customer customer, decimal interestRate)
        {
            this.accounts.Add(new Loan(customer, interestRate));
        }

        public void AddMortgageAccount(Customer customer, decimal interestRate)
        {
            this.accounts.Add(new Mortgage(customer, interestRate));
        }

        public void RemoveAccount(Account account)
        {
            if (account.Balance == 0)
            {
                this.accounts.Remove(account);
            }
            else
            {
                throw new ArgumentException("Balance is not zero, cannot delete account!");
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Name: {0}\n", this.Name);
            result.AppendLine("Accounts:");

            foreach (var acc in this.Accounts)
            {
                result.AppendFormat("Type: {0} --> ", acc.GetType().Name.PadRight(10, ' '));
                result.AppendLine(acc.ToString());
            }

            return result.ToString();
        }
    }
}
