namespace Exceptions_Homework
{
    using System;

    internal class CommentCannotBeNullException : ArgumentNullException
    {
        internal CommentCannotBeNullException(string message) : base(message)
        {
        }
    }
}
