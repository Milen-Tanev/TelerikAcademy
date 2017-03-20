namespace Problem11
{
    public class StartUp
    {
        public static void Main()
        {
            var list = new LinkedList<char>();

            for (int i = 58; i < 72; i++)
            {
                var item = new ListItem<char>((char)i);
                list.Add(item);
            }

            foreach (var element in list)
            {
                System.Console.WriteLine(element);
            }
        }
    }
}
