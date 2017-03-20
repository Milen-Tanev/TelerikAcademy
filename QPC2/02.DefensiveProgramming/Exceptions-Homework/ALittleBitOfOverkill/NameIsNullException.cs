namespace Exceptions_Homework
{
    using System;

    internal class NameIsNullException : ArgumentNullException
    {
        internal NameIsNullException(string message) : base(message)
        {
        }
    }
}