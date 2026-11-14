using System;

namespace DataJuggler.Excelerate.Office
{
    [Serializable]
    public class OldFileFormatException : UnsupportedFileFormatException
    {
        public OldFileFormatException(String s)
            : base(s)
        { }

    }
}
