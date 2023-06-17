namespace ConsoleOptionsTP.Clases
{
    internal class Circle
    {
        private double Radio { get; set; }
        public Circle(double radio)
        {
            Radio = radio;
        }

        internal double Area()
        {
            return Math.PI * (Radio * Radio);
        }

        internal double Perimetro()
        {
            return 2 * Math.PI * Radio;
        }

    }
}
