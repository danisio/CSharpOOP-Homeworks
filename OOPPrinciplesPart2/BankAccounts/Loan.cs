namespace BankAccounts
{
    public class Loan : Account
    {
        public Loan(Customer customer, decimal interestRate)
            : base(customer, interestRate)
        {
        }

        public override decimal CalculateInterest(uint months)
        {
            if (this.Customer is Individual && months > 3)
            {
                return base.CalculateInterest(months - 3);
            }
            else if (this.Customer is Company && months > 2)
            {
                return base.CalculateInterest(months - 2);
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
