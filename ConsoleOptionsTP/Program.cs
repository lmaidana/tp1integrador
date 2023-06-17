using ConsoleTables;
using ConsoleOptionsTP.Clases;
using ConsoleOptionsTP.Classes;

namespace ConsoleOptionsTP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                showOptionsTable();

                var option = Console.ReadLine();

                while (!Validator.IsValidOption(option))
                {
                    Msgs.WarningMsg("Opcion incorrecta!");
                    Console.ResetColor();
                    showOptionsTable();
                    option = Console.ReadLine();
                }
                Console.Clear();
                if (option.Contains('s'))
                {
                    var input1 = Validator.GetInput();
                    var input2 = Validator.GetInput();

                    if (int.TryParse(input1, out int intInput1) && int.TryParse(input2, out int intInput2)) 
                    {
                        int result = Operators.Addition(intInput1, intInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                    else if (float.TryParse(input1, out float floatInput1) && float.TryParse(input2, out float floatInput2))
                    {
                        float result = Operators.Addition(floatInput1, floatInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                }

                if (option.Contains('r'))
                {
                    var input1 = Validator.GetInput();
                    var input2 = Validator.GetInput();

                    if (int.TryParse(input1, out int intInput1) && int.TryParse(input2, out int intInput2))
                    {
                        int result = Operators.Substract(intInput1, intInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                    else if (float.TryParse(input1, out float floatInput1) && float.TryParse(input2, out float floatInput2))
                    {
                        float result = Operators.Substract(floatInput1, floatInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                }

                if (option.Contains('m'))
                {
                    var input1 = Validator.GetInput();
                    var input2 = Validator.GetInput();

                    if (int.TryParse(input1, out int intInput1) && int.TryParse(input2, out int intInput2))
                    {
                        int result = Operators.Multiply(intInput1, intInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                    else if (float.TryParse(input1, out float floatInput1) && float.TryParse(input2, out float floatInput2))
                    {
                        float result = Operators.Multiply(floatInput1, floatInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                }

                if (option.Contains('d'))
                {
                    var input1 = Validator.GetInput();
                    var input2 = Validator.GetInput();

                    if (int.TryParse(input1, out int intInput1) && int.TryParse(input2, out int intInput2))
                    {
                        try
                        {
                            int result = Operators.Divide(intInput1, intInput2);
                            Msgs.SuccessMsg("Resultado: " + result +"\n");
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else if (float.TryParse(input1, out float floatInput1) && float.TryParse(input2, out float floatInput2))
                    {
                        try
                        {
                            float result = Operators.Divide(floatInput1, floatInput2);
                            Msgs.SuccessMsg("Resultado: " + result +"\n");
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }

                if (option.Contains('f'))
                {
                    var input1 = Validator.GetInput();
                    var input2 = Validator.GetInput();

                    if (int.TryParse(input1, out int intInput1) && int.TryParse(input2, out int intInput2))
                    {
                        try
                        {
                            int result = Operators.Modulo(intInput1, intInput2);
                            Msgs.SuccessMsg("Resultado: " + result +"\n");
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else if (float.TryParse(input1, out float floatInput1) && float.TryParse(input2, out float floatInput2))
                    {
                        try
                        {
                            float result = Operators.Modulo(floatInput1, floatInput2);
                            Msgs.SuccessMsg("Resultado: " + result +"\n");
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }

                if (option.Contains('p'))
                {
                    var input1 = Validator.GetInput();
                    var input2 = Validator.GetInput();

                    if (int.TryParse(input1, out int intInput1) && int.TryParse(input2, out int intInput2))
                    {
                        double result = Operators.Potencia(intInput1, intInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                    else if (float.TryParse(input1, out float floatInput1) && float.TryParse(input2, out float floatInput2))
                    {
                        double result = Operators.Potencia(floatInput1, floatInput2);
                        Msgs.SuccessMsg("Resultado: " + result +"\n");
                    }
                }

                if (option.Contains('x'))
                {
                    var input1 = Validator.GetInput();
                    var input2 = Validator.GetInput();
                    var input3 = Validator.GetInput();

                    float.TryParse(input1, out float floatInput1);
                    float.TryParse(input2, out float floatInput2);
                    float.TryParse(input3, out float floatInput3);

                    float result = Operators.Promedio(floatInput1, floatInput2, floatInput3);
                    Msgs.SuccessMsg("Resultado: " + result +"\n");
                }

                if (option.Contains('k'))
                {
                    Console.WriteLine("\nEliga forma: t- Triangulo | c- Circulo");
                    var shapeOption= Console.ReadLine();

                    while (!Validator.IsValidShapeOption(shapeOption))
                    {
                        Msgs.WarningMsg("Opcion incorrecta, t- Triangulo | c- Circulo\n");
                        shapeOption = Console.ReadLine();
                    }

                    if (shapeOption.Contains('c'))
                    {
                        Console.WriteLine("\nArea o perimetro: a- Area | p- perimetro");
                        var shapeCalculatorOption = Console.ReadLine();

                        while (!Validator.IsValidCircleOption(shapeCalculatorOption))
                        {
                            Msgs.WarningMsg("Opcion incorrecta, a- Area | p- perimetro\n");
                            shapeCalculatorOption = Console.ReadLine();
                        }

                        Console.WriteLine("Ingrese radio");
                        var input = Console.ReadLine();
                        float radio = Validator.GetPositiveNumbers(input);
                        ShapeCalculator shapeCalculator = new();
                        
                        if (shapeCalculatorOption == "a")
                        {
                            double area = shapeCalculator.Area(new Circle(radio));
                            Msgs.SuccessMsg("El area del circulo es: "+ area + "\n");
                        }
                        else if (shapeCalculatorOption == "p") 
                        {
                            double perimetro = shapeCalculator.Perimetro(new Circle(radio));
                            Msgs.SuccessMsg("El perimetro del circulo es: " + perimetro + "\n");
                        }
                    }
                    else if (shapeOption.Contains('t'))
                    {
                        Console.WriteLine("Ingrese base del triangulo:");
                        var input = Console.ReadLine();
                        float baseTriangle = Validator.GetPositiveNumbers(input);
                        Console.WriteLine("Ingrese altura del triangulo:");
                        var input2 = Console.ReadLine();
                        float heightTriangle = Validator.GetPositiveNumbers(input2);
                        ShapeCalculator shapeCalculator = new ();
                        double area = shapeCalculator.Area(new Triangle(baseTriangle,heightTriangle));
                        Msgs.SuccessMsg("El area del triangulo es: "+ area + "\n");

                    }
                }
                if (option.Contains('o'))
                {
                    Console.WriteLine("Grados celsius a convertir:");
                    var input1 = Validator.GetInput();
                    float.TryParse(input1, out float grados);
                    float fh = grados * 9 / 5 + 32;
                    Msgs.SuccessMsg("Grados en farenheit: "+ fh+"\n");
                }
                if (option.Contains('y'))
                {
                    var input1 = Validator.GetInput();
                    showOperatorsTable();
                    var operador = Console.ReadLine();
                    operador = Validator.IsValidOperator(operador);
                    var input2 = Validator.GetInput();
                    float.TryParse(input1, out float floatInput1);
                    float.TryParse(input2, out float floatInput2);

                    Calculadora c = new Calculadora(floatInput1, floatInput2);

                    if (operador == "+")
                    {
                        var resultado = c.Calcular(new Addition());
                        Msgs.SuccessMsg("Resultado: " + resultado + "\n");
                    }
                    else if (operador == "-")
                    {
                        var resultado = c.Calcular(new Subtraction());
                        Msgs.SuccessMsg("Resultado: " + resultado + "\n");
                    }
                    else if (operador == "/")
                    {
                        var resultado = c.Calcular(new Division());
                        Msgs.SuccessMsg("Resultado: " + resultado + "\n");
                    }
                    else if (operador == "#")
                    {
                        var resultado = c.Calcular(new Multiplication());
                        Msgs.SuccessMsg("Resultado: " + resultado + "\n");
                    }

                }
                if (option.Contains('h'))
                {
                    Console.WriteLine("Centimetros a convertir:");
                    float input1 = Validator.GetPositiveNumbers(Console.ReadLine());

                    double result = input1 / 2.54;
                    Msgs.SuccessMsg("En pulgadas: " + result+"\n");
                }
                if (option.Contains('u'))
                {
                    Console.WriteLine("Ingrese cantidad de Hot Dogs:");
                    int input1 = Validator.GetPositiveInteger(Console.ReadLine());

                    Console.WriteLine("Ingrese cantidad de French Fries:");
                    int input2 = Validator.GetPositiveInteger(Console.ReadLine());

                    Console.WriteLine("Ingrese cantidad de Soda:");
                    int input3 = Validator.GetPositiveInteger(Console.ReadLine());

                    Bill bill = new(input2, input1, input3);
                    double result = bill.CalculateBill();

                    Msgs.SuccessMsg("Total a pagar: " + result + "\n");
                }
                if (option.Contains('w'))
                {
                    Console.WriteLine("Ingrese cantidad de Pesos:");
                    double input1 = Validator.GetPositiveNumbers(Console.ReadLine());

                    Console.WriteLine("Ingrese cotizacion del dolar:");
                    double input2 = Validator.GetPositiveNumbers(Console.ReadLine());

                    var result = new DolarConverter(input1,input2).Convert();
                    Msgs.SuccessMsg("Valor en pesos ingresado equivale a : " + result + " dolares \n");
                }
                if (option.Contains('v'))
                {
                    var suma = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"Ingrese nota {i+1}:");
                        var input = Validator.GetPositiveInteger(Console.ReadLine());
                        suma += input;
                    }
                    float promedio = new Division().Calcular(suma, 4);
                    Msgs.SuccessMsg($"Promedio de notas ingresadas: {promedio}");
                }
                if (option.Contains('z'))
                {
                    var value = Validator.GetInput();
                    
                    Pto7 aux = new ();
                    double a = aux.CompoundOne(double.Parse(value));
                    Msgs.SuccessMsg($"Valor ingresado aumentado con ++ de prefijo {a}\n");

                    var value2 = Validator.GetInput();
                    Msgs.SuccessMsg($"Valor: {value} fue aumentado con += al valor {value2} y su resultado es : {aux.CompoundTwo(double.Parse(value), double.Parse(value2))}\n\n");

                    Msgs.SuccessMsg("Xor ^ de un False-True : " + aux.XoR(false, true)+"\n");
                    Msgs.SuccessMsg("Or cortocicuitado || de un False-True : " + aux.OrShortCircuit(false,true)+"\n");
                    Console.WriteLine("\n\nAhora puede ingresar una cadena cualquiera o '1' para enviar un nulo. Vamos a reconocer si el valor es nulo o no:");
                    var input = Console.ReadLine();
                    if (input == "1") 
                    {
                        Msgs.ErrorMsg(aux.NullReconginzer(null)+"\n");
                    }
                    else
                    {
                        Console.WriteLine("Ha ingresado " + aux.NullReconginzer(input)+" el cual no envía un nulo.\n");
                    }

                    int bin = -7;
                    var result = aux.BinaryOperation(bin);
                    Msgs.SuccessMsg("valor obtenido en decimal luego de un desplazamiento de un bit a la derecha: " + result);

                }

                Console.ResetColor();
            }
        }

        private static void showOptionsTable()
        {
            Console.WriteLine("\nBienvenido!\n");
            ConsoleTable consoleTable = new("Que operacion quiere realizar ?");
            consoleTable.AddRow("s - Suma");
            consoleTable.AddRow("r- Resta");
            consoleTable.AddRow("m- Multiplicacion");
            consoleTable.AddRow("f- Modulo");
            consoleTable.AddRow("p- Potencia");
            consoleTable.AddRow("x- Promedio");
            consoleTable.AddRow("k- CalculadoraDeFormas");
            consoleTable.AddRow("y- CalculadoraSOLID");
            consoleTable.AddRow("o- Conversor Celsius a Farenheit");
            consoleTable.AddRow("h- Conversor Centimetros a Pulgadas");
            consoleTable.AddRow("u- Punto 5 Restaurant");
            consoleTable.AddRow("w- Punto 4 Conversor dolar");
            consoleTable.AddRow("v- Punto 2 Promedio");
            consoleTable.AddRow("z- Punto 7 Shifting");
            consoleTable.Write(Format.Alternative);
        }
        private static void showOperatorsTable()
        {
            ConsoleTable consoleTable = new("Que operacion quiere realizar ?");
            consoleTable.AddRow("+ Suma");
            consoleTable.AddRow("- Resta");
            consoleTable.AddRow("# Multiplicacion");
            consoleTable.AddRow("/ Division");
            consoleTable.Write(Format.Alternative);
        }
    }
}