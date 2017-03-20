namespace AbstractFactory
{
    class FirstFactory : AbstractFactory
    {
        internal override FirstSecondParent CreateObject()
        {
            return new First();
        }
    }
}
