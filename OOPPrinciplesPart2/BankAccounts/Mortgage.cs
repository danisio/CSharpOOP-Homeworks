namespace BankAccounts
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal interestRate)
            : base(customer, interestRate)
        {
        }

        public override decimal CalculateInterest(uint months)
        {
            if (this.Customer is Individual && months > 6)
            {
                return base.CalculateInterest(months - 6);
            }
            else if (this.Customer is Company)
            {
                if (months < 12)
                {
                    return (this.InterestRate * months) / 2;
                }
                else
                {
                    return ((this.InterestRate * 12) / 2) + (this.InterestRate * (months - 12));
                }
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
