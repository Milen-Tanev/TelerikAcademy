namespace BankAccounts
{
    using System;
    using Accounts;
    using Customers;

    class StartUp
    {
        static void Main(string[] args)
        {
            LoanAccount loan = new LoanAccount(Customer.Individual, 500, 2);
            Console.WriteLine(loan.CalculateInterest(12));
            loan.Deposit(1000);
            Console.WriteLine(loan.Balance);
            Account deposit = new DepositAccount(Customer.Company, 100000, 8);
            Console.WriteLine(deposit.CalculateInterest(3));
        }
    }
}
