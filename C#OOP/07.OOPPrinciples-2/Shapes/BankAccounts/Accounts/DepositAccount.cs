namespace BankAccounts.Accounts
{
    using Customers;
    using Interfaces;

    public class DepositAccount : Account, IAccountable
    {
        public DepositAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            else
            {
                return numberOfMonths * this.MonthlyInterestRate;
            }
        }
    }
}
