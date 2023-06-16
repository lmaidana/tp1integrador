using ConsoleOptionsTP.Interfaces;

namespace ConsoleOptionsTP.Clases
{
    internal class Multiplication : ICalculable
    {
        public Multiplication()
        {
        }

        public float Calcular(float a, float b)
        {
            return a * b;
        }
    }
}