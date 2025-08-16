using System;
/*
class Persona
{
    public string Nombre;
    public int Edad;
    public string Sexo;
    public Double Altura;
    public int Peso;

    public void Saludar()
    {
        Console.WriteLine($"Hola soy {Nombre} tengo {Edad} años, mido {Altura} metros, peso {Peso} libras y soy de sexo {Sexo}");
    }
}

class Program
{
    static void Main()
    {
        Persona alumno = new Persona();
        alumno.Nombre = "Luis Pedro";
        alumno.Edad = 25;
        alumno.Altura = 1.70;
        alumno.Peso = 170;
        alumno.Sexo = "Masculino";
        alumno.Saludar();
    }
}
*/
class Vehiculo
{
    public string Marca;
    public int Año;
    public string Color;

    public void Imprimir()
    {
        Console.WriteLine($"Auto de marca {Marca}, año {Año} y color {Color}");
    }
}

class Program
{
    static void Main()
    {
        Vehiculo auto1 = new Vehiculo();
        auto1.Marca = "Toyota";
        auto1.Año = 2006;
        auto1.Color = "Rojo";
        auto1.Imprimir();

        Vehiculo auto2 = new Vehiculo();
        auto2.Marca = "Honda";
        auto2.Año = 2004;
        auto2.Color = "Negro";
        auto2.Imprimir();

    }
}