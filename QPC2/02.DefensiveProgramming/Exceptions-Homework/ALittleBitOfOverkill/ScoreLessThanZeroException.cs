namespace Exceptions_Homework
{
    using System;

    internal class ScoreLessThanZeroException : ArgumentException
    {
        internal ScoreLessThanZeroException (string message) : base(message)
        {
        }
    }
}