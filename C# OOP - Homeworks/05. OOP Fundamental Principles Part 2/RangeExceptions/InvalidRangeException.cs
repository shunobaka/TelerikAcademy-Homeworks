namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
        where T : IComparable<T>
    {
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end)
            : base(string.Format("{0}. The parameter should be in the range [{1}, {2}]",message, start, end), null)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            set { this.end = value; }
        }
    }
}
