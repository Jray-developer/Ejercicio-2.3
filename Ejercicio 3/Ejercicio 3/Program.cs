using System;

class Libro
{
    public string Nombre;
    public string Autor;
    public int AnioPublicacion;
    

 
    public void MostrarDatos()
    {
        Console.WriteLine($"Título: {Nombre}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Año de Publicación: {AnioPublicacion}");

    }
}

class Program
{
    static void Main()
    {
        Libro miLibro = new Libro();

        Console.Write("Ingrese el nombre del libro: ");
        miLibro.Nombre = Console.ReadLine();

        Console.Write("Ingrese el autor del libro: ");
        miLibro.Autor = Console.ReadLine();

        Console.Write("Ingrese el año de publicación: ");
        miLibro.AnioPublicacion = int.Parse(Console.ReadLine());

        miLibro.MostrarDatos();

    }
}