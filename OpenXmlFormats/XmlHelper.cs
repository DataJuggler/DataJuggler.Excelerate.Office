using DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.Spreadsheet;
using DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace DataJuggler.Excelerate.Office.OpenXmlFormats.Util
{
    public static class XmlHelper
    {
        public static ST_TrueFalseBlank ReadTrueFalseBlank(string attrValue)
        {
            if (string.IsNullOrEmpty(attrValue))
                return ST_TrueFalseBlank.NONE;
            if (string.IsNullOrEmpty(attrValue))
                return ST_TrueFalseBlank.NONE;
            string value = attrValue.ToLower();
            if (value == "t" || value == "true")
            {
                return ST_TrueFalseBlank.@true;
            }
            else
            {
                return ST_TrueFalseBlank.@false;
            }
        }
        public static ST_TrueFalseBlank ReadTrueFalseBlank(XmlAttribute attr)
        {
            if (attr == null)
                return ST_TrueFalseBlank.NONE;
            if(string.IsNullOrEmpty(attr.Value))
                return ST_TrueFalseBlank.NONE;
            string value = attr.Value.ToLower();
            if (value == "t" || value == "true")
            {
                return ST_TrueFalseBlank.@true;
            }
            else
            {
                return ST_TrueFalseBlank.@false;
            }

        }
        public static DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.Office.ST_TrueFalse ReadTrueFalse(XmlAttribute attr)
        {
            if (attr == null)
                return DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.Office.ST_TrueFalse.@false;
            if (string.IsNullOrEmpty(attr.Value))
                return DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.Office.ST_TrueFalse.@false;

            string value = attr.Value.ToLower();
            if (value == "t" || value == "true")
            {
                return DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.Office.ST_TrueFalse.@true;
            }
            else
            {
                return DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.Office.ST_TrueFalse.@false;
            }
        }
        public static ST_BorderShadow ReadBorderShadow(XmlAttribute attr)
        {
            if (attr == null)
                return ST_BorderShadow.@false;

            if (string.IsNullOrEmpty(attr.Value))
                return ST_BorderShadow.@false;

            string value = attr.Value.ToLower();
            if (value == "t" || value == "true")
            {
                return ST_BorderShadow.@true;
            }
            else
            {
                return ST_BorderShadow.@false;
            }

        }
        public static DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.ST_TrueFalse ReadTrueFalse2(XmlAttribute attr)
        {
            if (attr == null)
                return DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.ST_TrueFalse.@false;
            if (string.IsNullOrEmpty(attr.Value))
                return DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.ST_TrueFalse.@false;

            string value = attr.Value.ToLower();
            if (value == "t" || value == "true")
            {
                return DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.ST_TrueFalse.@true;
            }
            else
            {
                return DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.ST_TrueFalse.@false;
            }
        }
        public static void WriteAttribute(StreamWriter sw, string attributeName, DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.Office.ST_TrueFalse value)
        {
            WriteAttribute(sw, attributeName, value, false);
        }
        public static void WriteAttribute(StreamWriter sw, string attributeName, DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.Office.ST_TrueFalse value, bool defaultValue)
        {
            if (defaultValue == true && (value == OpenXmlFormats.Vml.Office.ST_TrueFalse.t || value == OpenXmlFormats.Vml.Office.ST_TrueFalse.@true))
                return;

            if (defaultValue == false && (value == OpenXmlFormats.Vml.Office.ST_TrueFalse.f || value == OpenXmlFormats.Vml.Office.ST_TrueFalse.@false))
                return;

            if (value == OpenXmlFormats.Vml.Office.ST_TrueFalse.t || value == OpenXmlFormats.Vml.Office.ST_TrueFalse.@true)
                DataJuggler.Excelerate.Office.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "t");
            else
                DataJuggler.Excelerate.Office.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "f");
        }
        public static void WriteAttribute(StreamWriter sw, string attributeName, ST_BorderShadow value)
        {
            WriteAttribute(sw, attributeName, value, false);
        }
        public static void WriteAttribute(StreamWriter sw, string attributeName, ST_BorderShadow value, bool defaultValue)
        {
            if (defaultValue == true && (value ==ST_BorderShadow.t || value ==ST_BorderShadow.@true))
                return;

            if (defaultValue == false && (value ==ST_BorderShadow.f || value ==ST_BorderShadow.@false))
                return;

            if (value ==ST_BorderShadow.t || value ==ST_BorderShadow.@true)
                DataJuggler.Excelerate.Office.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "t");
            else
                DataJuggler.Excelerate.Office.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "f");
        }
        public static void WriteAttribute(StreamWriter sw, string attributeName, DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.ST_TrueFalse value)
        {
            WriteAttribute(sw, attributeName, value, false);
        }
        public static void WriteAttribute(StreamWriter sw, string attributeName, DataJuggler.Excelerate.Office.OpenXmlFormats.Vml.ST_TrueFalse value, bool defaultValue)
        {
            if (defaultValue == true && (value == OpenXmlFormats.Vml.ST_TrueFalse.t || value == OpenXmlFormats.Vml.ST_TrueFalse.@true))
                return;

            if (defaultValue == false && (value == OpenXmlFormats.Vml.ST_TrueFalse.f || value == OpenXmlFormats.Vml.ST_TrueFalse.@false))
                return;

            if (value == OpenXmlFormats.Vml.ST_TrueFalse.t || value == OpenXmlFormats.Vml.ST_TrueFalse.@true)
                DataJuggler.Excelerate.Office.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "t");
            else
                DataJuggler.Excelerate.Office.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "f");
        }
        public static void WriteAttribute(StreamWriter sw, string attributeName, ST_TrueFalseBlank value)
        {
            WriteAttribute(sw, attributeName, value, null);
        }
        public static void WriteAttribute(StreamWriter sw, string attributeName, ST_TrueFalseBlank value, bool? defaultValue)
        {
            if (defaultValue == null&& value == ST_TrueFalseBlank.NONE)
                return;

            if (defaultValue == true && (value == ST_TrueFalseBlank.t || value == ST_TrueFalseBlank.@true))
                return;

            if (defaultValue == false && (value == ST_TrueFalseBlank.f || value == ST_TrueFalseBlank.@false))
                return;

            if (value == ST_TrueFalseBlank.t || value == ST_TrueFalseBlank.@true)
                DataJuggler.Excelerate.Office.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "t");
            else
                DataJuggler.Excelerate.Office.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, attributeName, "f");
        }
    }
}
