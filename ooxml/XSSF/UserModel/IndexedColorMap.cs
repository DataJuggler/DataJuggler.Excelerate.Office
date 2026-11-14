using System;
using System.Collections.Generic;
using System.Text;

namespace DataJuggler.Excelerate.Office.OOXML.XSSF.UserModel
{
    public interface IIndexedColorMap
    {
        byte[] GetRGB(int index);
    }
}
