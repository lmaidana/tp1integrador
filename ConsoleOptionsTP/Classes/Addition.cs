using ConsoleOptionsTP.Interfaces;

namespace ConsoleOptionsTP.Clases
{
    internal class Addition : ICalculable
    {
        public Addition()
        {
        }

        public float Calcular(float a, float b)
        {
            return a + b;
        }
    }
}