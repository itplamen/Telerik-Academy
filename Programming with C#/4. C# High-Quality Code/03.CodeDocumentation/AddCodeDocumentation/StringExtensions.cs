namespace AddCodeDocumentation
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Contains string extension methods for <seealso cref="System.String"/>
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the given <paramref name="input"/> as <seealso cref="System.String"/> in 128bit hash value format.
        /// </summary>
        /// <param name="input">The string whose hash will be calculated.</param>
        /// <returns>128bit hash value as <seealso cref="System.String"/>.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// Check if the given string contains boolean value.
        /// </summary>
        /// <param name="input">The given string, that will be checked.</param>
        /// <returns>True if contains a boolean value, false if not.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Parsing the given string to <seealso cref="System.Int16"/>
        /// </summary>
        /// <param name="input">The given string, that will be parsed to Short number.</param>
        /// <returns>Returns number if the parse is successful, otherwise returns number zero (0).</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Parsing the given string to <seealso cref="System.Int32"/>
        /// </summary>
        /// <param name="input">The given string, that will be parsed to Integer number.</param>
        /// <returns>Returns number if the parse is successful, otherwise returns number zero (0).</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Parsing the given string to <seealso cref="System.Int64"/>
        /// </summary>
        /// <param name="input">The given string, that will be parsed to Long number.</param>
        /// <returns>Returns number if the parse is successful, otherwise returns number zero (0).</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Parsing the given string to <seealso cref="System.DateTime"/>
        /// </summary>
        /// <param name="input">The given string, that will be parsed to DateTime type value.</param>
        /// <returns>Returns DateTime value if the parse is successful, otherwise returns the default DateTime value.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Capitalize the first letter of a given string.
        /// </summary>
        /// <param name="input">The given string value.</param>
        /// <returns>The given string with capitalized first letter, otherwise returns null if <paramref name="input"/> is null or empty.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Extract substring from a given string.
        /// </summary>
        /// <param name="input">The given string that should be processed.</param>
        /// <param name="startString">The left part of the given string.</param>
        /// <param name="endString">The right part of the given string.</param>
        /// <param name="startFrom">Optional param, which if left unvalueted gets default value 0, else the given value.</param>
        /// <returns>The extracted substring, otherwise returns String.Empty if the given string is empty.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Replace cyrillic letters of the given string value with latin representation.
        /// </summary>
        /// <param name="input">The given string value.</param>
        /// <returns>The given string in bulgarian to it's latin representation, otherwise returns null if <paramref name="input"/> is empty.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Replace latin letters with latin representation of bulgarian letters.
        /// </summary>
        /// <param name="input">The given string value.</param>
        /// <returns>The given string in bulgarian to it's latin representation, otherwise returns null if <paramref name="input"/> is empty.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Replace symbols from <paramref name="input"/> which are not in valid username format.
        /// </summary>
        /// <param name="input">The given string value.</param>
        /// <returns>Returns the given <paramref name="input"/> in valid username format.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Replace symbols from <paramref name="input"/> which are not in valid file name format.
        /// </summary>
        /// <param name="input">The given string value.</param>
        /// <returns>Returns the given <paramref name="input"/> in valid file name format.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Extract substring from the given <paramref name="input"/>, starting from the first character.
        /// </summary>
        /// <param name="input">The given string value that will be processed.</param>
        /// <param name="charsCount">The length of the substring.</param>
        /// <returns>The extracted substring.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Extract substring from the given <paramref name="fileName"/>, starting from character "dot" (.).
        /// </summary>
        /// <param name="fileName">The given string value.</param>
        /// <returns>The extracted substring, otherwise returns String.Empty if <paramref name="fileName"/> is null or empty.</returns>
        /// <example>
        /// <code>
        /// string fileName = "Program.cs";
        /// Console.WriteLine(StringExtensions.GetFileExtension(fileName)); // Output: cs
        /// </code>
        /// </example>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Process the given <paramref name="fileName"/> as <seealso cref="System.String"/>, returning its content type.
        /// </summary>
        /// <param name="fileExtension">The given string value.</param>
        /// <returns>The file content type, otherwise returns application/octet-stream.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Convert the given <paramref name="input"/> as <seealso cref="System.String"/>.
        /// </summary>
        /// <param name="input">The given string.</param>
        /// <returns>A array of bytes, containing each symbol of the given instance converted to byte.</returns>
        /// <example>
        /// <code>
        /// var input = "Telerik".ToByteArray();
        /// Console.WriteLine(String.Join(" ", input)); // Output: 84 0 101 0 108 0 101 0 114 0 105 0 107 0
        /// </code>
        /// </example>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
