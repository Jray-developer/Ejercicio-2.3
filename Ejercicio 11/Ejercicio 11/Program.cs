/*
using System;

class Monitor
{
    public string Marca { get; set; }
    public Monitor(string marca)
    {
        Marca = marca;
    }
}

class Teclado
{
    public string Tipo { get; set; }
    public Teclado(string tipo)
    {
        Tipo = tipo;
    }
}

class Mouse
{
    public string Modelo { get; set; }
    public Mouse(string modelo)
    {
        Modelo = modelo;
    }
}

class Computadora
{
    private Monitor monitor;
    private Teclado teclado;
    private Mouse mouse;

    public Computadora(string marcaMonitor, string tipoTeclado, string modeloMouse)
    {
        monitor = new Monitor(marcaMonitor);
        teclado = new Teclado(tipoTeclado);
        mouse = new Mouse(modeloMouse);
    }

    public void MostrarComponentes()
    {
        Console.WriteLine("=== Componentes de la Computadora ===");
        Console.WriteLine($"Monitor: {monitor.Marca}");
        Console.WriteLine($"Teclado: {teclado.Tipo}");
        Console.WriteLine($"Mouse: {mouse.Modelo}");
    }
}

class Program
{
    static void Main()
    {
        Computadora pc = new Computadora("Xiami", "Mecánico", "Logitech G303");
        pc.MostrarComponentes();
        Console.WriteLine();
    }
}
*/
/*
using System;
using System.Collections.Generic;

class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public Libro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }
}

class Estante
{
    private List<Libro> libros = new List<Libro>(); 

    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
    }

    public void MostrarLibros()
    {
        Console.WriteLine("Libros en el estante:");
        foreach (var libro in libros)
        {
            Console.WriteLine($"- {libro.Titulo} ({libro.Autor})");
        }
    }
}

class Bibliotecario
{
    public string Nombre { get; set; }
    public List<Estante> Estantes { get; set; } = new List<Estante>(); 

    public Bibliotecario(string nombre)
    {
        Nombre = nombre;
    }

    public void AgregarEstante(Estante estante)
    {
        Estantes.Add(estante);
    }

    public void MostrarBiblioteca()
    {
        Console.WriteLine($"=== Bibliotecario: {Nombre} ===");
        foreach (var estante in Estantes)
        {
            estante.MostrarLibros();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Libro l1 = new Libro("Cien Años de Soledad", "Gabriel García Márquez");
        Libro l2 = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes");

        Estante estante = new Estante();
        estante.AgregarLibro(l1);
        estante.AgregarLibro(l2);

        Bibliotecario biblio = new Bibliotecario("Laura");
        biblio.AgregarEstante(estante);

        biblio.MostrarBiblioteca();
        Console.WriteLine();
    }
}
*/

using System;
using System.Collections.Generic;

class Habitacion
{
    public string Nombre { get; set; }
    public Habitacion(string nombre)
    {
        Nombre = nombre;
    }
}

class Dueno
{
    public string Nombre { get; set; }
    public Dueno(string nombre)
    {
        Nombre = nombre;
    }
}

class Casa
{
    private List<Habitacion> habitaciones = new List<Habitacion>(); 
    public Dueno DuenoCasa { get; set; } 

    public Casa(Dueno dueno)
    {
        DuenoCasa = dueno;
    }

    public void AgregarHabitacion(string nombre)
    {
        habitaciones.Add(new Habitacion(nombre));
    }

    public void MostrarInfo()
    {
        Console.WriteLine("=== Información de la Casa ===");
        Console.WriteLine($"Dueño: {DuenoCasa.Nombre}");
        Console.WriteLine("Habitaciones:");
        foreach (var h in habitaciones)
        {
            Console.WriteLine($"- {h.Nombre}");
        }
    }
}


class Program
{
    static void Main()
    {
        Dueno dueno = new Dueno("Carlos");

        Casa casa = new Casa(dueno);
        casa.AgregarHabitacion("Sala");
        casa.AgregarHabitacion("Cocina");
        casa.AgregarHabitacion("Dormitorio principal");

        casa.MostrarInfo();
    }
}
