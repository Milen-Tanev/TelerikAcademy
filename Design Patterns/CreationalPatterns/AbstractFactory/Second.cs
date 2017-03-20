namespace AbstractFactory
{
    class Second : FirstSecondParent
    {
        public override string Message
        {
            get
            {
                return "Object of the second class was created";
            }
            set
            {
            }
        }
    }
}
