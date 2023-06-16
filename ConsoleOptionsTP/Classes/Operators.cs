namespace ConsoleOptionsTP.Clases
{
    internal class Operators
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static float Addition(float a, float b)
        {
            return a + b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static float Substract(float a, float b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                Msgs.ErrorMsg("No se puede dividir por cero");
                throw new DivideByZeroException();
            }
            return a / b;
        }

        public static float Divide(float a, float b)
        {
            if (b == 0)
            {
                Msgs.ErrorMsg("No se puede dividir por cero");
                throw new DivideByZeroException();
            }
            return a / b;
        }

        public static int Modulo(int a, int b)
        {
            if (b == 0)
            {
                Msgs.ErrorMsg("No se puede dividir por cero");
                throw new DivideByZeroException();
            }
            return a % b;
        }

        public static float Modulo(float a, float b)
        {
            if (b == 0)
            {
                Msgs.ErrorMsg("No se puede dividir por cero");
                throw new DivideByZeroException();
            }
            return a % b;
        }

        public static double Potencia(int a, int b)
        {
            return Math.Pow(a, b);
        }

        public static double Potencia(float a, float b)
        {
            return Math.Pow(a, b);
        }

        internal static float Promedio(float a, float b, float c)
        {
            return (a + b + c) / 3;
        }
    }
}
