namespace OOP___Homework3.Extentions
{
    using System.Text;

    public static class SubString
    {

        public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        {
            return new StringBuilder(builder.ToString().Substring(index, length));
        }

        public static StringBuilder Substring(this StringBuilder builder, int index)
        {
            return new StringBuilder(builder.ToString(index, builder.Length - index));
        }
    }
}
