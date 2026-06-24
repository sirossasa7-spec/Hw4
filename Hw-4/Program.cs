namespace Hw_4
{
    struct Vector3D
    {
        public double X;
        public double Y;
        public double Z;

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3D Multiply(double number)
        {
            return new Vector3D(X * number, Y * number, Z * number);
        }

        public Vector3D Add(Vector3D other)
        {
            return new Vector3D(X + other.X, Y + other.Y, Z + other.Z);
        }

        public Vector3D Subtract(Vector3D other)
        {
            return new Vector3D(X - other.X, Y - other.Y, Z - other.Z);
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vector3D v1 = new Vector3D(1, 2, 3);
            Vector3D v2 = new Vector3D(4, 5, 6);

            Console.WriteLine("Вектор 1: " + v1);
            Console.WriteLine("Вектор 2: " + v2);

            Console.WriteLine("Додавання: " + v1.Add(v2));
            Console.WriteLine("Віднімання: " + v1.Subtract(v2));
            Console.WriteLine("Множення на 2: " + v1.Multiply(2));
        }
    }
}