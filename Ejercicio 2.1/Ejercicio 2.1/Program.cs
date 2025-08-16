using System;  

namespace MiPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Usted ya puede votar.");
            }
            else
            {
                Console.WriteLine("Usted aún no puede votar.");
            }

            Console.WriteLine("Ejercicio 2");
            Console.Write("Ingrese el día de la semana (1=Lunes, 7=Domingo): ");
            int dia = int.Parse(Console.ReadLine());

            if (dia == 1 || dia == 2)
            {
                Console.WriteLine("Es Inicio de Semana.");
            }
            else if (dia >= 3 && dia <= 5)
            {
                Console.WriteLine("Es Mediados de Semana.");
            }
            else if (dia == 6 || dia == 7)
            {
                Console.WriteLine("Es Fin de Semana.");
            }

            Console.WriteLine("Ejercicio 3");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"7 x {i} = {7 * i}");
            }
        }
    }
}