namespace BankAccounts
{
    using System;
    using System.Text;

    public abstract class Account : IDepositable
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = 0;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            private set { this.customer = value; }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Deposit cannot be less than zero");
                }

                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The InterestRate cannot me less than zero");
                }

                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterest(uint months)
        {
            return this.interestRate * months;
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1:C2}", this.Customer, this.Balance);
        }
    }
}
