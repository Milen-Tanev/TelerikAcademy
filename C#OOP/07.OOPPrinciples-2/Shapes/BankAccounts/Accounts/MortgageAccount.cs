namespace BankAccounts.Accounts
{
    using System;
    using Customers;
    using Interfaces;

    public class MortgageAccount : Account, IAccountable
    {
        public MortgageAccount (Customer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Customer == Customer.Individual)
            {
                if (numberOfMonths <= 6)
                {
                    return 0;
                }

                else
                {
                return (numberOfMonths - 6) * this.MonthlyInterestRate;
                }
            }

            else
            {
                if (numberOfMonths <= 12)
                {
                    return (numberOfMonths * this.MonthlyInterestRate) / 2;
                }

                else
                {
                    return ((12 * this.MonthlyInterestRate) / 2) + ((numberOfMonths - 12) * this.MonthlyInterestRate);
                }
            }
        }

        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException("Withdrawal from mortgage accounts is not allowed!");
        }
    }
}
