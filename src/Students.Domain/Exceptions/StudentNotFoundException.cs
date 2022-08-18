using System.Runtime.Serialization;

namespace Students.Domain.Exceptions
{
    public class StudentNotFoundException : Exception
    {
        public StudentNotFoundException()
        {
        }

        public StudentNotFoundException(string message) : base(message)
        {
        }

        public StudentNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StudentNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
