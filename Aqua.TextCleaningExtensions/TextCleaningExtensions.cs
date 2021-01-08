using System;
using System.Collections.Generic;
using System.Text;

namespace Aqua.TextCleaningExtensions
{
    public static class TextCleaningExtensions
    {
        /// <summary>
        /// Is Null Or Empty String?
        /// </summary>
        /// <param name="s">string</param>
        /// <returns>true/false</returns>
        public static bool IsNullOrEmpty(this string s) => string.IsNullOrEmpty(s);

    }
}
