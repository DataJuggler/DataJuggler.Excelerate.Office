using System;

namespace DataJuggler.Excelerate.Office.HSSF
{
    [Serializable]
    public class OldExcelFormatException:Exception
    {
        public OldExcelFormatException(String s)
            : base(s)
        { }

    }
}
