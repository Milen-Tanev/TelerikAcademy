namespace BankAccounts
{
    using System;
    using Customers;
    using Interfaces;

    public abstract class Account : IAccountable
    {
        private Customer customer;
        private decimal balance;
        private decimal monthlyInterestRate;

        public Account(Customer customer, decimal balance, decimal monthlyInterestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthlyInterestRate = monthlyInterestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            protected set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                this.balance = value;
            }
        }

        public decimal MonthlyInterestRate
        {
            get
            {
                return this.monthlyInterestRate;
            }

            protected set
            {
                this.monthlyInterestRate = value;
            }
        }

        public virtual decimal CalculateInterest(int numberOfMonths)
        {
            decimal interest = numberOfMonths * this.MonthlyInterestRate;
            return interest;
        }

        public void Deposit(decimal amount)
        {
            if (amount <=0)
            {
                throw new ArgumentException("The amount of money to deposit must be more than 0!");
            }
            this.Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("The amount of money to withdraw must be more than 0!");
            }
            this.Balance -= amount;
        }
    }
}
