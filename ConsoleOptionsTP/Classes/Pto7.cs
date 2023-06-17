
namespace ConsoleOptionsTP.Classes
{
    internal class Pto7
    {

        internal double CompoundOne(double a)
        {
            Console.WriteLine($"Valor antes de ser aumentado con ++ de prefijo: {a}");
            return ++a;
        }

        internal double CompoundTwo(double a, double b)
        {
            return a += b;
        }

        internal bool XoR(bool a, bool b)
        {
            return a & b;
        }

        internal bool OrShortCircuit(bool a,bool  b)
        {
            return a || b;
        }

        internal string NullReconginzer(string? value)
        {
            if (value == "")
            {
                value = "ENTER";
            }
            string result = value ?? "Es nulo!";
            return result;
        }

        internal string BinaryOperation(int value)
        {
            Console.WriteLine("-7 en decimal   antes: " + Convert.ToString(value, toBase: 2).PadLeft(32, '0'));
            Console.WriteLine("-7 en decimal despues: " + Convert.ToString(value >>> 1, toBase: 2).PadLeft(32, '0'));
            return Convert.ToString(value >>> 1, toBase: 10);
        }


    }
}
