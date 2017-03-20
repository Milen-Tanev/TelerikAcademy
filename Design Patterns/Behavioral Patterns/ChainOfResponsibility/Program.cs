namespace ChainOfResponsibility
{
    class Program
    {
        public static void Main(string[] args)
        {
            TaxCalculator lowIncomeTaxCalculator = new LowIncomeTaxCalculator();
            TaxCalculator medIncomeTaxCalculator = new MediumIncomeTaxCalculator();
            TaxCalculator highIncomeTaxCalculator = new HighIncomeTaxCalculator();

            lowIncomeTaxCalculator.SetSuccessor(medIncomeTaxCalculator);
            medIncomeTaxCalculator.SetSuccessor(highIncomeTaxCalculator);

            // Processed by the first calculator
            TaxPayer pesho = new TaxPayer("Pesho", 550M);
            lowIncomeTaxCalculator.CalculateTax(pesho);

            // Processed by the second calculator
            TaxPayer gosho = new TaxPayer("Gosho", 5500M);
            lowIncomeTaxCalculator.CalculateTax(gosho);

            // Processed by the third calculator
            TaxPayer tosho = new TaxPayer("Tosho", 55000M);
            lowIncomeTaxCalculator.CalculateTax(tosho);

            // Processed by none
            TaxPayer mimi = new TaxPayer("Mimi", 550000M);
            lowIncomeTaxCalculator.CalculateTax(mimi);
        }
    }
}
