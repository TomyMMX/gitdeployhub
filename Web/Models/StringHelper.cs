using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitDeployHub.Web
{
    public static class StringExt
    {
        public static string Truncate(this string value, int maxLength)
        {
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}