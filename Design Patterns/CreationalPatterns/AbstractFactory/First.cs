namespace AbstractFactory
{
    class First : FirstSecondParent
    {
        public override string Message
        {
            get
            {
                return "Object of the first class was created";
            }
            set
            {
            }
        }
    }
}
