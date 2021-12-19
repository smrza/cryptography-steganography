using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Steganography
{
    class StaticMethods
    {
        public static string InsertLetter(bool letter)
        {
            if (letter == true)
            {
                return "1";
            }
            else return "0";
        }

        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ReturnParsedInput(string input)
        {
            input = Regex.Replace(input, @"[^\u0000-\u007F]+", string.Empty);
            return input;
        }

        public static bool IsNeededToParse(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Regex.IsMatch(Convert.ToString(input[i]), @"[\u0000-\u007F]+") == false)
                {
                    return true;
                }
            }

            return false;
        }

        public static string RemoveZero(string input)
        {
            input = Regex.Replace(input, "[0]+", string.Empty);
            return input;
        }

        public static bool IsZero(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if(Regex.IsMatch(Convert.ToString(input[i]), "[0]+") == true)
                {
                    return true;
                }
            }

            return false;
        }

        public static byte ReturnFileExtensionFilter(string input)
        {
            if (input == ".jpeg" || input == ".JPEG" || input == ".jpg" || input == ".JPG")
            {
                return 1;
            }
            else if (input == ".png" || input == ".PNG")
            {
                return 2;
            }
            else if (input == ".tiff" || input == ".TIFF" || input == ".tif" || input == ".TIF")
            {
                return 3;
            }
            else if (input == ".bmp" || input == ".BMP")
            {
                return 4;
            }
            else if (input == ".gif" || input == ".GIF")
            {
                return 5;
            }
            else return 6;
        }

        //////////////////////////////////////////////////////////////////////////////
        public static string ReturnParsedInputFF(string input)
        {
            input = Regex.Replace(input, @"[^\u0000-\u00FF]+", string.Empty);
            return input;
        }

        public static bool IsNeededToParseFF(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Regex.IsMatch(Convert.ToString(input[i]), @"[\u0000-\u00FF]+") == false)
                {
                    return true;
                }
            }

            return false;
        }
        //////////////////////////////////////////////////////////////////////////////
    }
}
