using System;
using System.Collections.Generic;
using System.Text;

namespace DataJuggler.Excelerate.Office.Util
{
    public sealed class AssertFailedException : ApplicationException
    {
        public AssertFailedException(string message)
            : base(message)
        {

        }
    }
}
