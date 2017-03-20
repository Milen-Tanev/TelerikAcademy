namespace Exceptions_Homework
{
    using System;

    internal class NumberIsNotPrimeException : ArgumentException
    {
        internal NumberIsNotPrimeException(string message) : base(message)
        {
        }
    }
}
