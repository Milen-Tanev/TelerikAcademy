namespace Exceptions_Homework
{
    using System;

    internal class GradeLessThanZeroException : ArgumentException
    {
        internal GradeLessThanZeroException(string message) : base(message)
        {
        }
    }
}
