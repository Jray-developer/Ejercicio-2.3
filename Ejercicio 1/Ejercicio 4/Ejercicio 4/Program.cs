using System;

class Producto
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = Multiplicar(num1, num2);
        Console.WriteLine($"El producto de {num1} y {num2} es: {resultado}");
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }
}
/*
class Rectangulo
{
    static void Main()
    {
        Console.Write("Ingrese el ancho del rectángulo: ");
        double ancho = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el alto del rectángulo: ");
        double alto = Convert.ToDouble(Console.ReadLine());

        double area = CalcularArea(ancho, alto);
        Console.WriteLine($"El área del rectángulo es: {area}");
    }

    static double CalcularArea(double ancho, double alto)
    {
        return ancho * alto;
    }
}
*/
/*
class NumeroParImpar
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        string resultado2 = EsPar(numero);
        Console.WriteLine($"El número {numero} es {resultado2}");
    }

    static string EsPar(int n)
    {
        if (n % 2 == 0)
        {
            return "par";
        }
        else
        {
            return "impar";
        }
    }
}
*/