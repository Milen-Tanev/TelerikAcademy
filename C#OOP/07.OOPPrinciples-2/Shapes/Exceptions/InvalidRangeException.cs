namespace Exceptions
{
    using System;

    class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string message, T start, T end) :base(message)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; set; }
        public T End { get; set; }
    }
}
