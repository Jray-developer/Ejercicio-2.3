using System;
using System.Collections.Generic;
using System.Linq;
/*
class Program
{
    static void Main()
    {
        List<string> productos = new List<string> { "Laptop", "Mouse", "Teclado", "Monitor" };

        Console.Write("Nombre del producto: ");
        string Buscador = Console.ReadLine();

        string encontrado = productos.Find(p => p.Equals(Buscador, StringComparison.OrdinalIgnoreCase));

        if (encontrado != null)
            Console.WriteLine($"El producto '{encontrado}' está disponible.");
        else
            Console.WriteLine("Producto no encontrado.");
    }
}
*/

/*
class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public Producto(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

class Program
{
    static void Main()
    {
        List<Producto> listaProductos = new List<Producto>
        {
            new Producto("USB", 75),
            new Producto("Cargador", 95),
            new Producto("Celular", 2500)
        };

        Console.WriteLine("Productos que cuestan mas de Q100:");
        foreach (var prod in listaProductos.Where(p => p.Precio > 100))
        {
            Console.WriteLine($"{prod.Nombre} (Q{prod.Precio})");
        }
    }
}
*/

class Estudiante
{
    public string Nombre { get; set; }
    public int Nota { get; set; }

    public Estudiante(string nombre, int nota)
    {
        Nombre = nombre;
        Nota = nota;
    }
}

class Program
{
    static void Main()
    {
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante("Ana", 80),
            new Estudiante("Pedro", 61),
            new Estudiante("Sofía", 40)
        };

        Console.WriteLine("Estudiantes aprobados (nota ≥ 61):");
        foreach (var est in estudiantes.Where(e => e.Nota >= 61))
        {
            Console.WriteLine($"- {est.Nombre} (Nota: {est.Nota})");
        }

        double promedio = estudiantes.Average(e => e.Nota);
        Console.WriteLine($"\nPromedio general: {promedio:F2}");
    }
}