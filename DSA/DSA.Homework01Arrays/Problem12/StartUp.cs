namespace Problem12
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            System.Console.WriteLine("Count: {0}", stack.Count);
            System.Console.WriteLine("Capacity: {0}", stack.Capacity);

            stack.Push(5);
            stack.Push(6);
            stack.Push(11);
            stack.Push(22);
            stack.Push(11);
            System.Console.WriteLine("Items:");
            foreach (var item in stack)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("Count: {0}", stack.Count);
            System.Console.WriteLine("Capacity: {0}", stack.Capacity);
        }
    }
}
