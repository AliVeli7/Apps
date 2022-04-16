using System;
using System.Runtime.Serialization;

namespace App
{
    [Serializable]
    internal class MedicineAlreadyExistsException : Exception
    {
        public MedicineAlreadyExistsException()
        {
        }

        public MedicineAlreadyExistsException(string message) : base(message)
        {
        }

        public MedicineAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MedicineAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}