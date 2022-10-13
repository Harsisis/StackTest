using System.Runtime.Serialization;

namespace StackTest {
    [Serializable]
    internal class StackIsEmptyException : Exception {
        public StackIsEmptyException() {
        }

        public StackIsEmptyException(string? message) : base(message) {
        }

        public StackIsEmptyException(string? message, Exception? innerException) : base(message, innerException) {
        }

        protected StackIsEmptyException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}