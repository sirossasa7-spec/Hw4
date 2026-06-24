namespace Hw_4
{
    struct RGBColor
    {
        public int R;
        public int G;
        public int B;

        public RGBColor(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public string ToHex()
        {
            return $"#{R:X2}{G:X2}{B:X2}";
        }

        public string ToHSL()
        {
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            double h = 0;
            double s;
            double l = (max + min) / 2;

            if (max == min)
            {
                s = 0;
            }
            else
            {
                double d = max - min;

                s = l > 0.5
                    ? d / (2 - max - min)
                    : d / (max + min);

                if (max == r)
                    h = (g - b) / d + (g < b ? 6 : 0);
                else if (max == g)
                    h = (b - r) / d + 2;
                else
                    h = (r - g) / d + 4;

                h /= 6;
            }

            return $"H:{h * 360:F0}, S:{s * 100:F0}%, L:{l * 100:F0}%";
        }

        public string ToCMYK()
        {
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            double k = 1 - Math.Max(r, Math.Max(g, b));

            if (k == 1)
                return "C:0 M:0 Y:0 K:100";

            double c = (1 - r - k) / (1 - k);
            double m = (1 - g - k) / (1 - k);
            double y = (1 - b - k) / (1 - k);

            return $"C:{c * 100:F0}% M:{m * 100:F0}% Y:{y * 100:F0}% K:{k * 100:F0}%";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            RGBColor color = new RGBColor(255, 100, 50);

            Console.WriteLine("HEX: " + color.ToHex());
            Console.WriteLine("HSL: " + color.ToHSL());
            Console.WriteLine("CMYK: " + color.ToCMYK());
        }
    }
}