namespace AbstractFactory
{
    class StartUp
    {
        static void Main()
        {
            AbstractFactory factory = new FirstFactory();
            FirstSecondParent Object = factory.CreateObject();
            System.Console.WriteLine(Object.Message);

            factory = new SecondFactory();
            Object = factory.CreateObject();
            System.Console.WriteLine(Object.Message);
        }
    }
}
