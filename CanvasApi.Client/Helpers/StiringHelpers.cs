using System;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace CanvasApi.Client.Helpers
{
    public static class StiringHelpers
    {
        /// <summary>
        /// Converts a Pascal Case string to an underscore string
        ///
        /// BryanLenihan => bryan_lenihan
        /// </summary>
        /// <param name="properString">The Pascal case string to convert</param>
        /// <returns></returns>
        public static string ToUnderscore(this string properString)
        {
            var convertRegex = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

            var underScoreString = convertRegex.Replace(properString, "_").ToLower();

            return underScoreString;
        }

        /// <summary>
        /// Coverts a string with spaces and _ to pascal case
        /// </summary>
        /// <param name="inString"></param>
        /// <returns></returns>
        public static string ToPascal(this string inString)
        {
            var parts =
                inString
                    .Split(' ')
                    .SelectMany(item => item.Split('_').Select(item => item.Trim().ToLower()))
                    .Where(item => !string.IsNullOrWhiteSpace(item)) 
                    .Select(item => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item))
                    .ToArray();

            var pascalString = string.Join(string.Empty, parts);
            return pascalString;            
        }
    }
}
