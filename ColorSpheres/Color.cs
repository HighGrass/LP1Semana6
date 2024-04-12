using System;

namespace ColorSpheres

{
    class Color
    {
        byte red = 0;
        byte green = 0;
        byte blue = 0;
        byte alpha = 0;


        public Color(byte r, byte g, byte b, byte a)
        {
            red = r;
            green = g;
            blue = b;
            alpha = a;
        }
        public Color(byte r, byte g, byte b)
        {
            alpha = 255;
        }

        public byte GetGrey() => return (byte) ((red + green + blue) / 3);
        //public byte[] GetColors => return [red, green, blue, alpha];
        
        public byte GetRed() => return red;
        public byte GetGreen() => return green;
        public byte GetBlue() => return blue;
        public byte GetAlpha() => return alpha;

    }
}