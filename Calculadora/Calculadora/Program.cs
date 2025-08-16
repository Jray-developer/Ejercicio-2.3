using System;

class Calculadora
{
    static void Main()
    {
        double x = 0, y = 0, resultado;
        char operacion;

        Console.Write("Ingrese la operación (+, -, *, /, !): ");
        operacion = Convert.ToChar(Console.ReadLine());

        Console.Write("Ingrese el primer número: ");
        x = Convert.ToDouble(Console.ReadLine());

        if (operacion != '!')
        {
            Console.Write("Ingrese el segundo número: ");
            y = Convert.ToDouble(Console.ReadLine());
        }

        switch (operacion)
        {
            case '+':
                resultado = x + y;
                Console.WriteLine($"Resultado: {resultado}");
                break;

            case '-':
                resultado = x - y;
                Console.WriteLine($"Resultado: {resultado}");
                break;

            case '*':
                resultado = x * y;
                Console.WriteLine($"Resultado: {resultado}");
                break;

            case '/':
                if (y != 0)
                {
                    resultado = x / y;
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                }
                break;

            case '!':

                long factorial = 1;
                for (int i = 1; i <= (int)x; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"Resultado: {x}! = {factorial}");


                break;

            default:
                Console.WriteLine("Operación no válida. Intente con +, -, *, / o !");
                break;
        }
    }
}