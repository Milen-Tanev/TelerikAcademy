namespace ChainOfResponsibility
{
    internal abstract class TaxCalculator
    {
        protected TaxCalculator Successor { get; set; }

        public void SetSuccessor(TaxCalculator successor)
        {
            this.Successor = successor;
        }

        public abstract void CalculateTax(TaxPayer input);
    }
}
