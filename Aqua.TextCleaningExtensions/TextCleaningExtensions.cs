﻿using System.Text.RegularExpressions;

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

        /// <summary>
        /// Is Null Or White Space String?
        /// </summary>
        /// <param name="s">string</param>
        /// <returns>true/false</returns>
        public static bool IsNullOrWhiteSpace(this string s) => string.IsNullOrWhiteSpace(s);

        /// <summary>
        /// If the string is null convert it to empty
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string IfNullReturnEmptyString(this string s) => s == null ? string.Empty : s;


        /// <summary>
        /// Remove Wide Spaces from the text
        /// </summary>
        /// <param name="s">text</param>
        /// <returns>clean text</returns>
        public static string RemoveWideSpaces(this string s)
        {
            if (s.IsNullOrEmpty()) return s;

            string pattern = "\\s+";
            string replacement = " ";

            Regex rx = new Regex(pattern);

            return rx.Replace(s, replacement).Trim();
        }

        /// <summary>
        /// Convert Tabs to WhiteSpaces
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReplaceTabsWithSpaces(this string s)
            => s.IsNullOrEmpty() ? s : s.Replace("\t", " ").RemoveWideSpaces();

        /// <summary>
        /// Replace the New Line Chars To White Spaces
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string NewLinesToWhiteSpaces(this string s)
             => s.IsNullOrEmpty() ? s : s.Replace("\n", " ").RemoveWideSpaces();

        /// <summary>
        /// Clean the text
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToCleanText(this string s)
            => s.IsNullOrEmpty() ? s : s.Replace("\n", " ").Replace("\t", " ").RemoveWideSpaces();
    }
}
