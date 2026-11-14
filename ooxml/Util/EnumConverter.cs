using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace DataJuggler.Excelerate.Office.Util
{
    public static class EnumConverter
    {       
        public static T ValueOf<T, F>(F val)
        {
            string value = Enum.GetName(val.GetType(), val);
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
