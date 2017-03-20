namespace Exceptions_Homework
{
    using System;

    internal class NullExamsException : ArgumentNullException
    {
        internal NullExamsException(string message) : base(message)
        {
        }
    }
}
