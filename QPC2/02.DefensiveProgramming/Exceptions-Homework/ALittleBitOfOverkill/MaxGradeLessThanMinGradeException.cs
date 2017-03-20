namespace Exceptions_Homework
{
    using System;

    internal class MaxGradeLessThanMinGradeException : ArgumentOutOfRangeException
    {
        internal MaxGradeLessThanMinGradeException(string message) : base(message)
        {
        }
    }
}
