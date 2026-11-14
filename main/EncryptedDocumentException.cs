using System;

namespace DataJuggler.Excelerate.Office
{
    [Serializable]
    public class EncryptedDocumentException : InvalidOperationException
    {
        public EncryptedDocumentException(string message)
            : base(message)
        { }
        public EncryptedDocumentException(string message, Exception cause)
            : base(message, cause)
        { }
        public EncryptedDocumentException(Exception cause)
            : base(cause.Message)
        {
        }
    }
}
