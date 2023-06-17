namespace ConsoleOptionsTP.Clases
{
    internal class ShapeCalculator
    {
        public ShapeCalculator() { }

        public double Area(object shape)
        {
            if (shape is Triangle)
            {
                return ((Triangle)shape).Area();
            }
            else if (shape is Circle)
            {
                return ((Circle)shape).Area();
            }
            else { throw new Exception("No se conoce la forma"); }
        }

        public double Perimetro(object shape)
        {
            if (shape is Circle)
            {
                return ((Circle)shape).Perimetro();
            }
            else { throw new Exception("No se conoce la forma"); }
        }
    }
}
