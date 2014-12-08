using System;

namespace Circuitry.Classes
{
    public class StateOutOfSyncException : Exception
    {
        public StateOutOfSyncException() { }
        public StateOutOfSyncException(string message) :base(message) { }
        public StateOutOfSyncException(string message, Exception inner) : base(message, inner) { }
        public StateOutOfSyncException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }
    }
}
