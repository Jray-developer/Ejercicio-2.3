/*
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = num1 / num2;
            Console.WriteLine($"Resultado de la división: {resultado}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar un número válido.");
        }
        finally
        {
            Console.WriteLine("Programa finalizado.");
        }
    }
}
*/
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese el precio del producto: ");
            string input = Console.ReadLine();

            double precio = Convert.ToDouble(input);

            if (precio <= 0)
            {
                throw new ArgumentException("Error: El precio debe ser un número positivo.");
            }

            Console.WriteLine($"Precio ingresado correctamente: {precio:C}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar un valor numérico.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Programa finalizado.");
        }
    }
}