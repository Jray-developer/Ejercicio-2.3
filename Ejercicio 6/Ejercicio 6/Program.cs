/*
using System;
using System.Collections.Generic;
using System.Linq;

class Estudiante
{
    public string Nombre { get; set; }
    public int Nota { get; set; }
}

class Program
{
    static void Main()
    {
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante { Nombre = "Ana", Nota = 85 },
            new Estudiante { Nombre = "Luis", Nota = 59 },
            new Estudiante { Nombre = "María", Nota = 70 },
            new Estudiante { Nombre = "Carlos", Nota = 45 },
            new Estudiante { Nombre = "Sofía", Nota = 95 }
        };

        var aprobados = from est in estudiantes
                        where est.Nota >= 61
                        select est;

        Console.WriteLine("Estudiantes aprobados:");
        foreach (var est in aprobados)
        {
            Console.WriteLine($"Nombre: {est.Nombre}, Nota: {est.Nota}");
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Estudiante
{
    public string Nombre { get; set; }
    public int Nota { get; set; }
    public double Estatura { get; set; }    
}

class Program
{
    static void Main()
    {
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante { Nombre = "Ana", Nota = 85, Estatura = 1.54 },
            new Estudiante { Nombre = "Luis", Nota = 59, Estatura = 1.75 },
            new Estudiante { Nombre = "María", Nota = 70, Estatura = 1.62 },
            new Estudiante { Nombre = "José", Nota = 82, Estatura = 1.68 },
            new Estudiante { Nombre = "Juan", Nota = 61, Estatura = 1.78 },
            new Estudiante { Nombre = "Luis", Nota = 80, Estatura = 1.66 },
            new Estudiante { Nombre = "Carlos", Nota = 45, Estatura = 1.70 },
            new Estudiante { Nombre = "Sofía", Nota = 95, Estatura = 1.66 }
        };

        var aprobados = from est in estudiantes
                        where est.Nota >= 61 && est.Estatura > 1.65
                        select est;

        Console.WriteLine("Estudiantes aprobados:");
        foreach (var est in aprobados)
        {
            Console.WriteLine($"Nombre: {est.Nombre}, Nota: {est.Nota}, Estatura: {est.Estatura}");
        }
    }
}