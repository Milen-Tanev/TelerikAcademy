namespace Exceptions_Homework
{
    using System;

    internal class NoExamsException : ArgumentException
    {
        internal NoExamsException(string message) : base(message)
        {
        }
    }
}
