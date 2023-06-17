
namespace ConsoleOptionsTP.Clases
{
    internal class Validator
    {
        internal static bool IsValidNumber(string? stringInput)
        {
            bool isNumber = int.TryParse(stringInput, out int valueInt);
            bool isFloat = float.TryParse(stringInput, out float valueFloat);
            bool isDecimal = decimal.TryParse(stringInput, out decimal valueDecimal);

            while (string.IsNullOrEmpty(stringInput) || !isNumber && !isFloat && !isDecimal)
            {
                return false;
            }
            return true;
        }
        internal static bool IsValidOption(string option)
        {
            List<string> options = new List<string> { "s" , "r", "m", "d", "f", "p", "x", "k","c", "t", "o", "y","h","u","w","v","z" };

            if (option.Length > 1 || string.IsNullOrEmpty(option))
            {
                return false;
            }

            if (options.Contains(option))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetInput()
        {
            Console.WriteLine("Ingrese numero");
            var input = Console.ReadLine();
            while (!IsValidNumber(input))
            {
                Msgs.WarningMsg("Ingreso incorrecto, vuelva a intentar\n");
                input = Console.ReadLine();
            }
            return input;
        }

        internal static float GetPositiveNumbers(string? input)
        {
            while (!IsValidNumber(input) || !float.TryParse(input, out float value) || value < 0)
            {
                Msgs.WarningMsg("Ingreso incorrecto, vuelva a intentar\n");
                input = Console.ReadLine();
            }
            float.TryParse(input, out float floatValue);
            return floatValue;
        }

        internal static int GetPositiveInteger(string? input)
        {
            while (!IsValidNumber(input) || !int.TryParse(input, out int value) || value < 0)
            {
                Msgs.WarningMsg("Ingreso incorrecto, vuelva a intentar\n");
                input = Console.ReadLine();
            }
            int.TryParse(input, out int intValue);
            return intValue;
        }

        internal static string IsValidOperator(string? input)
        {
            List<string> options = new List<string> { "+", "#", "/", "-" };
            while (string.IsNullOrEmpty(input) || !options.Contains(input))
            {
                Msgs.WarningMsg("Ingreso incorrecto, vuelva a intentar\n");
                input = Console.ReadLine();
            }
            return input;
        }

        internal static bool IsValidShapeOption(string? shapeOption)
        {
            if (shapeOption == "t"|| shapeOption == "c")
            {
                return true;
            }
            return false;
        }

        internal static bool IsValidCircleOption(string? shapeCalculatorOption)
        {
            if (shapeCalculatorOption == "a" || shapeCalculatorOption == "p")
            {
                return true;
            }
            return false;
        }
    }
}
