using System;

namespace ColorSpheres

{
    class Color
    {
        private readonly byte red;
        private readonly byte green;
        private readonly byte blue;
        private readonly byte alpha;

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

        public byte GetGrey()
        {
            return (byte)((red + green + blue) / 3);
        }
        public byte GetRed()
        {
            return red;
        }
        public byte GetGreen()
        {
            return green;
        }

        public byte GetBlue()
        {
            return blue;
        }

        public byte GetAlpha()
        {
            return alpha;
        }

    }
}