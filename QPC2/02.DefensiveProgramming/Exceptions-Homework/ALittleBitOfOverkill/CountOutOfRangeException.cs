namespace Exceptions_Homework
{
    using System;

    internal class CountOutOfRangeException : ArgumentException
    {
        internal CountOutOfRangeException(string message) : base(message)
        {
        }
    }
}