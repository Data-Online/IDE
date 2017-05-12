using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpers
{
    public static class StringExtensions
    {
        public static string FormatPdfFileName(this string fileName)
        {
            return fileName.PadLeft(8, '0') + ".pdf";
        }

        public static string FormatPdfFileName(this int value)
        {
            return value.ToString().PadLeft(8, '0') + ".pdf";
        }

        public static string FormatContainerName(this int value)
        {
            return value.ToString().PadLeft(6, '0');
        }
    }
}