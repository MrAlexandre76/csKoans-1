using System;
using System.Runtime.Serialization;

namespace FinalTest
{
    [Serializable]
    public class RetraitNonAutorisé : Exception
    {
        public RetraitNonAutorisé()
        {
        }

        public RetraitNonAutorisé(string message) : base(message)
        {
        }

        public RetraitNonAutorisé(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RetraitNonAutorisé(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}