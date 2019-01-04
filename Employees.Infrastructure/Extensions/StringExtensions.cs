using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employees.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static string TrimAndRemoveWhiteSpaces(this string text)
        {
            text = text.Trim();
            var regex = new Regex(@"\s{2,}");
            while (regex.IsMatch(text))
                text = regex.Replace(text, " ", 1);
            return text;
        }

        public static string FirstLetterToUpper(this string text)
        {
            var newText = text.ToCharArray();
            newText[0] = char.ToUpper(newText[0]);
            return new string(newText);
        }

        public static string AllFirstLettersToUpper(this string text)
        {
            var newText = text.ToCharArray();
            for (var i = 0; i < newText.Length; i++)
            {
                if (i == 0)
                    newText[i] = char.ToUpper(newText[i]);
                if (newText[i] == ' ')
                    newText[i + 1] = char.ToUpper(newText[i + 1]);
            }
            return new string(newText);
        }

        public static string GetOib(this string text)
        {
            var newText = text.Split(' ')[1];
            return newText;
        }

        public static string GetProjectName(this string text)
        {
            var newText = text.Split(' ')[0];
            return newText;
        }
    }
}
