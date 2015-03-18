namespace BankAccounts
{
    using System;

    public class Deposit : Account, IWithdrawable
    {
        public Deposit(Customer customer, decimal interestRate)
            : base(customer, interestRate)
        {
        }

        public void WithdrawMoney(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("Invalid operation");
            }

            this.Balance -= amount;
        }

        public override decimal CalculateInterest(uint months)
        {
            if (this.Balance > 1000)
            {
                return months * this.InterestRate;
            }

            return 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
