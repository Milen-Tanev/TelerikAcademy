namespace ChainOfResponsibility
{
    internal class TaxPayer
    {
        public TaxPayer(string name, decimal value)
        {
            this.Name = name;
            this.Value = value;
        }

        public string Name { get; set; }

        public decimal Value { get; set; }
    }
}