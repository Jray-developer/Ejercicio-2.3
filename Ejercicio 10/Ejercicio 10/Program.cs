using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        List<Figura> figuras = new List<Figura>
        {
            new Circulo(5),
            new Rectangulo(4, 6)
        };

        Console.WriteLine("Áreas de las figuras:");
        foreach (var f in figuras)
        {
            Console.WriteLine($"Área: {f.CalcularArea():0.00}");
        }

        List<Instrumento> instrumentos = new List<Instrumento>
        {
            new Guitarra("Fender"),
            new Piano("Yamaha"),
            new Instrumento("Genérico")
        };

        Console.WriteLine("Sonidos de los instrumentos:");
        foreach (var i in instrumentos)
        {
            i.Tocar(); 
        }
    }
}

abstract class Figura
{
    public abstract double CalcularArea();
}

class Circulo : Figura
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}

class Rectangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Rectangulo(double b, double h)
    {
        Base = b;
        Altura = h;
    }

    public override double CalcularArea()
    {
        return Base * Altura;
    }
}

class Instrumento
{
    public string Nombre { get; set; }

    public Instrumento(string nombre)
    {
        Nombre = nombre;
    }
    public virtual void Tocar()
    {
        Console.WriteLine($"El instrumento {Nombre} produce un sonido genérico.");
    }
}

class Guitarra : Instrumento
{
    public Guitarra(string nombre) : base(nombre) { }

    public override void Tocar()
    {
        Console.WriteLine($"La guitarra {Nombre} suena: ¡Strum, strum!");
    }
}

class Piano : Instrumento
{
    public Piano(string nombre) : base(nombre) { }

    public override void Tocar()
    {
        Console.WriteLine($"El piano {Nombre} suena: ♪ Plink, plink ♪");
    }
}

