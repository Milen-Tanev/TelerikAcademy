namespace BankAccounts.Accounts
{
    using System;
    using Customers;
    using Interfaces;

    public class LoanAccount : Account, IAccountable
    {
        public LoanAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Customer == Customer.Individual)
            {
                return (numberOfMonths - 3) * this.MonthlyInterestRate;
            }

            else
            {
                return (numberOfMonths - 2) * this.MonthlyInterestRate;
            }
        }

        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException("Withdrawal from loan accounts is not allowed!");
        }
    }
}
