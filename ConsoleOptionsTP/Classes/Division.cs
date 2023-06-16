using ConsoleOptionsTP.Interfaces;

namespace ConsoleOptionsTP.Clases
{
    internal class Division : ICalculable
    {
        public Division()
        {

        }

        public float Calcular(float a, float b)
        {
            return a / b;
        }
    }
}
