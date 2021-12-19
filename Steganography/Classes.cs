using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography
{
    public class Classes
    {
        public class LetterAsciiBinaryList
        {
            public char Letter { get; set; }
            public int Ascii { get; set; }
            public string Binary { get; set; }
            public string BinaryReverse { get; set; }

            public LetterAsciiBinaryList()
            {
            }
        }

        public class ImagePixelBinaryInformation
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int RedValue { get; set; }
            public int GreenValue { get; set; }
            public int BlueValue { get; set; }
            public string BinaryRed { get; set; }
            public string BinaryGreen { get; set; }
            public string BinaryBlue { get; set; }
            public char LeastSignificantBitBlue { get; set; }

            public ImagePixelBinaryInformation()
            {
            }
        }
    }
}
