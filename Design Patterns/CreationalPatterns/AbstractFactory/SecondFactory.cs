namespace AbstractFactory
{
    class SecondFactory : AbstractFactory
    {
        internal override FirstSecondParent CreateObject()
        {
            return new Second();
        }
    }
}
