namespace Hw_4
{
    struct DecimalNumber
    {
        public int Number;

        public DecimalNumber(int number)
        {
            Number = number;
        }

        public string ToBinary()
        {
            return Convert.ToString(Number, 2);
        }

        public string ToOctal()
        {
            return Convert.ToString(Number, 8);
        }

        public string ToHex()
        {
            return Convert.ToString(Number, 16).ToUpper();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть десяткове число: ");
            int n = int.Parse(Console.ReadLine());

            DecimalNumber number = new DecimalNumber(n);

            Console.WriteLine("Двійкова: " + number.ToBinary());
            Console.WriteLine("Вісімкова: " + number.ToOctal());
            Console.WriteLine("Шістнадцяткова: " + number.ToHex());
        }
    }
}