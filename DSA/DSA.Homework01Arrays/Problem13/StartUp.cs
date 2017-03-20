namespace Problem13
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var q = new Queue<int>();

            q.Enqueue(5);
            q.Enqueue(11);
            q.Enqueue(32);
            q.Enqueue(1);
            q.Enqueue(843);
            var count = q.LongCount();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(q.Dequeue());
            }
        }
    }
}
