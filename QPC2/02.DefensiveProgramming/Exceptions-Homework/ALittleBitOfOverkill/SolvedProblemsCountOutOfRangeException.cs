namespace Exceptions_Homework
{
    using System;

    internal class SolvedProblemsCountOutOfRangeException : ArgumentOutOfRangeException
    {
        internal SolvedProblemsCountOutOfRangeException(string message) : base(message)
        {
        }
    }
}
