
namespace ConsoleOptionsTP.Clases
{
    internal class Triangle
    {
        private double Base { get; set; }
        private double Altura { get; set; }
        public Triangle(double widht, double altura)
        {
            Base = widht;
            Altura = altura;
        }

        internal double Area()
        {
            return Base * Altura / 2;
        }
    }
}
