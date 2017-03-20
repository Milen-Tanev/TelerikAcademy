// <copyright file="StringExtensions.cs" company="company">
// Copyright (c) company. All rights reserved.
// </copyright>
// <author>me</author>

// XMLsample.cs
// compile with: /doc:XMLsample.xml
namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;
    
    /// <summary>
    /// Converts string to other variable types
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Convert input string to MD5 hash-function
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>returns MD5 Hash-function</returns>
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
        /// Convert input string to boolean true value
        /// if it is contained in an array of truth values
        /// or to boolean false value if it is not contained
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>returns boolean value</returns>
        public static bool ToBoolean(this string input)
        {
            // initialize array of truth strings
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };

            // check whether the array contains the input string
            // return true if does and false if does not
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Convert input string to variable of type short
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>returns variable of type short</returns>
        public static short ToShort(this string input)
        {
            // initialize short variable
            short shortValue;

            // try to parse the string to short variable
            short.TryParse(input, out shortValue);

            // return the parsed value
            return shortValue;
        }

        /// <summary>
        /// Convert input string to 32-bit integer
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>returns variable of type 32-bit integer</returns>
        public static int ToInteger(this string input)
        {
            // initialize int variable
            int integerValue;

            // try to parse the string to int variable
            int.TryParse(input, out integerValue);

            // return the parsed value
            return integerValue;
        }

        /// <summary>
        /// Convert input string to variable of type long
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>returns variable of type long</returns>
        public static long ToLong(this string input)
        {
            // initialize long variable
            long longValue;

            // try to parse the string to long variable
            long.TryParse(input, out longValue);

            // return the parsed value
            return longValue;
        }

        /// <summary>
        /// Convert input string to DateTime value
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>returns DateTime value</returns>
        public static DateTime ToDateTime(this string input)
        {
            // initialize DateTime variable
            DateTime dateTimeValue;

            // try to parse the string to DateTime variable
            DateTime.TryParse(input, out dateTimeValue);

            // return the parsed value
            return dateTimeValue;
        }

        /// <summary>
        /// Convert all letters in the input string to capital letters
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>returns string with capital letters only</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            // check if string is null or empty
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // returns the input string with capital letters only
            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Get part of string between two substrings
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="startString">Starting string</param>
        /// <param name="endString">Ending string</param>
        /// <param name="startFrom">Beginning index with default value zero</param>
        /// <returns>returns the substring located between the starting and ending strings</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            // initialize the starting string
            input = input.Substring(startFrom);

            // start from the beginning of the input string
            startFrom = 0;

            // check if the input string contains the starting string or ending string
            // if not return empty string 
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            // discover the index of the starting string
            // if not discovered return empty string
            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            // discover the index of the ending string
            // if not discovered return empty string
            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            // return substring beginning at the starting index,
            // with length equal to the margin between the ending and starting indexes
            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Convert cyrillic to latin letters
        /// </summary>
        /// <param name="input">Input string in cyrillic letters</param>
        /// <returns>returns the input string converted to latin letters</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            // initialize array of the cyrillic letters
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };

            // initialize array with latin letters, corresponding to the cyrillic letters at the same indexes
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };

            // replace each cyrillic letter with the latin letter at the same index
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            // return the input string with replaced letters
            return input;
        }

        /// <summary>
        /// Convert latin to cyrillic letters
        /// </summary>
        /// <param name="input">Input string in latin letters</param>
        /// <returns>returns the input string converted to cyrillic letters</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            // initialize array of the latin letters
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            // initialize array with cyrillic letters, corresponding to the latin letters at the same indexes
            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            // replace each latin letter with the cyrillic letter at the same index
            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            // return the input string with replaced letters
            return input;
        }

        /// <summary>
        /// Convert string to valid username replacing the invalid characters with empty string
        /// and converting cyrillic to latin letters
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>returns the input string without the invalid characters</returns>
        public static string ToValidUsername(this string input)
        {
            // convert the cyrillic letters from the input string to latin letters
            input = input.ConvertCyrillicToLatinLetters();

            // remove all the invalid characters and return the remaining string
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Convert string to valid filename replacing the invalid characters with empty string
        /// and converting cyrillic to latin letters
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>returns the input string without the invalid characters</returns>
        public static string ToValidLatinFileName(this string input)
        {
            // convert the cyrillic letters from the input string to latin letters
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();

            // remove all the invalid characters and return the remaining string
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Get the first defined number of characters of the input string
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="charsCount">number of characters to be returned</param>
        /// <returns>returns the input string without the invalid characters</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            // return substring starting at the 0 index of the input string
            // with length equal to the smaller number between the input length or the input count
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Get filename as string and return its extension
        /// </summary>
        /// <param name="fileName">Input string</param>
        /// <returns>returns string representing the file extension in the input string</returns>
        public static string GetFileExtension(this string fileName)
        {
            // check if string is null or empty
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            // split the input string by "."
            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            // return the last stringafter splitting
            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Gets the extension of a file and returns the content type of the file
        /// </summary>
        /// <param name="fileExtension">Input string</param>
        /// <returns>returns the content type of the file based on its extension</returns>
        public static string ToContentType(this string fileExtension)
        {
            // initialize dicitonary with file extensions and the corresponding file content
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

            // check if the dictionary contains the file extention and return the corresponding content type
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Convert string to byte array
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>returns byte array of the input string</returns>
        public static byte[] ToByteArray(this string input)
        {
            // initialize the return bytes array
            var bytesArray = new byte[input.Length * sizeof(char)];

            // copy the bytes of the input to the bytes array
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
