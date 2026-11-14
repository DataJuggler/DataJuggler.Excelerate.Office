using System;
using DataJuggler.Excelerate.Office.OpenXml4Net.Exceptions;

namespace DataJuggler.Excelerate.Office.OpenXml4Net
{
    public class OpenXml4NetException : Exception
    {
        public OpenXml4NetException(String msg)
            : base(msg)
        {

        }

        public OpenXml4NetException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
