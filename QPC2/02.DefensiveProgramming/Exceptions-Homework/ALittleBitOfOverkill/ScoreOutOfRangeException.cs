namespace Exceptions_Homework
{
    using System;

    internal class ScoreOutOfRangeException : ArgumentOutOfRangeException
    {
        internal ScoreOutOfRangeException(string message) : base(message)
        {
        }
    }
}