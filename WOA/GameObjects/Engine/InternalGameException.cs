namespace GameObjects.Engine
{
    using System;

    public class InternalGameException : ApplicationException
    {
        public InternalGameException(string message)
            : base(message)
        {
        }
    }
}
