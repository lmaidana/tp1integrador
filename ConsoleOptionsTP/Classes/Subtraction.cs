using ConsoleOptionsTP.Interfaces;

namespace ConsoleOptionsTP.Clases
{
    internal class Subtraction : ICalculable
    {
        public Subtraction()
        {
        }

        public float Calcular(float a, float b)
        {
            return a - b;
        }
    }
}