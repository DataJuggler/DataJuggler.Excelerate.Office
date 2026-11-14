using DataJuggler.Excelerate.Office.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataJuggler.Excelerate.Office.OpenXml4Net.Exceptions
{
    public class OpenXML4NetRuntimeException : RuntimeException
    {

        public OpenXML4NetRuntimeException(String msg)
            : base(msg)
        {
        }

        public OpenXML4NetRuntimeException(String msg, Exception reason)
            : base(msg, reason)
        {
        }
    }
}
