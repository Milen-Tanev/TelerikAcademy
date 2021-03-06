﻿namespace ChainOfResponsibility
{
    using System;

    internal class LowIncomeTaxCalculator : TaxCalculator
    {
        public override void CalculateTax(TaxPayer income)
        {
            if (income.Value < 1000.0M)
            {
                decimal tax = income.Value * 5 / 100;
                Console.WriteLine("The taxes of {0} are ${1}", income.Name, tax);
            }
            else if (this.Successor != null)
            {
                this.Successor.CalculateTax(income);
            }
        }
    }
}
