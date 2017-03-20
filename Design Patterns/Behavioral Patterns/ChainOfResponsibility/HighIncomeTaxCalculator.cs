namespace ChainOfResponsibility
{
    using System;

    internal class HighIncomeTaxCalculator : TaxCalculator
    {
        public override void CalculateTax(TaxPayer income)
        {
            if (income.Value < 100000.0M)
            {
                decimal tax = income.Value * 5 / 100;
                Console.WriteLine("The taxes of {0} are ${1}", income.Name, tax);
            }
            else
            {
                Console.WriteLine("{0} is too rich to pay taxes!", income.Name);
            }
        }
    }
}
