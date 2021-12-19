using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography
{
    class Conversions
    {
        public static BitArray ConvertStringToBinaryByArrayReverse(string input)
        {
            byte[] byteText;
            byteText = Encoding.ASCII.GetBytes(input);

            BitArray bit = new BitArray(byteText);
            
            return bit;
        }

        public static string ConvertReverseBinaryToString(string input)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < input.Length; i += 8)
            {
                string letter = StaticMethods.ReverseString(input.Substring(i, 8));
                byteList.Add(Convert.ToByte(letter, 2));
            }

            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        public static string ConverDecimalToBinaryString(int input)
        {
            return Convert.ToString(input, 2).PadLeft(8, '0');
        }

        public static int ConvertBinaryStringToDecimal(string input)
        {
            return Convert.ToInt32(input, 2);
        }

        //////////////////////////////////////////////////////////////////////////////
        public static BitArray ConvertStringToBinaryByArrayReverseUTF8(string input)
        {
            byte[] byteText;
            byteText = Encoding.UTF8.GetBytes(input);

            BitArray bit = new BitArray(byteText);

            return bit;
        }

        public static string ConvertReverseBinaryToStringUTF8(string input)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < input.Length; i += 8)
            {
                string letter = StaticMethods.ReverseString(input.Substring(i, 8));
                byteList.Add(Convert.ToByte(letter, 2));
            }

            return Encoding.UTF8.GetString(byteList.ToArray());
        }

        public static BitArray ConvertStringToBinaryByArrayReverseUTF32(string input)
        {
            byte[] byteText;
            byteText = Encoding.UTF32.GetBytes(input);

            BitArray bit = new BitArray(byteText);

            return bit;
        }

        public static string ConvertReverseBinaryToStringUTF32(string input)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < input.Length; i += 8)
            {
                string letter = StaticMethods.ReverseString(input.Substring(i, 8));
                byteList.Add(Convert.ToByte(letter, 2));
            }

            return Encoding.UTF32.GetString(byteList.ToArray());
        }
        //////////////////////////////////////////////////////////////////////////////
    }
}
