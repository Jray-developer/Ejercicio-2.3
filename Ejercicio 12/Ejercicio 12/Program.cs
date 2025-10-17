/*
using System;

class Figura
{
    public virtual double CalcularArea()
    {
        return 0;
    }
}

class Triangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double b, double h)
    {
        Base = b;
        Altura = h;
    }

    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }
}

class Rectangulo : Figura
{
    public double Largo { get; set; }
    public double Ancho { get; set; }

    public Rectangulo(double l, double a)
    {
        Largo = l;
        Ancho = a;
    }

    public override double CalcularArea()
    {
        return Largo * Ancho;
    }
}

class Circulo : Figura
{
    public double Radio { get; set; }

    public Circulo(double r)
    {
        Radio = r;
    }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}

class Program
{
    static void Main()
    {
        Figura f1 = new Triangulo(10, 5);
        Figura f2 = new Rectangulo(4, 6);
        Figura f3 = new Circulo(3);

        Console.WriteLine($"Área del triángulo: {f1.CalcularArea()}");
        Console.WriteLine($"Área del rectángulo: {f2.CalcularArea()}");
        Console.WriteLine($"Área del círculo: {f3.CalcularArea()}");
    }
}
*/
/*
using System;

class Producto
{
    public string Nombre { get; set; }

    public Producto(string nombre)
    {
        Nombre = nombre;
    }

    public virtual void MostrarDescripcion()
    {
        Console.WriteLine("Descripción genérica del producto.");
    }
}

class Electronico : Producto
{
    public Electronico(string nombre) : base(nombre) { }

    public override void MostrarDescripcion()
    {
        Console.WriteLine($"{Nombre}: Dispositivo electrónico con garantía de 1 año.");
    }
}

class Alimento : Producto
{
    public Alimento(string nombre) : base(nombre) { }

    public override void MostrarDescripcion()
    {
        Console.WriteLine($"{Nombre}: Producto alimenticio, mantener en lugar fresco.");
    }
}

class Ropa : Producto
{
    public Ropa(string nombre) : base(nombre) { }

    public override void MostrarDescripcion()
    {
        Console.WriteLine($"{Nombre}: Prenda de vestir de alta calidad y cómodos materiales.");
    }
}


class Program2
{
    static void Main()
    {
        Producto p1 = new Electronico("Teléfono");
        Producto p2 = new Alimento("Pan");
        Producto p3 = new Ropa("Camisa");

        p1.MostrarDescripcion();
        p2.MostrarDescripcion();
        p3.MostrarDescripcion();
    }
}
*/
using System;

class Pago
{
    public double Monto { get; set; }

    public Pago(double monto)
    {
        Monto = monto;
    }

    public virtual void Procesar()
    {
        Console.WriteLine("Procesando pago...");
    }
}

class PagoEfectivo : Pago
{
    public PagoEfectivo(double monto) : base(monto) { }

    public override void Procesar()
    {
        Console.WriteLine($"Pago en efectivo recibido: Q{Monto}");
    }
}

class PagoTarjeta : Pago
{
    public string NumeroTarjeta { get; set; }

    public PagoTarjeta(double monto, string numero) : base(monto)
    {
        NumeroTarjeta = numero;
    }

    public override void Procesar()
    {
        Console.WriteLine($"Validando tarjeta {NumeroTarjeta}...");
        Console.WriteLine($"Pago de Q{Monto} realizado con tarjeta.");
    }
}

class PagoTransferencia : Pago
{
    public string Banco { get; set; }

    public PagoTransferencia(double monto, string banco) : base(monto)
    {
        Banco = banco;
    }

    public override void Procesar()
    {
        Console.WriteLine($"Confirmando transferencia desde {Banco} por Q{Monto}...");
        Console.WriteLine("Pago por transferencia completado.");
    }
}

class Program3
{
    static void Main()
    {
        Pago p1 = new PagoEfectivo(150);
        Pago p2 = new PagoTarjeta(500, "1234-5678-9012-3456");
        Pago p3 = new PagoTransferencia(1200, "Banco G&T");

        p1.Procesar();
        p2.Procesar();
        p3.Procesar();
    }
}

