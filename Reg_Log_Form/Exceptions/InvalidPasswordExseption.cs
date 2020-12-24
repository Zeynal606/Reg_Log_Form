using System;
using System.Runtime.Serialization;

namespace Reg_Log_Form
{
    [Serializable]
    internal class InvalidPasswordExseption : ApplicationException
    {
        public InvalidPasswordExseption()
        {
        }

        public InvalidPasswordExseption(string message) : base(message)
        {
        }

        public InvalidPasswordExseption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidPasswordExseption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}